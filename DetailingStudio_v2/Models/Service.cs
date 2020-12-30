using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DetailingStudio_v2.Models
{
    public class Service
    {
        /// <summary>
        /// Service Id.
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// Short description of service.
        /// </summary>
        [Required]
        [MaxLength(200)]
        public string Title { get; set; }

        /// <summary>
        /// More detailed description of service.
        /// </summary>
        [Required]
        [MaxLength(3000)]
        public string Description { get; set; }

        /// <summary>
        /// Price of service. 
        /// </summary>
        [Required]
        [RegularExpression(@"^\d+.?\d{0,2}$", ErrorMessage = "Invalid Target Price; Maximum Two Decimal Points.")]
        public float Price { get; set; }

        /// <summary>
        /// Approximate time that takes it to execute Service.
        /// </summary>
        [Required]
        public float OrderExecutionTime { get; set; }  
    }
}
