﻿using System;
using LaDanse.Target.Entities.Shared;

namespace LaDanse.Target.Entities.GameData.Core
{
    public partial class GameRace : IBaseEntity<Guid>
    {
        public Guid Id { get; set; }
        
        public int GameId { get; set; }
        public string Name { get; set; }

        public Guid GameFactionId { get; set; }
        public virtual GameFaction GameFaction { get; set; }
    }
}
