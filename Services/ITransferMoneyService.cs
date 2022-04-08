using SamanProject.Resources;
using System.Threading.Tasks;

namespace SamanProject.Services
{
    public interface ITransferMoneyService
    {
        Task<TransferMoneyResourceResult> TransferMoney(TransferMoneyResource message);
    }
}
