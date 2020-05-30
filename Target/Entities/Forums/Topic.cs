﻿using System;
using LaDanse.Target.Entities.Identity;
using LaDanse.Target.Entities.Shared;

namespace LaDanse.Target.Entities.Forums
{
    public partial class Topic : IBaseEntity<Guid>
    {
        public Guid Id { get; set; }

        public DateTime PostDate { get; set; }
        public string Subject { get; set; }
        public DateTime? LastPostDate { get; set; }

        public Guid ForumId { get; set; }
        public virtual Forum Forum { get; set; }

        public Guid? LastPostPosterId { get; set; }
        public virtual User LastPostPoster { get; set; }

        public Guid PosterId { get; set; }
        public virtual User Poster { get; set; }
    }
}
