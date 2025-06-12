using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;


namespace Steamworks.Data
{
	/// <summary>
	/// Represents a screenshot that was taken by a user.
	/// </summary>
	public struct Screenshot
	{
		internal ScreenshotHandle Value;

		/// <summary>
		/// Tags a user as being visible in the screenshot
		/// </summary>
		public readonly bool TagUser( SteamId user )
		{
			return SteamScreenshots.Internal.TagUser( Value, user );
		}

		/// <summary>
		/// Sets the location of the screenshot.
		/// </summary>
		public readonly bool SetLocation( string location )
		{
			return SteamScreenshots.Internal.SetLocation( Value, location );
		}

		public readonly bool TagPublishedFile( PublishedFileId file )
		{
			return SteamScreenshots.Internal.TagPublishedFile( Value, file );
		}
	}
}
