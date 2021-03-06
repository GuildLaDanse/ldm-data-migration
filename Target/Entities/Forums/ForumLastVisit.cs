﻿using System;
using LaDanse.Target.Entities.Identity;
using LaDanse.Target.Entities.Shared;

namespace LaDanse.Target.Entities.Forums
{
    public partial class ForumLastVisit : IBaseEntity<Guid>
    {
        public Guid Id { get; set; }

        public DateTime LastVisitDate { get; set; }

        public Guid UserId { get; set; }
        public virtual User User { get; set; }
    }
}
