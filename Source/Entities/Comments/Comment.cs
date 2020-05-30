﻿using System;
using LaDanse.Source.Entities.Identity;

namespace LaDanse.Source.Entities.Comments
{
    public partial class Comment
    {
        public Guid Id { get; set; }

        public DateTime PostDate { get; set; }
        public string Message { get; set; }
        
        public Guid GroupId { get; set; }
        public virtual CommentGroup Group { get; set; }

        public int PosterId { get; set; }
        public virtual Account Poster { get; set; }
    }
}
