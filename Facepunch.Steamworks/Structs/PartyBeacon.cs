﻿using System.Threading.Tasks;
using Steamworks.Data;

namespace Steamworks
{
	public struct PartyBeacon
	{
		static ISteamParties Internal => SteamParties.Internal;

		internal PartyBeaconID_t Id;

		/// <summary>
		/// Gets the owner of the beacon.
		/// </summary>
		public readonly SteamId Owner
		{
			get
			{
				var owner = default( SteamId );
				var location = default( SteamPartyBeaconLocation_t );
				Internal.GetBeaconDetails( Id, ref owner, ref location, out _ );
				return owner;
			}
		}

		/// <summary>
		/// Gets metadata related to the beacon.
		/// </summary>
		public readonly string MetaData
		{
			get
			{
				var owner = default( SteamId );
				var location = default( SteamPartyBeaconLocation_t );
				_ = Internal.GetBeaconDetails( Id, ref owner, ref location, out var strVal );
				return strVal;
			}
		}

		/// <summary>
		/// Will attempt to join the party. If successful will return a connection string.
		/// If failed, will return <see langword="null"/>
		/// </summary>
		public async readonly Task<string> JoinAsync()
		{
			var result = await Internal.JoinParty( Id );
			if ( !result.HasValue || result.Value.Result != Result.OK )
				return null;

			return result.Value.ConnectStringUTF8();
		}

		/// <summary>
		/// When a user follows your beacon, Steam will reserve one of the open party slots for them, and send your game a ReservationNotification callback. 
		/// When that user joins your party, call this method to notify Steam that the user has joined successfully.
		/// </summary>
		public readonly void OnReservationCompleted( SteamId steamid )
		{
			Internal.OnReservationCompleted( Id, steamid );
		}

		/// <summary>
		/// To cancel a reservation (due to timeout or user input), call this.
		/// Steam will open a new reservation slot.
		/// Note: The user may already be in-flight to your game, so it's possible they will still connect and try to join your party.
		/// </summary>
		public readonly void CancelReservation( SteamId steamid )
		{
			Internal.CancelReservation( Id, steamid );
		}

		/// <summary>
		/// Turn off the beacon.
		/// </summary>
		public readonly bool Destroy()
		{
			return Internal.DestroyBeacon( Id );
		}
	}
}
