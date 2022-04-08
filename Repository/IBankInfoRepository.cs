using SamanProject.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SamanProject.Repository
{
    public interface IBankInfoRepository
    {
        BankInfo GetByCardNo(string CardNo);
    }
}
