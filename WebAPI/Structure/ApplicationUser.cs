using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebAPI.Structure
{
    public class ApplicationUser : IdentityUser
    {
        [Required]
        [MaxLength(100)]
        public String FirstName { get; set; }
        
        [Required]
        [MaxLength(100)]
        public String LastName { get; set; }

        [Required]
        public byte Level { get; set; }

        [Required]
        public DateTime JoinDate { get; set; }
    }
}