using SamanProject.Common;
using System;
using System.ComponentModel.DataAnnotations;

namespace SamanProject.Resources
{
    public class TransferMoneyResource
    {
        [Required(ErrorMessage = PaymentConstant.SourceCardFieldMessage)]
        public string SourceCardNumber { get; set; }
        [Required(ErrorMessage = PaymentConstant.Cvv2FieldMessage)]
        public string CVV2 { get; set; }
        [Required(ErrorMessage = PaymentConstant.DestinationCardFieldMessage)]
        public string DestinationCardNumber { get; set; }
        [Required(ErrorMessage = PaymentConstant.PasswordFieldMessage)]
        public string Password { get; set; }
        [Required(ErrorMessage = PaymentConstant.ExpirationDateFieldMessage)]
        public string ExpirationDate { get; set; }
        public string PhoneNumber { get; set; }
    }
}
