using DetailingStudio_v2.Enums;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DetailingStudio_v2.Models
{
    public class Order
    {
        /// <summary>
        /// Order ID.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// DateTime of when order got created.
        /// </summary>
        public DateTime? OrderDate { get; set; } = DateTime.Now;

        /// <summary>
        /// Order payment status.
        /// </summary>
        [Required]
        public OrderPaymentStatus OrderPaymentStatus { get; set; } = OrderPaymentStatus.NotPaid;

        /// <summary>
        /// Order total price.
        /// </summary>
        [Required]
        [RegularExpression(@"^\d+.?\d{0,2}$")]
        public float TotalPrice { get; set; } = 0.00f;

        /// <summary>
        /// User message with optional message.
        /// </summary>
        [MaxLength(200)]
        public string OrderDetails { get; set; }

        /// <summary>
        /// Order completion status.
        /// </summary>
        [Required]
        public OrderStatus OrderStatus { get; set; } = OrderStatus.New;

        /// <summary>
        /// Orderer ID.
        /// </summary>
        public string ApplicationUserId { get; set; } = "-1";

        /// <summary>
        /// User that made this order.
        /// </summary>
        public ApplicationUser ApplicationUser { get; set; }

        /// <summary>
        /// Car body type.
        /// </summary>
        [Required]
        public CarBodyType CarBodyType { get; set; }

        /// <summary>
        /// Approximte order execution start time.
        /// </summary>
        [Required]
        public DateTime OrderStartTime { get; set; } = DateTime.Now;

        /// <summary>
        /// Approximte order execution end time.
        /// </summary>
        public DateTime OrderEndTime { get; set; }
        
        /// <summary>
        /// List of Service Ids which user ordered.
        /// </summary>
        [NotMapped]
        public int[] ServiceIds { get; set; }

        /// <summary>
        /// Service where Order will be executed.
        /// </summary>
        public int AffiliateId { get; set; }

        /// <summary>
        /// List of services ordered.
        /// </summary>
        [InverseProperty("Orders")]
        public List<Service> Services { get; set; } = new List<Service>();
    }
}
