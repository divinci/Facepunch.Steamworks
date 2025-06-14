﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Steamworks
{
    public struct Clan
    {
        public SteamId Id;

        public Clan(SteamId id)
        {
            Id = id;
        }

        public readonly string Name => SteamFriends.Internal.GetClanName(Id);

        public readonly string Tag => SteamFriends.Internal.GetClanTag(Id);

        public readonly int ChatMemberCount => SteamFriends.Internal.GetClanChatMemberCount(Id);

        public readonly Friend Owner => new Friend(SteamFriends.Internal.GetClanOwner(Id));

        public readonly bool Public => SteamFriends.Internal.IsClanPublic(Id);

        /// <summary>
        /// Is the clan an official game group?
        /// </summary>
        public readonly bool Official => SteamFriends.Internal.IsClanOfficialGameGroup(Id);

        /// <summary>
        /// Asynchronously fetches the officer list for a given clan
        /// </summary>
        /// <returns>Whether the request was successful or not</returns>
        public async readonly Task<bool> RequestOfficerList()
        {
            var req = await SteamFriends.Internal.RequestClanOfficerList(Id);
            return req.HasValue && req.Value.Success != 0x0;
        }

        public readonly IEnumerable<Friend> GetOfficers()
        {
            for (int i = 0; i < SteamFriends.Internal.GetClanOfficerCount(Id); i++)
            {
                yield return new Friend(SteamFriends.Internal.GetClanOfficerByIndex(Id, i));
            }
        }
    }
}
