-- #UnpaidSummaryMember#

-- !UnpaidSummaryMemberPmb extends SPB!
-- !!int? memberId!!
-- !!String memberName!!
-- !!String memberStatusCode:cls(MemberStatus)!!
-- !!bool unpaidMemberOnly!!

/*IF pmb.IsPaging*/
select member.MEMBER_ID
     , member.MEMBER_NAME
     , (select sum(purchase.PURCHASE_PRICE)
          from PURCHASE purchase
         where purchase.MEMBER_ID = member.MEMBER_ID
           and purchase.PAYMENT_COMPLETE_FLG = 0
       ) as UNPAID_PRICE_SUMMARY
     , memberStatus.MEMBER_STATUS_NAME
-- ELSE select count(*)
/*END*/
  from MEMBER member
    /*IF pmb.IsPaging*/
    left outer join MEMBER_STATUS memberStatus
      on member.MEMBER_STATUS_CODE = memberStatus.MEMBER_STATUS_CODE
    /*END*/
 /*BEGIN*/where
   /*IF pmb.MemberId != null*/member.MEMBER_ID = /*pmb.MemberId*/3/*END*/
   /*IF pmb.MemberName != null*/and member.MEMBER_NAME like /*pmb.MemberName*/'S' || '%'/*END*/
   /*IF pmb.MemberStatusCode != null*/and member.MEMBER_STATUS_CODE = /*pmb.MemberStatusCode*/'FML'/*END*/
   /*IF pmb.UnpaidMemberOnly*/
   and exists (select 'yes'
                 from PURCHASE purchase
                where purchase.MEMBER_ID = member.MEMBER_ID
                  and purchase.PAYMENT_COMPLETE_FLG = 0
       )
   /*END*/
 /*END*/
 /*IF pmb.IsPaging*/
 order by UNPAID_PRICE_SUMMARY desc, member.MEMBER_ID asc
 /*END*/
