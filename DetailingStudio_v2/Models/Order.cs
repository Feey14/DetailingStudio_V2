using DetailingStudio_v2.Enums;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel;
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
        /// Users first name.
        /// </summary>
        [DisplayName("Name")]
        [MaxLength(50)]
        [Required]
        public string FirstName { get; set; }

        /// <summary>
        /// Users last name.
        /// </summary>
        [DisplayName("Surname")]
        [MaxLength(50)]
        [Required]
        public string LastName { get; set; }

        /// <summary>
        /// Users email adress.
        /// </summary>
        [DisplayName("E-mail")]
        [MaxLength(200)]
        [Required]
        public string Email { get; set; }
        
        /// <summary>
        /// Users Phone number
        /// </summary>
        [DisplayName("Phone number")]
        [MaxLength(20)]
        [Required]
        public string PhoneNumber { get; set; }

        /// <summary>
        /// DateTime of when order got created.
        /// </summary>
        [DisplayName("Order date")]
        public DateTime? OrderDate { get; set; } = DateTime.Now;

        /// <summary>
        /// Order payment status.
        /// </summary>
        [Required]
        [DisplayName("Payment status")]
        public OrderPaymentStatus OrderPaymentStatus { get; set; } = OrderPaymentStatus.NotPaid;

        /// <summary>
        /// Order total price.
        /// </summary>
        [Required]
        [RegularExpression(@"^\d+.?\d{0,2}$")]
        [DisplayName("Price")]
        public float TotalPrice { get; set; } = 0.00f;

        /// <summary>
        /// User message with optional message.
        /// </summary>
        [MaxLength(200)]
        [DisplayName("Details")]
        public string OrderDetails { get; set; }

        /// <summary>
        /// Order completion status.
        /// </summary>
        [Required]
        [DisplayName("Order status")]
        public OrderStatus OrderStatus { get; set; } = OrderStatus.New;

        /// <summary>
        /// Orderer ID.
        /// </summary>
        [DisplayName("User Id")]
        public string ApplicationUserId { get; set; } = null;

        /// <summary>
        /// User that made this order.
        /// </summary>
        [DisplayName("Application User")]
        public ApplicationUser ApplicationUser { get; set; }

        /// <summary>
        /// Car body type.
        /// </summary>
        [Required]
        [DisplayName("Car body type")]
        public CarBodyType CarBodyType { get; set; }

        /// <summary>
        /// Approximte order execution start time.
        /// </summary>
        [Required]
        [DisplayName("Order start time")]
        public DateTime OrderStartTime { get; set; } = DateTime.Now;

        /// <summary>
        /// Approximte order execution end time.
        /// </summary>
        [DisplayName("Order end time")]
        public DateTime OrderEndTime { get; set; }
        
        /// <summary>
        /// List of Service Ids which user ordered.
        /// </summary>
        [NotMapped]
        [DisplayName("Services")]
        public int[] ServiceIds { get; set; }

        /// <summary>
        /// Service where Order will be executed.
        /// </summary>
        [DisplayName("Affiliate")]
        public int AffiliateId { get; set; }

        /// <summary>
        /// List of services ordered.
        /// </summary>
        [Required]
        [InverseProperty("Orders")]
        [DisplayName("Services")]
        public List<Service> Services { get; set; } = new List<Service>();
    }
}
