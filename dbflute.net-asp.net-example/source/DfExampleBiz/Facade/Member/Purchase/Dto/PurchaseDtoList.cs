using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DfExampleBiz.Facade.Member.Purchase.Dto
{
    public class PurchaseDtoList
    {
        public IList<PurchaseDto> PurchaseList { get; set; }

        public string MemberId { get; set; }

        public string MemberName { get; set; }
    }
}
