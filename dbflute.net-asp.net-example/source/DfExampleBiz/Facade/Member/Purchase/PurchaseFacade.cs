using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DfExample.DBFlute.AllCommon.CBean;
using DfExample.DBFlute.CBean;
using DfExample.DBFlute.ExBhv;
using DfExampleBiz.Facade.Member.Purchase.Dto;
using Seasar.Quill.Attrs;

namespace DfExampleBiz.Facade.Member.Purchase
{
    [Implementation]
    public class PurchaseFacade
    {
        protected PurchaseBhv purchaseBhv;

        protected MemberBhv memberBhv;

        public PurchaseDtoList GetPurchaseList(long memberId)
        {
            PurchaseCB cb = new PurchaseCB();
            cb.Query().SetMemberId_Equal(memberId);
            cb.SetupSelect_Member();
            cb.SetupSelect_Product();
            ListResultBean<DfExample.DBFlute.ExEntity.Purchase> list = purchaseBhv.SelectList(cb);
            PurchaseDtoList purchaseDtoList = new PurchaseDtoList();
            purchaseDtoList.PurchaseList = new List<PurchaseDto>();

            //TODO データがないときに会員の名前が取れない
            if (list.Count == 0)
            {
                MemberCB memberCB = new MemberCB();
                memberCB.Query().SetMemberId_Equal(memberId);
                DfExample.DBFlute.ExEntity.Member entity = memberBhv.SelectEntity(memberCB);
                purchaseDtoList.MemberId = entity.MemberId.ToString();
                purchaseDtoList.MemberName = entity.MemberName;
                return purchaseDtoList;
            }
            purchaseDtoList.MemberId = list[0].Member.MemberId.ToString();
            purchaseDtoList.MemberName = list[0].Member.MemberName;
            foreach (var purchase in list)
            {
                PurchaseDto dto = new PurchaseDto();
                dto.PurchaseId = purchase.PurchaseId.Value;
                dto.PurchaseCount = purchase.PurchaseCount.Value;
                dto.PaymentComplete = purchase.PaymentCompleteFlgName;
                dto.PurchaseDatetime = purchase.PurchaseDatetime.Value;
                dto.VersionNo = purchase.VersionNo.Value;
                dto.ProductName = purchase.Product.ProductName;
                dto.ProductPrice = purchase.PurchasePrice.Value;
                purchaseDtoList.PurchaseList.Add(dto);
            }
            return purchaseDtoList;
        }
    }
}
