using SamanProject.Common;
using SamanProject.Resources;
using System.Threading.Tasks;

namespace SamanProject.Services
{
    public class AyandehBankPaymentService : IBankPaymentService
    {
        public async Task<TransferMoneyResourceResult> Transfer(TransferMoneyResource message)
        {
            // Call Payment Service Api and return response

            return new TransferMoneyResourceResult
            {
                StatusCode = 1,
                Description = PaymentConstant.SuccessMessage,
                DigitalTransactionID = "1111",
                TrackingCode = "1234"
            };
        }
    }
}
