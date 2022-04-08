using System;

namespace SamanProject.Resources
{
    public class TransferMoneyResourceResult : QueryResult
    {
        public int StatusCode { get; set; }
        public string Description { get; set; }
        public string DigitalTransactionID { get; set; }
        public string TrackingCode { get; set; }
    }
}
