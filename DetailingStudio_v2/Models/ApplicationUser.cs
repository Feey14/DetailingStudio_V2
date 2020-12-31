using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace DetailingStudio_v2.Models
{
    public class ApplicationUser : IdentityUser
    {
        /// <summary>
        /// User first name.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// User last name.
        /// </summary>
        public string Surname { get; set; }

        /// <summary>
        /// User orders.
        /// </summary>
        [InverseProperty("ApplicationUser")]
        public List<Order> Orders { get; set; } = new List<Order>();
    }
}
