using System;
using System.Runtime.InteropServices;
using System.Linq;
using Steamworks.Data;
using System.Threading.Tasks;

namespace Steamworks.Data
{
	internal struct DepotId_t : IEquatable<DepotId_t>, IComparable<DepotId_t>
	{
		// Name: DepotId_t, Type: unsigned int
		public uint Value;
		
		public static implicit operator DepotId_t( uint value ) => new DepotId_t(){ Value = value };
		public static implicit operator uint( DepotId_t value ) => value.Value;
		public override readonly string ToString() => Value.ToString();
		public override readonly int GetHashCode() => Value.GetHashCode();
		public override bool Equals( object p ) => this.Equals( (DepotId_t) p );
		public readonly bool Equals( DepotId_t p ) => p.Value == Value;
		public static bool operator ==( DepotId_t a, DepotId_t b ) => a.Equals( b );
		public static bool operator !=( DepotId_t a, DepotId_t b ) => !a.Equals( b );
		public readonly int CompareTo( DepotId_t other ) => Value.CompareTo( other.Value );
	}
	
	internal struct RTime32 : IEquatable<RTime32>, IComparable<RTime32>
	{
		// Name: RTime32, Type: unsigned int
		public uint Value;
		
		public static implicit operator RTime32( uint value ) => new RTime32(){ Value = value };
		public static implicit operator uint( RTime32 value ) => value.Value;
		public override readonly string ToString() => Value.ToString();
		public override readonly int GetHashCode() => Value.GetHashCode();
		public override bool Equals( object p ) => this.Equals( (RTime32) p );
		public readonly bool Equals( RTime32 p ) => p.Value == Value;
		public static bool operator ==( RTime32 a, RTime32 b ) => a.Equals( b );
		public static bool operator !=( RTime32 a, RTime32 b ) => !a.Equals( b );
		public readonly int CompareTo( RTime32 other ) => Value.CompareTo( other.Value );
	}
	
	internal struct SteamAPICall_t : IEquatable<SteamAPICall_t>, IComparable<SteamAPICall_t>
	{
		// Name: SteamAPICall_t, Type: unsigned long long
		public ulong Value;
		
		public static implicit operator SteamAPICall_t( ulong value ) => new SteamAPICall_t(){ Value = value };
		public static implicit operator ulong( SteamAPICall_t value ) => value.Value;
		public override readonly string ToString() => Value.ToString();
		public override readonly int GetHashCode() => Value.GetHashCode();
		public override bool Equals( object p ) => this.Equals( (SteamAPICall_t) p );
		public readonly bool Equals( SteamAPICall_t p ) => p.Value == Value;
		public static bool operator ==( SteamAPICall_t a, SteamAPICall_t b ) => a.Equals( b );
		public static bool operator !=( SteamAPICall_t a, SteamAPICall_t b ) => !a.Equals( b );
		public readonly int CompareTo( SteamAPICall_t other ) => Value.CompareTo( other.Value );
	}
	
	internal struct AccountID_t : IEquatable<AccountID_t>, IComparable<AccountID_t>
	{
		// Name: AccountID_t, Type: unsigned int
		public uint Value;
		
		public static implicit operator AccountID_t( uint value ) => new AccountID_t(){ Value = value };
		public static implicit operator uint( AccountID_t value ) => value.Value;
		public override readonly string ToString() => Value.ToString();
		public override readonly int GetHashCode() => Value.GetHashCode();
		public override bool Equals( object p ) => this.Equals( (AccountID_t) p );
		public readonly bool Equals( AccountID_t p ) => p.Value == Value;
		public static bool operator ==( AccountID_t a, AccountID_t b ) => a.Equals( b );
		public static bool operator !=( AccountID_t a, AccountID_t b ) => !a.Equals( b );
		public readonly int CompareTo( AccountID_t other ) => Value.CompareTo( other.Value );
	}
	
	internal struct PartyBeaconID_t : IEquatable<PartyBeaconID_t>, IComparable<PartyBeaconID_t>
	{
		// Name: PartyBeaconID_t, Type: unsigned long long
		public ulong Value;
		
		public static implicit operator PartyBeaconID_t( ulong value ) => new PartyBeaconID_t(){ Value = value };
		public static implicit operator ulong( PartyBeaconID_t value ) => value.Value;
		public override readonly string ToString() => Value.ToString();
		public override readonly int GetHashCode() => Value.GetHashCode();
		public override bool Equals( object p ) => this.Equals( (PartyBeaconID_t) p );
		public readonly bool Equals( PartyBeaconID_t p ) => p.Value == Value;
		public static bool operator ==( PartyBeaconID_t a, PartyBeaconID_t b ) => a.Equals( b );
		public static bool operator !=( PartyBeaconID_t a, PartyBeaconID_t b ) => !a.Equals( b );
		public readonly int CompareTo( PartyBeaconID_t other ) => Value.CompareTo( other.Value );
	}
	
	internal struct HAuthTicket : IEquatable<HAuthTicket>, IComparable<HAuthTicket>
	{
		// Name: HAuthTicket, Type: unsigned int
		public uint Value;
		
