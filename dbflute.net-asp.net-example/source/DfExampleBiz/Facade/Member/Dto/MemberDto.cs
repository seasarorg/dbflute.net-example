using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DfExampleBiz.Facade.Member.Dto
{
    public class MemberDto
    {
        public String MemberName { get; set; }

        public String MemberStatus { get; set; }

        public String FormalizedDatetime { get; set; }

        public String UpdateDatetime { get; set; }

        public String MemberId { get; set; }

        public String NavigateEdit { get { return "MemberEdit.aspx?mi=" + MemberId + "&vn=" + VersionNo; } }

        public String NavigatePurchase { get { return "Purchase/PurchaseList.aspx?mi=" + MemberId + "&vn=" + VersionNo; } }

        public String MemberAccount { get; set; }

        public String MemberStatusCode { get; set; }

        public String Birthdate { get; set; }

        public String LatestLoginDatetime { get; set; }
        
        public long? VersionNo { get; set; }
    }
}
