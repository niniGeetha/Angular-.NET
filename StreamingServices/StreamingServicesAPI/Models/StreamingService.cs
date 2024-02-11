namespace StreamingServicesAPI.Models
{
    public class StreamingService
    {
        public int Id { get; set; }
        public string ShortName { get; set; }
        public string LongName { get; set; }
        public float SubscriptionPrice { get; set; }
        public double CurrentRevenue { get; set; }
        public double PreviousRevenue { get; set; }
        public double TotalRevenue { get; set; }
        public double LicensingCost { get; set; }
    }
}