		public static implicit operator HAuthTicket( uint value ) => new HAuthTicket(){ Value = value };
		public static implicit operator uint( HAuthTicket value ) => value.Value;
		public override readonly string ToString() => Value.ToString();
		public override readonly int GetHashCode() => Value.GetHashCode();
		public override bool Equals( object p ) => this.Equals( (HAuthTicket) p );
		public readonly bool Equals( HAuthTicket p ) => p.Value == Value;
		public static bool operator ==( HAuthTicket a, HAuthTicket b ) => a.Equals( b );
		public static bool operator !=( HAuthTicket a, HAuthTicket b ) => !a.Equals( b );
		public readonly int CompareTo( HAuthTicket other ) => Value.CompareTo( other.Value );
	}
	
	internal struct HSteamPipe : IEquatable<HSteamPipe>, IComparable<HSteamPipe>
	{
		// Name: HSteamPipe, Type: int
		public int Value;
		
		public static implicit operator HSteamPipe( int value ) => new HSteamPipe(){ Value = value };
		public static implicit operator int( HSteamPipe value ) => value.Value;
		public override readonly string ToString() => Value.ToString();
		public override readonly int GetHashCode() => Value.GetHashCode();
		public override bool Equals( object p ) => this.Equals( (HSteamPipe) p );
		public readonly bool Equals( HSteamPipe p ) => p.Value == Value;
		public static bool operator ==( HSteamPipe a, HSteamPipe b ) => a.Equals( b );
		public static bool operator !=( HSteamPipe a, HSteamPipe b ) => !a.Equals( b );
		public readonly int CompareTo( HSteamPipe other ) => Value.CompareTo( other.Value );
	}
	
	internal struct HSteamUser : IEquatable<HSteamUser>, IComparable<HSteamUser>
	{
		// Name: HSteamUser, Type: int
		public int Value;
		
		public static implicit operator HSteamUser( int value ) => new HSteamUser(){ Value = value };
		public static implicit operator int( HSteamUser value ) => value.Value;
		public override readonly string ToString() => Value.ToString();
		public override readonly int GetHashCode() => Value.GetHashCode();
		public override bool Equals( object p ) => this.Equals( (HSteamUser) p );
		public readonly bool Equals( HSteamUser p ) => p.Value == Value;
		public static bool operator ==( HSteamUser a, HSteamUser b ) => a.Equals( b );
		public static bool operator !=( HSteamUser a, HSteamUser b ) => !a.Equals( b );
		public readonly int CompareTo( HSteamUser other ) => Value.CompareTo( other.Value );
	}
	
	internal struct FriendsGroupID_t : IEquatable<FriendsGroupID_t>, IComparable<FriendsGroupID_t>
	{
		// Name: FriendsGroupID_t, Type: short
		public short Value;
		
		public static implicit operator FriendsGroupID_t( short value ) => new FriendsGroupID_t(){ Value = value };
		public static implicit operator short( FriendsGroupID_t value ) => value.Value;
		public override readonly string ToString() => Value.ToString();
		public override readonly int GetHashCode() => Value.GetHashCode();
		public override bool Equals( object p ) => this.Equals( (FriendsGroupID_t) p );
		public readonly bool Equals( FriendsGroupID_t p ) => p.Value == Value;
		public static bool operator ==( FriendsGroupID_t a, FriendsGroupID_t b ) => a.Equals( b );
		public static bool operator !=( FriendsGroupID_t a, FriendsGroupID_t b ) => !a.Equals( b );
		public readonly int CompareTo( FriendsGroupID_t other ) => Value.CompareTo( other.Value );
	}
	
	internal struct HServerListRequest : IEquatable<HServerListRequest>, IComparable<HServerListRequest>
	{
		// Name: HServerListRequest, Type: void *
		public IntPtr Value;
		
		public static implicit operator HServerListRequest( IntPtr value ) => new HServerListRequest(){ Value = value };
		public static implicit operator IntPtr( HServerListRequest value ) => value.Value;
		public override readonly string ToString() => Value.ToString();
		public override readonly int GetHashCode() => Value.GetHashCode();
		public override bool Equals( object p ) => this.Equals( (HServerListRequest) p );
		public readonly bool Equals( HServerListRequest p ) => p.Value == Value;
		public static bool operator ==( HServerListRequest a, HServerListRequest b ) => a.Equals( b );
		public static bool operator !=( HServerListRequest a, HServerListRequest b ) => !a.Equals( b );
		public readonly int CompareTo( HServerListRequest other ) => Value.ToInt64().CompareTo( other.Value.ToInt64() );
	}
	
	internal struct HServerQuery : IEquatable<HServerQuery>, IComparable<HServerQuery>
	{
		// Name: HServerQuery, Type: int
		public int Value;
		
		public static implicit operator HServerQuery( int value ) => new HServerQuery(){ Value = value };
		public static implicit operator int( HServerQuery value ) => value.Value;
		public override readonly string ToString() => Value.ToString();
		public override readonly int GetHashCode() => Value.GetHashCode();
		public override bool Equals( object p ) => this.Equals( (HServerQuery) p );
		public readonly bool Equals( HServerQuery p ) => p.Value == Value;
		public static bool operator ==( HServerQuery a, HServerQuery b ) => a.Equals( b );
		public static bool operator !=( HServerQuery a, HServerQuery b ) => !a.Equals( b );
		public readonly int CompareTo( HServerQuery other ) => Value.CompareTo( other.Value );
	}
	
	internal struct UGCHandle_t : IEquatable<UGCHandle_t>, IComparable<UGCHandle_t>
	{
		// Name: UGCHandle_t, Type: unsigned long long
		public ulong Value;
		
