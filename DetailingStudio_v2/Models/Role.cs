using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DetailingStudio_v2.Models
{
    public class Role
    {
        /// <summary>
        /// Rolename required to create new role.
        /// </summary>
        [Required]
        public string RoleName { get; set; }
    }
}
