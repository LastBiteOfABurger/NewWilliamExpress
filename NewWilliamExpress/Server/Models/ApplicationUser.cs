using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WilliamExpress.Shared.Domain;

namespace NewWilliamExpress.Server.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public ApplicationUser()
        {
        }
        public ApplicationUser(ApplicationUser AppUser)
        {
            this.Id = AppUser.Id;
            this.PhoneNumber = AppUser.PhoneNumber;
            this.NormalizedEmail = AppUser.NormalizedEmail;
            this.Email = AppUser.Email;
            this.NormalizedUserName = AppUser.NormalizedUserName;
            this.UserName = AppUser.UserName;
        }
    }

}
