using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DetailingStudio_v2.Models
{
    public class EditRole
    {
        /// <summary>
        /// User role Id.
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// User role name.
        /// </summary>
        [Required(ErrorMessage = "Role Name is Required)")]
        public string RoleName { get; set; }

        /// <summary>
        /// Users in this user role.
        /// </summary>
        public List<string> Users { get; set; } = new List<string>();
    }
}
