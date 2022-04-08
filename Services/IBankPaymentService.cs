using SamanProject.Resources;
using System.Threading.Tasks;

namespace SamanProject.Services
{
    public interface IBankPaymentService
    {
        Task<TransferMoneyResourceResult> Transfer(TransferMoneyResource message);
    }
}
