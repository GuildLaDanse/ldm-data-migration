﻿using System;
using LaDanse.Source.Entities.Identity;

namespace LaDanse.Source.Entities.Forums
{
    public partial class Forum
    {
        public string Id { get; set; }

        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime? LastPostDate { get; set; }
        
        public int? LastPostPosterId { get; set; }
        public virtual Account LastPostPoster { get; set; }

        public string LastPostTopicId { get; set; }
        public virtual Topic LastPostTopic { get; set; }
    }
}
