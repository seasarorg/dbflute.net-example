-- #PurchaseMaxPriceMember#

-- !PurchaseMaxPriceMemberPmb extends SPB!
-- !!int? memberId!!
-- !!String memberName!!

/*IF pmb.IsPaging*/
select *
  from (
select base.*, rownum as rn
  from (

select member.MEMBER_ID
     , member.MEMBER_NAME
     , (select max(purchase.PURCHASE_PRICE)
          from PURCHASE purchase
         where purchase.MEMBER_ID = member.MEMBER_ID
       ) as PURCHASE_MAX_PRICE
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
 /*END*/
 /*IF pmb.IsPaging*/
 order by PURCHASE_MAX_PRICE desc, member.MEMBER_ID asc
 /*END*/

 /*IF pmb.IsPaging*/
       ) base
       )
 where rn > /*pmb.PageStartIndex*/80
   and rn <= /*pmb.PageEndIndex*/100
 /*END*/
