using System;

namespace SamanProject.Domain
{
    public class BankInfo
    {
        public int Key { get; set; }
        public String Code { get; set; }
        public String Name { get; set; }
        public bool IsGovernmental { get; set; }
        public string Url { get; set; }
    }
}