		public static implicit operator UGCHandle_t( ulong value ) => new UGCHandle_t(){ Value = value };
		public static implicit operator ulong( UGCHandle_t value ) => value.Value;
		public override readonly string ToString() => Value.ToString();
		public override readonly int GetHashCode() => Value.GetHashCode();
		public override bool Equals( object p ) => this.Equals( (UGCHandle_t) p );
		public readonly bool Equals( UGCHandle_t p ) => p.Value == Value;
		public static bool operator ==( UGCHandle_t a, UGCHandle_t b ) => a.Equals( b );
		public static bool operator !=( UGCHandle_t a, UGCHandle_t b ) => !a.Equals( b );
		public readonly int CompareTo( UGCHandle_t other ) => Value.CompareTo( other.Value );
	}
	
	internal struct PublishedFileUpdateHandle_t : IEquatable<PublishedFileUpdateHandle_t>, IComparable<PublishedFileUpdateHandle_t>
	{
		// Name: PublishedFileUpdateHandle_t, Type: unsigned long long
		public ulong Value;
		
		public static implicit operator PublishedFileUpdateHandle_t( ulong value ) => new PublishedFileUpdateHandle_t(){ Value = value };
		public static implicit operator ulong( PublishedFileUpdateHandle_t value ) => value.Value;
		public override readonly string ToString() => Value.ToString();
		public override readonly int GetHashCode() => Value.GetHashCode();
		public override bool Equals( object p ) => this.Equals( (PublishedFileUpdateHandle_t) p );
		public readonly bool Equals( PublishedFileUpdateHandle_t p ) => p.Value == Value;
		public static bool operator ==( PublishedFileUpdateHandle_t a, PublishedFileUpdateHandle_t b ) => a.Equals( b );
		public static bool operator !=( PublishedFileUpdateHandle_t a, PublishedFileUpdateHandle_t b ) => !a.Equals( b );
		public readonly int CompareTo( PublishedFileUpdateHandle_t other ) => Value.CompareTo( other.Value );
	}
	
	public struct PublishedFileId : IEquatable<PublishedFileId>, IComparable<PublishedFileId>
	{
		// Name: PublishedFileId_t, Type: unsigned long long
		public ulong Value;
		
		public static implicit operator PublishedFileId( ulong value ) => new PublishedFileId(){ Value = value };
		public static implicit operator ulong( PublishedFileId value ) => value.Value;
		public override readonly string ToString() => Value.ToString();
		public override readonly int GetHashCode() => Value.GetHashCode();
		public override bool Equals( object p ) => this.Equals( (PublishedFileId) p );
		public readonly bool Equals( PublishedFileId p ) => p.Value == Value;
		public static bool operator ==( PublishedFileId a, PublishedFileId b ) => a.Equals( b );
		public static bool operator !=( PublishedFileId a, PublishedFileId b ) => !a.Equals( b );
		public readonly int CompareTo( PublishedFileId other ) => Value.CompareTo( other.Value );
	}
	
	internal struct UGCFileWriteStreamHandle_t : IEquatable<UGCFileWriteStreamHandle_t>, IComparable<UGCFileWriteStreamHandle_t>
	{
		// Name: UGCFileWriteStreamHandle_t, Type: unsigned long long
		public ulong Value;
		
		public static implicit operator UGCFileWriteStreamHandle_t( ulong value ) => new UGCFileWriteStreamHandle_t(){ Value = value };
		public static implicit operator ulong( UGCFileWriteStreamHandle_t value ) => value.Value;
		public override readonly string ToString() => Value.ToString();
		public override readonly int GetHashCode() => Value.GetHashCode();
		public override bool Equals( object p ) => this.Equals( (UGCFileWriteStreamHandle_t) p );
		public readonly bool Equals( UGCFileWriteStreamHandle_t p ) => p.Value == Value;
		public static bool operator ==( UGCFileWriteStreamHandle_t a, UGCFileWriteStreamHandle_t b ) => a.Equals( b );
		public static bool operator !=( UGCFileWriteStreamHandle_t a, UGCFileWriteStreamHandle_t b ) => !a.Equals( b );
		public readonly int CompareTo( UGCFileWriteStreamHandle_t other ) => Value.CompareTo( other.Value );
	}
	
	internal struct SteamLeaderboard_t : IEquatable<SteamLeaderboard_t>, IComparable<SteamLeaderboard_t>
	{
		// Name: SteamLeaderboard_t, Type: unsigned long long
		public ulong Value;
		
		public static implicit operator SteamLeaderboard_t( ulong value ) => new SteamLeaderboard_t(){ Value = value };
		public static implicit operator ulong( SteamLeaderboard_t value ) => value.Value;
		public override readonly string ToString() => Value.ToString();
		public override readonly int GetHashCode() => Value.GetHashCode();
		public override bool Equals( object p ) => this.Equals( (SteamLeaderboard_t) p );
		public readonly bool Equals( SteamLeaderboard_t p ) => p.Value == Value;
		public static bool operator ==( SteamLeaderboard_t a, SteamLeaderboard_t b ) => a.Equals( b );
		public static bool operator !=( SteamLeaderboard_t a, SteamLeaderboard_t b ) => !a.Equals( b );
		public readonly int CompareTo( SteamLeaderboard_t other ) => Value.CompareTo( other.Value );
	}
	
	internal struct SteamLeaderboardEntries_t : IEquatable<SteamLeaderboardEntries_t>, IComparable<SteamLeaderboardEntries_t>
	{
		// Name: SteamLeaderboardEntries_t, Type: unsigned long long
		public ulong Value;
		
