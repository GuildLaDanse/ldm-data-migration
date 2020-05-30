﻿using System;
using LaDanse.Source.Entities.Identity;

namespace LaDanse.Source.Entities.Forums
{
    public partial class UnreadPost
    {
        public Guid Id { get; set; }

        public int AccountId { get; set; }
        public virtual Account Account { get; set; }

        public Guid PostId { get; set; }
        public virtual Post Post { get; set; }
    }
}
