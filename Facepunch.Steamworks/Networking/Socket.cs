
using System.Runtime.InteropServices;

namespace Steamworks.Data
{
	[StructLayout( LayoutKind.Sequential )]
	public struct Socket
	{
		internal uint Id;
		public override readonly string ToString() => Id.ToString();
		public static implicit operator Socket( uint value ) => new Socket() { Id = value };
		public static implicit operator uint( Socket value ) => value.Id;

		/// <summary>
		/// Destroy a listen socket.  All the connections that were accepting on the listen
		/// socket are closed ungracefully.
		/// </summary>
		public readonly bool Close()
		{
			return SteamNetworkingSockets.Internal.CloseListenSocket( Id );
		}

		public readonly SocketManager Manager
		{
			get => SteamNetworkingSockets.GetSocketManager( Id );
			set => SteamNetworkingSockets.SetSocketManager( Id, value );
		}
	}
}