		public static implicit operator SteamLeaderboardEntries_t( ulong value ) => new SteamLeaderboardEntries_t(){ Value = value };
		public static implicit operator ulong( SteamLeaderboardEntries_t value ) => value.Value;
		public override readonly string ToString() => Value.ToString();
		public override readonly int GetHashCode() => Value.GetHashCode();
		public override bool Equals( object p ) => this.Equals( (SteamLeaderboardEntries_t) p );
		public readonly bool Equals( SteamLeaderboardEntries_t p ) => p.Value == Value;
		public static bool operator ==( SteamLeaderboardEntries_t a, SteamLeaderboardEntries_t b ) => a.Equals( b );
		public static bool operator !=( SteamLeaderboardEntries_t a, SteamLeaderboardEntries_t b ) => !a.Equals( b );
		public readonly int CompareTo( SteamLeaderboardEntries_t other ) => Value.CompareTo( other.Value );
	}
	
	internal struct SNetSocket_t : IEquatable<SNetSocket_t>, IComparable<SNetSocket_t>
	{
		// Name: SNetSocket_t, Type: unsigned int
		public uint Value;
		
		public static implicit operator SNetSocket_t( uint value ) => new SNetSocket_t(){ Value = value };
		public static implicit operator uint( SNetSocket_t value ) => value.Value;
		public override readonly string ToString() => Value.ToString();
		public override readonly int GetHashCode() => Value.GetHashCode();
		public override bool Equals( object p ) => this.Equals( (SNetSocket_t) p );
		public readonly bool Equals( SNetSocket_t p ) => p.Value == Value;
		public static bool operator ==( SNetSocket_t a, SNetSocket_t b ) => a.Equals( b );
		public static bool operator !=( SNetSocket_t a, SNetSocket_t b ) => !a.Equals( b );
		public readonly int CompareTo( SNetSocket_t other ) => Value.CompareTo( other.Value );
	}
	
	internal struct SNetListenSocket_t : IEquatable<SNetListenSocket_t>, IComparable<SNetListenSocket_t>
	{
		// Name: SNetListenSocket_t, Type: unsigned int
		public uint Value;
		
		public static implicit operator SNetListenSocket_t( uint value ) => new SNetListenSocket_t(){ Value = value };
		public static implicit operator uint( SNetListenSocket_t value ) => value.Value;
		public override readonly string ToString() => Value.ToString();
		public override readonly int GetHashCode() => Value.GetHashCode();
		public override bool Equals( object p ) => this.Equals( (SNetListenSocket_t) p );
		public readonly bool Equals( SNetListenSocket_t p ) => p.Value == Value;
		public static bool operator ==( SNetListenSocket_t a, SNetListenSocket_t b ) => a.Equals( b );
		public static bool operator !=( SNetListenSocket_t a, SNetListenSocket_t b ) => !a.Equals( b );
		public readonly int CompareTo( SNetListenSocket_t other ) => Value.CompareTo( other.Value );
	}
	
	internal struct ScreenshotHandle : IEquatable<ScreenshotHandle>, IComparable<ScreenshotHandle>
	{
		// Name: ScreenshotHandle, Type: unsigned int
		public uint Value;
		
		public static implicit operator ScreenshotHandle( uint value ) => new ScreenshotHandle(){ Value = value };
		public static implicit operator uint( ScreenshotHandle value ) => value.Value;
		public override readonly string ToString() => Value.ToString();
		public override readonly int GetHashCode() => Value.GetHashCode();
		public override bool Equals( object p ) => this.Equals( (ScreenshotHandle) p );
		public readonly bool Equals( ScreenshotHandle p ) => p.Value == Value;
		public static bool operator ==( ScreenshotHandle a, ScreenshotHandle b ) => a.Equals( b );
		public static bool operator !=( ScreenshotHandle a, ScreenshotHandle b ) => !a.Equals( b );
		public readonly int CompareTo( ScreenshotHandle other ) => Value.CompareTo( other.Value );
	}
	
	internal struct HTTPRequestHandle : IEquatable<HTTPRequestHandle>, IComparable<HTTPRequestHandle>
	{
		// Name: HTTPRequestHandle, Type: unsigned int
		public uint Value;
		
		public static implicit operator HTTPRequestHandle( uint value ) => new HTTPRequestHandle(){ Value = value };
		public static implicit operator uint( HTTPRequestHandle value ) => value.Value;
		public override readonly string ToString() => Value.ToString();
		public override readonly int GetHashCode() => Value.GetHashCode();
		public override bool Equals( object p ) => this.Equals( (HTTPRequestHandle) p );
		public readonly bool Equals( HTTPRequestHandle p ) => p.Value == Value;
		public static bool operator ==( HTTPRequestHandle a, HTTPRequestHandle b ) => a.Equals( b );
		public static bool operator !=( HTTPRequestHandle a, HTTPRequestHandle b ) => !a.Equals( b );
		public readonly int CompareTo( HTTPRequestHandle other ) => Value.CompareTo( other.Value );
	}
	
	internal struct HTTPCookieContainerHandle : IEquatable<HTTPCookieContainerHandle>, IComparable<HTTPCookieContainerHandle>
	{
		// Name: HTTPCookieContainerHandle, Type: unsigned int
		public uint Value;
		
