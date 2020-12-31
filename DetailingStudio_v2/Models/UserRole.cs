using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DetailingStudio_v2.Models
{
    public class UserRole
    {
        /// <summary>
        /// User Id.
        /// </summary>
        public string UserId { get; set; }
        
        /// <summary>
        /// User username for displaying appropriate user.
        /// </summary>
        public string UserName { get; set; }
        
        /// <summary>
        /// Indicates whether if user is selected.
        /// </summary>
        public bool IsSelected { get; set; }
    }
}
