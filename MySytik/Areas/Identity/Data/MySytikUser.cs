using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace MySytik.Areas.Identity.Data
{
    // Add profile data for application users by adding properties to the MySytikUser class
    public class MySytikUser : IdentityUser
    {
        [PersonalData]
        [Column(TypeName = "nvarchar(15)")]
        public string FirstName { get; set; }
        [PersonalData]
        [Column(TypeName = "nvarchar(25)")]
        public string LastName { get; set; }
        



    }
}
