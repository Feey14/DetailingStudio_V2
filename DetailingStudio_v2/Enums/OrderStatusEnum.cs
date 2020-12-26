namespace DetailingStudio_v2.Enums
{
    public enum OrderStatus : short
    {
        /// <summary>
        /// Order status - New.
        /// User created order, not approved yet.
        /// </summary>
        New = 0,

        /// <summary>
        /// Order status - Approved.
        /// Either Employee created order or order got comfirmed by employee.
        /// </summary>
        Approved = 1,

        /// <summary>
        /// Order status - Completed.
        /// Service is completed.
        /// </summary>
        Completed = 2,

        /// <summary>
        /// Order status - Canceled.
        /// Order got caneled.
        /// </summary>
        Canceled = 3,
    }
}
