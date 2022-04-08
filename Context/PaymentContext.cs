using Microsoft.EntityFrameworkCore;
using SamanProject.Domain;

namespace SamanProject.Context
{
    public class PaymentContext : DbContext
    {
        public PaymentContext()
        {
        }
        public DbSet<BankInfo> BankInfos { get; set; }
    }
}
