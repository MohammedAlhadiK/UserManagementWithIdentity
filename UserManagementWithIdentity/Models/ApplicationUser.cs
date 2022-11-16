﻿using Microsoft.AspNetCore.Identity;

namespace UserManagementWithIdentity.Models
{
    public class ApplicationUser :IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string ProfilePicture { get; set; } = string.Empty;
    }
}
