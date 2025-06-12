﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generator
{
	public partial class CodeWriter
	{
		public void GenerateInterface( SteamApiDefinition.Interface iface, string folder )
		{
			sb = new StringBuilder();

			WriteLine( $"using System;" );
			WriteLine( $"using System.Runtime.InteropServices;" );
			WriteLine( $"using System.Text;" );
			WriteLine( $"using System.Threading.Tasks;" );
			WriteLine( $"using Steamworks.Data;" );
			WriteLine();

			WriteLine();

			StartBlock( $"namespace Steamworks" );
			{
				StartBlock( $"internal unsafe partial class {iface.Name} : SteamInterface" );
				{
					if ( !string.IsNullOrWhiteSpace( iface.VersionString ) )
					{
						WriteLine($"public const string Version = \"{iface.VersionString}\";");
						WriteLine();
					}
					
					StartBlock( $"internal {iface.Name}( bool IsGameServer )" );
					{
						WriteLine( $"SetupInterface( IsGameServer );" );
					}
					EndBlock();
					WriteLine();

					if ( iface.Accessors != null )
					{
						foreach ( var func in iface.Accessors )
						{
							WriteLine( $"[DllImport( Platform.LibraryName, EntryPoint = \"{func.Name_Flat}\", CallingConvention = Platform.CC)]" );
							WriteLine( $"internal static extern IntPtr {func.Name_Flat}();" );

							if ( func.Kind == "user" )
							{
								WriteLine( $"public override IntPtr GetUserInterfacePointer() => {func.Name_Flat}();" );
							}
							else  if ( func.Kind == "gameserver" )
							{
								WriteLine( $"public override IntPtr GetServerInterfacePointer() => {func.Name_Flat}();" );
							}
							else if ( func.Kind == "global" )
							{
								WriteLine( $"public override IntPtr GetGlobalInterfacePointer() => {func.Name_Flat}();" );
							}
							else
							{
								throw new Exception( $"unknown Kind {func.Kind}" );
							}
						}

						WriteLine();
						WriteLine();
					}

					foreach ( var func in iface.Methods )
					{
						if ( Cleanup.IsDeprecated( $"{iface.Name}.{func.Name}" ) )
							continue;

						WriteFunction( iface, func );
						WriteLine();
					}

				}
				EndBlock();
			}
			EndBlock();

			CodeWriter.WriteAllText( $"{folder}{iface.Name}.cs", sb.ToString() );
		}

		private void WriteFunction( SteamApiDefinition.Interface iface, SteamApiDefinition.Interface.Method func )
		{
			var returnType = BaseType.Parse( func.ReturnType, null, func.CallResult );
			returnType.Func = func.Name;

			if ( func.Params == null )
				func.Params = new SteamApiDefinition.Interface.Method.Param[0];

			var args = ProcessArgs( func );
			var argstr = string.Join( ", ", args.Where( x => !x.ShouldSkipAsArgument ).Select( x => x.AsArgument() ) ); ;
			var delegateargstr = string.Join( ", ", args.Select( x => x.AsNativeArgument() ) );

			if ( returnType is SteamApiCallType sap )
			{
				sap.CallResult = func.CallResult;
				argstr = string.Join( ", ", args.Select( x => x.AsArgument().Replace( "ref ", " /* ref */ " )  ) );
			}

			WriteLine( $"#region FunctionMeta" );

			WriteLine( $"[DllImport( Platform.LibraryName, EntryPoint = \"{func.FlatName}\", CallingConvention = Platform.CC)]" );
			
			if ( returnType.ReturnAttribute != null )
				WriteLine( returnType.ReturnAttribute );

			WriteLine( $"private static extern {returnType.TypeNameFrom} _{func.Name}( IntPtr self, {delegateargstr} );".Replace( "( IntPtr self,  )", "( IntPtr self )" ) );

			WriteLine();
			WriteLine( $"#endregion" );


			if ( !string.IsNullOrEmpty( func.Desc ) )
			{
				WriteLine( "/// <summary>" );
				WriteLine( $"/// {func.Desc}" );
				WriteLine( "/// </summary>" );
			}

			StartBlock( $"internal {returnType.ReturnType} {func.Name}( {argstr} )".Replace( "(  )", "()" ) );
			{
				var callargs = string.Join( ", ", args.Select( x => x.AsCallArgument() ) );

				//
				// Code before any calls
				//
				foreach ( var arg in args )
				{
					if ( arg is ConstCharType str )
					{
						WriteLine( $"using var str__{str.VarName} = new Utf8StringToNative( {str.VarName} );" );
					}
					else if ( arg is FetchStringType sb )
					{
						WriteLine( $"using var mem__{sb.VarName} = Helpers.TakeMemory();" );
					}
					else if ( arg is LiteralType literal && literal.IsOutValue )
					{
						WriteLine( literal.OutVarDeclaration );
					}
				}

				if ( returnType.IsVoid )
				{
					WriteLine( $"_{func.Name}( Self, {callargs} );".Replace( "( Self,  )", "( Self )" ) );
				}
				else
				{
					WriteLine( $"var returnValue = _{func.Name}( Self, {callargs} );".Replace( "( Self,  )", "( Self )" ) );
				}

				//
				// Code after the call
				//
				foreach ( var arg in args )
				{
					if ( arg is FetchStringType sb )
					{
						WriteLine( $"{sb.VarName} = Helpers.MemoryToString( mem__{sb.VarName} );" );
					}
				}

				//
				// Return
				//
				if ( !returnType.IsVoid )
				{
					WriteLine( returnType.Return( "returnValue" ) );
				}
			}
			EndBlock();
		}
	}
}
