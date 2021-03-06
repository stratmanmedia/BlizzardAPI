﻿using BlizzardAPI.Client.WorldOfWarcraft.Realms.Models;
using BlizzardAPI.Client.WorldOfWarcraft.Shared.Models;

namespace BlizzardAPI.Client.WorldOfWarcraft.Guilds.Models
{
    public class Guild
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Realm Realm { get; set; }
        public Faction Faction { get; set; }
    }
}