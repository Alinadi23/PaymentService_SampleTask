using SamanProject.Domain;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SamanProject.Repository
{
    public class BankInfoRepository : IBankInfoRepository
    {
        // similar to BankInfo table records in database
        List<BankInfo> bankInfoRecords = new List<BankInfo>()
        {
            new BankInfo {Key = 1, Code = "610433", Name = "MellatBank", IsGovernmental = true, Url = "url/to/access/mellat"},
            new BankInfo {Key = 2, Code = "621986", Name = "SamanBank", IsGovernmental = false, Url = "url/to/access/saman"},
            new BankInfo {Key = 3, Code = "636214", Name = "AyandeBank", IsGovernmental = false, Url = "url/to/access/Ayandeh"},
        };

        public BankInfo GetByCardNo(string CardNo)
        {
            var bankInfo = bankInfoRecords.Where(b => b.Code == CardNo).FirstOrDefault();
            return bankInfo;
        }
    }
}
