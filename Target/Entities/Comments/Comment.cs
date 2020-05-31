﻿using System;
using LaDanse.Target.Entities.Identity;
using LaDanse.Target.Entities.Shared;

namespace LaDanse.Target.Entities.Comments
{
    public partial class Comment : IBaseEntity<Guid>
    {
        public Guid Id { get; set; }

        public DateTime PostDate { get; set; }
        public string Content { get; set; }
        
        public Guid GroupId { get; set; }
        public virtual CommentGroup Group { get; set; }

        public Guid PosterId { get; set; }
        public virtual User Poster { get; set; }
    }
}
