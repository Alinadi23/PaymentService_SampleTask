using SamanProject.Common;

namespace SamanProject.Services
{
    public class PaymentServiceFactory
    {
        public IBankPaymentService GetBankPaymentService(string code)
        {
            if (code == PaymentConstant.MellatBankCode)
                return new MellatBankPaymentService();

            if (code == PaymentConstant.SamanBankCode)
                return new SamanBankPaymentService();

            if (code == PaymentConstant.AyandeBankCode)
                return new AyandehBankPaymentService();

            return null;
        }
    }
}