		public static implicit operator HTTPCookieContainerHandle( uint value ) => new HTTPCookieContainerHandle(){ Value = value };
		public static implicit operator uint( HTTPCookieContainerHandle value ) => value.Value;
		public override readonly string ToString() => Value.ToString();
		public override readonly int GetHashCode() => Value.GetHashCode();
		public override bool Equals( object p ) => this.Equals( (HTTPCookieContainerHandle) p );
		public readonly bool Equals( HTTPCookieContainerHandle p ) => p.Value == Value;
		public static bool operator ==( HTTPCookieContainerHandle a, HTTPCookieContainerHandle b ) => a.Equals( b );
		public static bool operator !=( HTTPCookieContainerHandle a, HTTPCookieContainerHandle b ) => !a.Equals( b );
		public readonly int CompareTo( HTTPCookieContainerHandle other ) => Value.CompareTo( other.Value );
	}
	
	internal struct InputHandle_t : IEquatable<InputHandle_t>, IComparable<InputHandle_t>
	{
		// Name: InputHandle_t, Type: unsigned long long
		public ulong Value;
		
		public static implicit operator InputHandle_t( ulong value ) => new InputHandle_t(){ Value = value };
		public static implicit operator ulong( InputHandle_t value ) => value.Value;
		public override readonly string ToString() => Value.ToString();
		public override readonly int GetHashCode() => Value.GetHashCode();
		public override bool Equals( object p ) => this.Equals( (InputHandle_t) p );
		public readonly bool Equals( InputHandle_t p ) => p.Value == Value;
		public static bool operator ==( InputHandle_t a, InputHandle_t b ) => a.Equals( b );
		public static bool operator !=( InputHandle_t a, InputHandle_t b ) => !a.Equals( b );
		public readonly int CompareTo( InputHandle_t other ) => Value.CompareTo( other.Value );
	}
	
	internal struct InputActionSetHandle_t : IEquatable<InputActionSetHandle_t>, IComparable<InputActionSetHandle_t>
	{
		// Name: InputActionSetHandle_t, Type: unsigned long long
		public ulong Value;
		
		public static implicit operator InputActionSetHandle_t( ulong value ) => new InputActionSetHandle_t(){ Value = value };
		public static implicit operator ulong( InputActionSetHandle_t value ) => value.Value;
		public override readonly string ToString() => Value.ToString();
		public override readonly int GetHashCode() => Value.GetHashCode();
		public override bool Equals( object p ) => this.Equals( (InputActionSetHandle_t) p );
		public readonly bool Equals( InputActionSetHandle_t p ) => p.Value == Value;
		public static bool operator ==( InputActionSetHandle_t a, InputActionSetHandle_t b ) => a.Equals( b );
		public static bool operator !=( InputActionSetHandle_t a, InputActionSetHandle_t b ) => !a.Equals( b );
		public readonly int CompareTo( InputActionSetHandle_t other ) => Value.CompareTo( other.Value );
	}
	
	internal struct InputDigitalActionHandle_t : IEquatable<InputDigitalActionHandle_t>, IComparable<InputDigitalActionHandle_t>
	{
		// Name: InputDigitalActionHandle_t, Type: unsigned long long
		public ulong Value;
		
		public static implicit operator InputDigitalActionHandle_t( ulong value ) => new InputDigitalActionHandle_t(){ Value = value };
		public static implicit operator ulong( InputDigitalActionHandle_t value ) => value.Value;
		public override readonly string ToString() => Value.ToString();
		public override readonly int GetHashCode() => Value.GetHashCode();
		public override bool Equals( object p ) => this.Equals( (InputDigitalActionHandle_t) p );
		public readonly bool Equals( InputDigitalActionHandle_t p ) => p.Value == Value;
		public static bool operator ==( InputDigitalActionHandle_t a, InputDigitalActionHandle_t b ) => a.Equals( b );
		public static bool operator !=( InputDigitalActionHandle_t a, InputDigitalActionHandle_t b ) => !a.Equals( b );
		public readonly int CompareTo( InputDigitalActionHandle_t other ) => Value.CompareTo( other.Value );
	}
	
	internal struct InputAnalogActionHandle_t : IEquatable<InputAnalogActionHandle_t>, IComparable<InputAnalogActionHandle_t>
	{
		// Name: InputAnalogActionHandle_t, Type: unsigned long long
		public ulong Value;
		
		public static implicit operator InputAnalogActionHandle_t( ulong value ) => new InputAnalogActionHandle_t(){ Value = value };
		public static implicit operator ulong( InputAnalogActionHandle_t value ) => value.Value;
		public override readonly string ToString() => Value.ToString();
		public override readonly int GetHashCode() => Value.GetHashCode();
		public override bool Equals( object p ) => this.Equals( (InputAnalogActionHandle_t) p );
		public readonly bool Equals( InputAnalogActionHandle_t p ) => p.Value == Value;
		public static bool operator ==( InputAnalogActionHandle_t a, InputAnalogActionHandle_t b ) => a.Equals( b );
		public static bool operator !=( InputAnalogActionHandle_t a, InputAnalogActionHandle_t b ) => !a.Equals( b );
		public readonly int CompareTo( InputAnalogActionHandle_t other ) => Value.CompareTo( other.Value );
	}
	
	internal struct ControllerHandle_t : IEquatable<ControllerHandle_t>, IComparable<ControllerHandle_t>
	{
		// Name: ControllerHandle_t, Type: unsigned long long
		public ulong Value;
		
