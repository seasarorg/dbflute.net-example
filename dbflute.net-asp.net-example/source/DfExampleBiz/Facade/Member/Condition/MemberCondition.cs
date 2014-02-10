using System;
using DfExampleBiz.Common;

namespace DfExampleBiz.Facade.Member.Condition
{
    public class MemberCondition : PageCondition
    {
        /// <summary>
        /// 会員名
        /// </summary>
        public String MemberName { get; set; }

        /// <summary>
        /// 購入商品名
        /// </summary>
        public String PurchaseItemName { get; set; }
        
        /// <summary>
        /// 会員ステータスコード
        /// </summary>
        public String MemberStatusCd { get; set; }
        
        /// <summary>
        /// 未払いがあるか？
        /// </summary>
        public bool HasUnPaid { get; set; }
        
        /// <summary>
        /// 正式会員日From
        /// </summary>
        public DateTime? FormalizedDatetimeFrom { get; set; }

        /// <summary>
        /// 正式会員日To
        /// </summary>
        public DateTime? FormalizedDatetimeTo { get; set; }
        
        /// <summary>
        /// ページ番号
        /// </summary>
        public int PageNumber { get; set; }
    }
}
