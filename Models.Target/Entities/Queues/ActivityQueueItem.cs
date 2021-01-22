﻿using System;
using LaDanse.Target.Entities.Identity;
using LaDanse.Target.Entities.Shared;

namespace LaDanse.Target.Entities.Queues
{
    public partial class ActivityQueueItem : IBaseEntity<Guid>
    {
        public Guid Id { get; set; }

        public string ActivityType { get; set; }
        public DateTime ActivityOn { get; set; }
        public string RawData { get; set; }
        public DateTime? ProcessedOn { get; set; }

        public Guid? ActivityById { get; set; }
        public virtual User ActivityBy { get; set; }
    }
}
