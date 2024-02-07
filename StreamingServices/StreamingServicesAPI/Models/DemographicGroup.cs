namespace StreamingServicesAPI.Models
{
    public class DemographicGroup
    {
        public int Id { get; set; }
        public string ShortName { get; set; }
        public string LongName { get; set; }
        public int AccountNum { get; set; }
        public double CurrentSpending { get; set; }
        public double PreviousSpending { get; set; }
        public double TotalSpending { get; set; }
    }
}
