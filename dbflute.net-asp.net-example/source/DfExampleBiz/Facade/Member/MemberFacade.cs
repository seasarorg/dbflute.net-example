using System;
using System.Collections.Generic;
using DfExample.DBFlute.AllCommon.CBean;
using DfExample.DBFlute.AllCommon.CBean.COption;
using DfExample.DBFlute.CBean;
using DfExample.DBFlute.ExBhv;
using DfExample.DBFlute.ExEntity;
using DfExampleBiz.Facade.Member.Condition;
using DfExampleBiz.Facade.Member.Dto;
using Seasar.Quill.Attrs;

namespace DfExampleBiz.Facade.Member
{
    [Implementation]
    public class MemberFacade
    {
        /// <summary>
        /// メンバーBhv
        /// </summary>
        protected MemberBhv memberBhv;

        /// <summary>
        /// メンバーステータスBhv
        /// </summary>
        protected MemberStatusBhv memberStatusBhv;

        /// <summary>
        /// メンバー一覧を取得する
        /// </summary>
        /// <param name="memberCB">画面から設定する検索項目</param>
        /// <returns>メンバー一覧</returns>
        public MemberDtoList GetMemberList(MemberCondition memberCB)
        {
            //ConditionBeanに検索条件詰め替え
            MemberCB cb = new MemberCB();
            cb.SetupSelect_MemberStatus();
            cb.Query().SetMemberName_PrefixSearch(memberCB.MemberName);
            cb.Query().SetMemberStatusCode_Equal(memberCB.MemberStatusCd);
            //未払いが有る人を検索するとき条件追加
            if(memberCB.HasUnPaid)
            {
                cb.Query().ExistsPurchaseList(delegate(PurchaseCB subCB)
                {
                    subCB.Query().SetPaymentCompleteFlg_Equal_False();
                });
            }
            //商品を買ったことがあるか？
            if (!string.IsNullOrEmpty(memberCB.PurchaseItemName))
            {
                cb.Query().ExistsPurchaseList(delegate(PurchaseCB subCB)
                {
                    subCB.SetupSelect_Product();
                    subCB.Query().ConditionQueryProduct.SetProductName_PrefixSearch(memberCB.PurchaseItemName);
                });
            }

            cb.Query().SetFormalizedDatetime_FromTo(memberCB.FormalizedDatetimeFrom, memberCB.FormalizedDatetimeTo, new FromToOption().CompareAsDate());
            //ページ設定
            cb.Paging(memberCB.PageSize,memberCB.PageNumber);
            //TODO ソートを画面に実装するときは考える
            //とりあえず更新日降順でソート設定
            cb.Query().AddOrderBy_UpdateDatetime_Desc();
            MemberDtoList list = new MemberDtoList();
            list.MemberList = new List<MemberDto>();
            PagingResultBean<DfExample.DBFlute.ExEntity.Member> page = memberBhv.SelectPage(cb);
            list.AllRecordCount = page.AllPageCount;

            foreach (var member in page)
            {
                MemberDto dto = new MemberDto();
                dto.MemberId = member.MemberId.ToString();
                dto.MemberName = member.MemberName;
                dto.MemberStatus = member.MemberStatus.MemberStatusName;
                dto.FormalizedDatetime = member.FormalizedDatetime.ToString();
                dto.UpdateDatetime = member.UpdateDatetime.ToString();
                dto.VersionNo = member.VersionNo;
                list.MemberList.Add(dto);
            }
            
            return list;
        }

        /// <summary>
        /// メンバーステータス一覧取得
        /// </summary>
        /// <returns>メンバーステータス一覧</returns>
        public IList<KeyValuePair<string, string>> GetMemberStatusList()
        {
            MemberStatusCB cb = new MemberStatusCB();
            cb.Query().AddOrderBy_DisplayOrder_Asc();
            ListResultBean<MemberStatus> list = memberStatusBhv.SelectList(cb);
            IList<KeyValuePair<string, string>> pairList = new List<KeyValuePair<string, string>>();
            foreach (var memberStatus in list)
            {
                pairList.Add(new KeyValuePair<string, string>(memberStatus.MemberStatusCode, memberStatus.MemberStatusName)); ;
            }
            return pairList;
        }

        //編集画面で使用

        public MemberDto GetMember(long memberId)
        {
            MemberCB cb = new MemberCB();
            cb.SetupSelect_MemberStatus();
            cb.Specify().DerivedMemberLoginList().Max(delegate(MemberLoginCB subCB)
                                                          {
                                                              subCB.Specify().ColumnLoginDatetime();
                                                          },"LATEST_LOGIN_DATETIME");
            //cb.SetupSelect_MemberLoginAsLatest();
            cb.Query().SetMemberId_Equal(memberId);
            DfExample.DBFlute.ExEntity.Member entity = memberBhv.SelectEntityWithDeletedCheck(cb);
            MemberDto dto = new MemberDto();
            dto.MemberId = entity.MemberId.ToString();
            dto.MemberName = entity.MemberName;
            dto.MemberAccount = entity.MemberAccount;
            dto.MemberStatusCode = entity.MemberStatusCode;
            dto.Birthdate = String.Format("{0:yyyy/MM/dd}",entity.Birthdate);
            dto.FormalizedDatetime = entity.FormalizedDatetime.ToString();
            dto.UpdateDatetime = entity.UpdateDatetime.ToString();
            dto.LatestLoginDatetime = entity.LatestLoginDatetime != null ? entity.LatestLoginDatetime.ToString() : "";
            return dto;
        }

        [Transaction]
        public virtual void Update(MemberDto dto)
        {
            MemberCB cb = new MemberCB();
            cb.Query().SetMemberId_Equal(long.Parse(dto.MemberId));
            DfExample.DBFlute.ExEntity.Member member = memberBhv.SelectEntityWithDeletedCheck(cb);
            member.MemberAccount = dto.MemberAccount;
            member.MemberName = dto.MemberName;
            member.VersionNo = dto.VersionNo;
            if (!string.IsNullOrEmpty(dto.Birthdate))
            {
                member.Birthdate = DateTime.Parse(dto.Birthdate);
            }
            memberBhv.Update(member);
        }
    }
}
