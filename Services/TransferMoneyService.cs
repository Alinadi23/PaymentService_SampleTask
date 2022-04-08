using SamanProject.Common;
using SamanProject.Domain;
using SamanProject.Repository;
using SamanProject.Resources;
using System.Threading.Tasks;

namespace SamanProject.Services
{
    public class TransferMoneyService : ITransferMoneyService
    {
        private readonly IBankInfoRepository _bankInfoRepository;
        public TransferMoneyService(IBankInfoRepository bankInfoRepository)
        {
            _bankInfoRepository = bankInfoRepository;
        }
        public async Task<TransferMoneyResourceResult> TransferMoney(TransferMoneyResource message)
        {
            var result = new TransferMoneyResourceResult();

            var bankInfo = GetBankInfo(message.SourceCardNumber);
            if (bankInfo == null)
            {
                result.ErrorMessage = PaymentConstant.NotFoundMessage;
                return result;
            }
            
            var paymentFactory = new PaymentServiceFactory();
            IBankPaymentService paymentService = paymentFactory.GetBankPaymentService(bankInfo.Code);

            result = await paymentService.Transfer(message);

            return result;
        }

        private BankInfo GetBankInfo(string CardNumber)
        {
            var subCardNo = CardNumber.Substring(0, 6);
            var info = _bankInfoRepository.GetByCardNo(subCardNo);

            return info;
        }
    }
}
