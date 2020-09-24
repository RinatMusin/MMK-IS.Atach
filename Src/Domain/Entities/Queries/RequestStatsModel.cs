namespace MMK_IS.Atach.Domain.Entities.Queries
{
    public class RequestStatsModel
    {
        public string RequestUri { get; set; }
        public int Average { get; set; }
        public int Min { get; set; }
        public int Max { get; set; }
        public long Count { get; set; }
        public long Total { get; set; }
    }
}
