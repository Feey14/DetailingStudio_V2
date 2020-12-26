using DetailingStudio_v2.Enums;
using System;
using System.Collections.Generic;

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
        public DateTime OrderDate { get; set; }

        /// <summary>
        /// Order payment status.
        /// </summary>
        public OrderPaymentStatus OrderPaymentStatus { get; set; }

        /// <summary>
        /// Order total price.
        /// </summary>
        public float TotalPrice { get; set; }

        /// <summary>
        /// User message with optional message.
        /// </summary>
        public string OrderDetails { get; set; }

        /// <summary>
        /// Order completion status.
        /// </summary>
        public OrderStatus OrderStatus { get; set; }
        
        /// <summary>
        /// Orderer ID.
        /// </summary>
        public int CustomerID { get; set; }

        /// <summary>
        /// Car body type.
        /// </summary>
        public CarBodyType CarBodyType { get; set; }

        /// <summary>
        /// List of services in this order.
        /// </summary>
        public List<Service> Orders { get; set; }

        /// <summary>
        /// Approximte order execution start time.
        /// </summary>
        public DateTime OrderStartTime { get; set; }

        /// <summary>
        /// Approximte order execution end time.
        /// </summary>
        public DateTime OrderEndTime { get; set; }
    }
}
