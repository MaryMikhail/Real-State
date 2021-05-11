using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using RealEstate.Models;

namespace RealEstate.Areas.Identity.Data
{
    // Add profile data for application users by adding properties to the RealEstateUser class
    public enum UserType
    {
      SingleUser,Agent,Agency
    }

    public enum Gender
    {
        Female,Male
    }
    public class RealEstateUser : IdentityUser
    {
        [Required]
        [Display(Name = "User Type")]
        public UserType UserType { get; set; }

        [Required]
        [Display(Name = "Gender")]
        public Gender gender { get; set; }

        public virtual ICollection<Property> Properties { get; set; }

    }
}
