using System;

namespace DetailingStudio_v2.Models
{
    public class Service
    {
        /// <summary>
        /// Short description of service.
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// More detailed description of service.
        /// </summary>
        public string Description { get; set; }
        
        /// <summary>
        /// Price of service. 
        /// </summary>
        public float Price { get; set; }

        /// <summary>
        /// Approximate time that takes it to execute Service.
        /// </summary>
        public DateTime OrderExecutionTime { get; set; }
    }
}