		public static implicit operator ControllerHandle_t( ulong value ) => new ControllerHandle_t(){ Value = value };
		public static implicit operator ulong( ControllerHandle_t value ) => value.Value;
		public override readonly string ToString() => Value.ToString();
		public override readonly int GetHashCode() => Value.GetHashCode();
		public override bool Equals( object p ) => this.Equals( (ControllerHandle_t) p );
		public readonly bool Equals( ControllerHandle_t p ) => p.Value == Value;
		public static bool operator ==( ControllerHandle_t a, ControllerHandle_t b ) => a.Equals( b );
		public static bool operator !=( ControllerHandle_t a, ControllerHandle_t b ) => !a.Equals( b );
		public readonly int CompareTo( ControllerHandle_t other ) => Value.CompareTo( other.Value );
	}
	
	internal struct ControllerActionSetHandle_t : IEquatable<ControllerActionSetHandle_t>, IComparable<ControllerActionSetHandle_t>
	{
		// Name: ControllerActionSetHandle_t, Type: unsigned long long
		public ulong Value;
		
		public static implicit operator ControllerActionSetHandle_t( ulong value ) => new ControllerActionSetHandle_t(){ Value = value };
		public static implicit operator ulong( ControllerActionSetHandle_t value ) => value.Value;
		public override readonly string ToString() => Value.ToString();
		public override readonly int GetHashCode() => Value.GetHashCode();
		public override bool Equals( object p ) => this.Equals( (ControllerActionSetHandle_t) p );
		public readonly bool Equals( ControllerActionSetHandle_t p ) => p.Value == Value;
		public static bool operator ==( ControllerActionSetHandle_t a, ControllerActionSetHandle_t b ) => a.Equals( b );
		public static bool operator !=( ControllerActionSetHandle_t a, ControllerActionSetHandle_t b ) => !a.Equals( b );
		public readonly int CompareTo( ControllerActionSetHandle_t other ) => Value.CompareTo( other.Value );
	}
	
	internal struct ControllerDigitalActionHandle_t : IEquatable<ControllerDigitalActionHandle_t>, IComparable<ControllerDigitalActionHandle_t>
	{
		// Name: ControllerDigitalActionHandle_t, Type: unsigned long long
		public ulong Value;
		
		public static implicit operator ControllerDigitalActionHandle_t( ulong value ) => new ControllerDigitalActionHandle_t(){ Value = value };
		public static implicit operator ulong( ControllerDigitalActionHandle_t value ) => value.Value;
		public override readonly string ToString() => Value.ToString();
		public override readonly int GetHashCode() => Value.GetHashCode();
		public override bool Equals( object p ) => this.Equals( (ControllerDigitalActionHandle_t) p );
		public readonly bool Equals( ControllerDigitalActionHandle_t p ) => p.Value == Value;
		public static bool operator ==( ControllerDigitalActionHandle_t a, ControllerDigitalActionHandle_t b ) => a.Equals( b );
		public static bool operator !=( ControllerDigitalActionHandle_t a, ControllerDigitalActionHandle_t b ) => !a.Equals( b );
		public readonly int CompareTo( ControllerDigitalActionHandle_t other ) => Value.CompareTo( other.Value );
	}
	
	internal struct ControllerAnalogActionHandle_t : IEquatable<ControllerAnalogActionHandle_t>, IComparable<ControllerAnalogActionHandle_t>
	{
		// Name: ControllerAnalogActionHandle_t, Type: unsigned long long
		public ulong Value;
		
		public static implicit operator ControllerAnalogActionHandle_t( ulong value ) => new ControllerAnalogActionHandle_t(){ Value = value };
		public static implicit operator ulong( ControllerAnalogActionHandle_t value ) => value.Value;
		public override readonly string ToString() => Value.ToString();
		public override readonly int GetHashCode() => Value.GetHashCode();
		public override bool Equals( object p ) => this.Equals( (ControllerAnalogActionHandle_t) p );
		public readonly bool Equals( ControllerAnalogActionHandle_t p ) => p.Value == Value;
		public static bool operator ==( ControllerAnalogActionHandle_t a, ControllerAnalogActionHandle_t b ) => a.Equals( b );
		public static bool operator !=( ControllerAnalogActionHandle_t a, ControllerAnalogActionHandle_t b ) => !a.Equals( b );
		public readonly int CompareTo( ControllerAnalogActionHandle_t other ) => Value.CompareTo( other.Value );
	}
	
	internal struct UGCQueryHandle_t : IEquatable<UGCQueryHandle_t>, IComparable<UGCQueryHandle_t>
	{
		// Name: UGCQueryHandle_t, Type: unsigned long long
		public ulong Value;
		
		public static implicit operator UGCQueryHandle_t( ulong value ) => new UGCQueryHandle_t(){ Value = value };
		public static implicit operator ulong( UGCQueryHandle_t value ) => value.Value;
		public override readonly string ToString() => Value.ToString();
		public override readonly int GetHashCode() => Value.GetHashCode();
		public override bool Equals( object p ) => this.Equals( (UGCQueryHandle_t) p );
		public readonly bool Equals( UGCQueryHandle_t p ) => p.Value == Value;
		public static bool operator ==( UGCQueryHandle_t a, UGCQueryHandle_t b ) => a.Equals( b );
		public static bool operator !=( UGCQueryHandle_t a, UGCQueryHandle_t b ) => !a.Equals( b );
		public readonly int CompareTo( UGCQueryHandle_t other ) => Value.CompareTo( other.Value );
	}
	
