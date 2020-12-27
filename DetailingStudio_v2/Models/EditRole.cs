using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DetailingStudio_v2.Models
{
    public class EditRole
    {
        public string Id { get; set; }

        [Required(ErrorMessage = "Role Name is Required)")]
        public string RoleName { get; set; }

        public List<string> Users { get; set; } = new List<string>();
    }
}
