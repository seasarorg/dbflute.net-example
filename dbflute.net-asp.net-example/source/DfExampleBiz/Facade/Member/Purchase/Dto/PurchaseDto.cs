using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DfExampleBiz.Facade.Member.Purchase.Dto
{
    public class PurchaseDto
    {
        public long PurchaseId { get; set; }

        public DateTime PurchaseDatetime { get; set; }

        public string ProductName { get; set; }

        public long ProductPrice { get; set; }

        public string PaymentComplete { get; set; }

        public long PurchaseCount { get; set; }

        public long VersionNo { get; set; }
    }
}