	internal struct UGCUpdateHandle_t : IEquatable<UGCUpdateHandle_t>, IComparable<UGCUpdateHandle_t>
	{
		// Name: UGCUpdateHandle_t, Type: unsigned long long
		public ulong Value;
		
		public static implicit operator UGCUpdateHandle_t( ulong value ) => new UGCUpdateHandle_t(){ Value = value };
		public static implicit operator ulong( UGCUpdateHandle_t value ) => value.Value;
		public override readonly string ToString() => Value.ToString();
		public override readonly int GetHashCode() => Value.GetHashCode();
		public override bool Equals( object p ) => this.Equals( (UGCUpdateHandle_t) p );
		public readonly bool Equals( UGCUpdateHandle_t p ) => p.Value == Value;
		public static bool operator ==( UGCUpdateHandle_t a, UGCUpdateHandle_t b ) => a.Equals( b );
		public static bool operator !=( UGCUpdateHandle_t a, UGCUpdateHandle_t b ) => !a.Equals( b );
		public readonly int CompareTo( UGCUpdateHandle_t other ) => Value.CompareTo( other.Value );
	}
	
	internal struct HHTMLBrowser : IEquatable<HHTMLBrowser>, IComparable<HHTMLBrowser>
	{
		// Name: HHTMLBrowser, Type: unsigned int
		public uint Value;
		
		public static implicit operator HHTMLBrowser( uint value ) => new HHTMLBrowser(){ Value = value };
		public static implicit operator uint( HHTMLBrowser value ) => value.Value;
		public override readonly string ToString() => Value.ToString();
		public override readonly int GetHashCode() => Value.GetHashCode();
		public override bool Equals( object p ) => this.Equals( (HHTMLBrowser) p );
		public readonly bool Equals( HHTMLBrowser p ) => p.Value == Value;
		public static bool operator ==( HHTMLBrowser a, HHTMLBrowser b ) => a.Equals( b );
		public static bool operator !=( HHTMLBrowser a, HHTMLBrowser b ) => !a.Equals( b );
		public readonly int CompareTo( HHTMLBrowser other ) => Value.CompareTo( other.Value );
	}
	
	public struct InventoryItemId : IEquatable<InventoryItemId>, IComparable<InventoryItemId>
	{
		// Name: SteamItemInstanceID_t, Type: unsigned long long
		public ulong Value;
		
		public static implicit operator InventoryItemId( ulong value ) => new InventoryItemId(){ Value = value };
		public static implicit operator ulong( InventoryItemId value ) => value.Value;
		public override readonly string ToString() => Value.ToString();
		public override readonly int GetHashCode() => Value.GetHashCode();
		public override bool Equals( object p ) => this.Equals( (InventoryItemId) p );
		public readonly bool Equals( InventoryItemId p ) => p.Value == Value;
		public static bool operator ==( InventoryItemId a, InventoryItemId b ) => a.Equals( b );
		public static bool operator !=( InventoryItemId a, InventoryItemId b ) => !a.Equals( b );
		public readonly int CompareTo( InventoryItemId other ) => Value.CompareTo( other.Value );
	}
	
	public struct InventoryDefId : IEquatable<InventoryDefId>, IComparable<InventoryDefId>
	{
		// Name: SteamItemDef_t, Type: int
		public int Value;
		
		public static implicit operator InventoryDefId( int value ) => new InventoryDefId(){ Value = value };
		public static implicit operator int( InventoryDefId value ) => value.Value;
		public override readonly string ToString() => Value.ToString();
		public override readonly int GetHashCode() => Value.GetHashCode();
		public override bool Equals( object p ) => this.Equals( (InventoryDefId) p );
		public readonly bool Equals( InventoryDefId p ) => p.Value == Value;
		public static bool operator ==( InventoryDefId a, InventoryDefId b ) => a.Equals( b );
		public static bool operator !=( InventoryDefId a, InventoryDefId b ) => !a.Equals( b );
		public readonly int CompareTo( InventoryDefId other ) => Value.CompareTo( other.Value );
	}
	
	internal struct SteamInventoryResult_t : IEquatable<SteamInventoryResult_t>, IComparable<SteamInventoryResult_t>
	{
		// Name: SteamInventoryResult_t, Type: int
		public int Value;
		
		public static implicit operator SteamInventoryResult_t( int value ) => new SteamInventoryResult_t(){ Value = value };
		public static implicit operator int( SteamInventoryResult_t value ) => value.Value;
		public override readonly string ToString() => Value.ToString();
		public override readonly int GetHashCode() => Value.GetHashCode();
		public override bool Equals( object p ) => this.Equals( (SteamInventoryResult_t) p );
		public readonly bool Equals( SteamInventoryResult_t p ) => p.Value == Value;
		public static bool operator ==( SteamInventoryResult_t a, SteamInventoryResult_t b ) => a.Equals( b );
		public static bool operator !=( SteamInventoryResult_t a, SteamInventoryResult_t b ) => !a.Equals( b );
		public readonly int CompareTo( SteamInventoryResult_t other ) => Value.CompareTo( other.Value );
	}
	
	internal struct SteamInventoryUpdateHandle_t : IEquatable<SteamInventoryUpdateHandle_t>, IComparable<SteamInventoryUpdateHandle_t>
	{
		// Name: SteamInventoryUpdateHandle_t, Type: unsigned long long
		public ulong Value;
		
