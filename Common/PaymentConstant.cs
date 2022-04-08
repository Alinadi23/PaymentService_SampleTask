using System;

namespace SamanProject.Common
{
    public class PaymentConstant
    {
        public const string MellatBankCode = "610433";
        public const string SamanBankCode = "621986";
        public const string AyandeBankCode = "636214";

        public const string SuccessMessage = "عملیات با موفقیت انجام شد";
        public const string ErrorMessage = "عملیات با خطا مواجه شد";
        public const string NotFoundMessage = "بانک مبدا یافت نشد";
        public const string SourceCardFieldMessage = "اطلاعات کارت مبدا را وارد کنید";
        public const string DestinationCardFieldMessage = "اطلاعات کارت مقصد را وارد کنید";
        public const string PasswordFieldMessage = "رمز دوم را وارد نمایید";
        public const string ExpirationDateFieldMessage = "تاریخ انقضا کارت را وارد نمایید";
        public const string Cvv2FieldMessage = "ورود شماره شناسایی مشتری الزامیست ";

    }
}
