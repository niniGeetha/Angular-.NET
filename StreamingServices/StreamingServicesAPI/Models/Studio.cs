namespace StreamingServicesAPI.Models
{
    public class Studio
    {
        public int Id { get; set; }
        public string ShortName { get; set; }
        public string LongName { get; set; }        
        public double CurrentRevenue { get; set; }
        public double PreviousRevenue { get; set; }
        public double TotalRevenue { get; set; } 
        
    }
}