		public static implicit operator SteamInventoryUpdateHandle_t( ulong value ) => new SteamInventoryUpdateHandle_t(){ Value = value };
		public static implicit operator ulong( SteamInventoryUpdateHandle_t value ) => value.Value;
		public override readonly string ToString() => Value.ToString();
		public override readonly int GetHashCode() => Value.GetHashCode();
		public override bool Equals( object p ) => this.Equals( (SteamInventoryUpdateHandle_t) p );
		public readonly bool Equals( SteamInventoryUpdateHandle_t p ) => p.Value == Value;
		public static bool operator ==( SteamInventoryUpdateHandle_t a, SteamInventoryUpdateHandle_t b ) => a.Equals( b );
		public static bool operator !=( SteamInventoryUpdateHandle_t a, SteamInventoryUpdateHandle_t b ) => !a.Equals( b );
		public readonly int CompareTo( SteamInventoryUpdateHandle_t other ) => Value.CompareTo( other.Value );
	}
	
	public struct TimelineEventHandle : IEquatable<TimelineEventHandle>, IComparable<TimelineEventHandle>
	{
		// Name: TimelineEventHandle_t, Type: unsigned long long
		public ulong Value;
		
		public static implicit operator TimelineEventHandle( ulong value ) => new TimelineEventHandle(){ Value = value };
		public static implicit operator ulong( TimelineEventHandle value ) => value.Value;
		public override readonly string ToString() => Value.ToString();
		public override readonly int GetHashCode() => Value.GetHashCode();
		public override bool Equals( object p ) => this.Equals( (TimelineEventHandle) p );
		public readonly bool Equals( TimelineEventHandle p ) => p.Value == Value;
		public static bool operator ==( TimelineEventHandle a, TimelineEventHandle b ) => a.Equals( b );
		public static bool operator !=( TimelineEventHandle a, TimelineEventHandle b ) => !a.Equals( b );
		public readonly int CompareTo( TimelineEventHandle other ) => Value.CompareTo( other.Value );
	}
	
	internal struct RemotePlaySessionID_t : IEquatable<RemotePlaySessionID_t>, IComparable<RemotePlaySessionID_t>
	{
		// Name: RemotePlaySessionID_t, Type: unsigned int
		public uint Value;
		
		public static implicit operator RemotePlaySessionID_t( uint value ) => new RemotePlaySessionID_t(){ Value = value };
		public static implicit operator uint( RemotePlaySessionID_t value ) => value.Value;
		public override readonly string ToString() => Value.ToString();
		public override readonly int GetHashCode() => Value.GetHashCode();
		public override bool Equals( object p ) => this.Equals( (RemotePlaySessionID_t) p );
		public readonly bool Equals( RemotePlaySessionID_t p ) => p.Value == Value;
		public static bool operator ==( RemotePlaySessionID_t a, RemotePlaySessionID_t b ) => a.Equals( b );
		public static bool operator !=( RemotePlaySessionID_t a, RemotePlaySessionID_t b ) => !a.Equals( b );
		public readonly int CompareTo( RemotePlaySessionID_t other ) => Value.CompareTo( other.Value );
	}
	
	internal struct HSteamNetPollGroup : IEquatable<HSteamNetPollGroup>, IComparable<HSteamNetPollGroup>
	{
		// Name: HSteamNetPollGroup, Type: unsigned int
		public uint Value;
		
		public static implicit operator HSteamNetPollGroup( uint value ) => new HSteamNetPollGroup(){ Value = value };
		public static implicit operator uint( HSteamNetPollGroup value ) => value.Value;
		public override readonly string ToString() => Value.ToString();
		public override readonly int GetHashCode() => Value.GetHashCode();
		public override bool Equals( object p ) => this.Equals( (HSteamNetPollGroup) p );
		public readonly bool Equals( HSteamNetPollGroup p ) => p.Value == Value;
		public static bool operator ==( HSteamNetPollGroup a, HSteamNetPollGroup b ) => a.Equals( b );
		public static bool operator !=( HSteamNetPollGroup a, HSteamNetPollGroup b ) => !a.Equals( b );
		public readonly int CompareTo( HSteamNetPollGroup other ) => Value.CompareTo( other.Value );
	}
	
	internal struct SteamNetworkingPOPID : IEquatable<SteamNetworkingPOPID>, IComparable<SteamNetworkingPOPID>
	{
		// Name: SteamNetworkingPOPID, Type: unsigned int
		public uint Value;
		
		public static implicit operator SteamNetworkingPOPID( uint value ) => new SteamNetworkingPOPID(){ Value = value };
		public static implicit operator uint( SteamNetworkingPOPID value ) => value.Value;
		public override readonly string ToString() => Value.ToString();
		public override readonly int GetHashCode() => Value.GetHashCode();
		public override bool Equals( object p ) => this.Equals( (SteamNetworkingPOPID) p );
		public readonly bool Equals( SteamNetworkingPOPID p ) => p.Value == Value;
		public static bool operator ==( SteamNetworkingPOPID a, SteamNetworkingPOPID b ) => a.Equals( b );
		public static bool operator !=( SteamNetworkingPOPID a, SteamNetworkingPOPID b ) => !a.Equals( b );
		public readonly int CompareTo( SteamNetworkingPOPID other ) => Value.CompareTo( other.Value );
	}
	
}
