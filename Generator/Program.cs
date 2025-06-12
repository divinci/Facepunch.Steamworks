namespace Generator
{
	class Program
	{
		public static SteamApiDefinition Definitions;

		static void Main( string[] args )
		{
			var content = System.IO.File.ReadAllText( "C:\\repos\\Bobiverse2\\submodules\\Facepunch.Steamworks\\Generator\\steam_sdk\\steam_api.json" );
			var def = Newtonsoft.Json.JsonConvert.DeserializeObject<SteamApiDefinition>( content );

			Definitions = def;

			var generator = new CodeWriter( def );

			generator.ToFolder( "../Facepunch.Steamworks/Generated/" );
		}
	}
}


