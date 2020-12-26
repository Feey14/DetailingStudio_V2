namespace DetailingStudio_v2.Enums
{
    public enum OrderPaymentStatus : short
    {
        /// <summary>
        /// Payment status - Not paid
        /// </summary>
        NotPaid = 0,

        /// <summary>
        /// Payment status - Payment is pending
        /// </summary>
        PaymentPending = 1,

        /// <summary>
        /// Payment status - Paid
        /// </summary>
        Paid = 2,
    }
}
