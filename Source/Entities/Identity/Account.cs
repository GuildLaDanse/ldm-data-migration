﻿using System;

namespace LaDanse.Source.Entities.Identity
{
    public partial class Account
    {
        public Account()
        {
            
        }

        public int Id { get; set; }
        public string Username { get; set; }
        public string UsernameCanonical { get; set; }
        public string Email { get; set; }
        public string EmailCanonical { get; set; }
        public bool Enabled { get; set; }
        public string Salt { get; set; }
        public string Password { get; set; }
        public DateTime? LastLogin { get; set; }
        public string ConfirmationToken { get; set; }
        public DateTime? PasswordRequestedAt { get; set; }
        public string Roles { get; set; }
        public string DisplayName { get; set; }
    }
}
