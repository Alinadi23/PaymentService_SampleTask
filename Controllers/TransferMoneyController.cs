using Microsoft.AspNetCore.Mvc;
using SamanProject.Resources;
using SamanProject.Services;
using System.Threading.Tasks;

namespace SamanProject.Controllers
{
    [ApiController]
    [Route("[Controller]/[Action]")]
    public class TransferMoneyController : Controller
    {
        private readonly ITransferMoneyService _transferMoneyService;

        public TransferMoneyController(ITransferMoneyService transferMoneyService)
        {
            _transferMoneyService = transferMoneyService;
        }
        [HttpPost]
        public async Task<TransferMoneyResourceResult> TransferMoney(TransferMoneyResource message)
        {
            return await _transferMoneyService.TransferMoney(message);
        }
    }
}
