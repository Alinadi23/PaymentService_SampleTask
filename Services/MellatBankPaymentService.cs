using SamanProject.Common;
using SamanProject.Resources;
using System.Threading.Tasks;

namespace SamanProject.Services
{
    public class MellatBankPaymentService : IBankPaymentService
    {
        public async Task<TransferMoneyResourceResult> Transfer(TransferMoneyResource message)
        {
            // Call Payment Service Api and return response

            return new TransferMoneyResourceResult
            {
                StatusCode = 0,
                Description = PaymentConstant.ErrorMessage,
                DigitalTransactionID = "2222",
                TrackingCode = "1010"
            };
        }
    }
}
