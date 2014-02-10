
-- #df:entity#

-- !df:pmb!
-- !!int? memberId!!
-- !!String memberName:likePrefix!!

select member.MEMBER_ID
     , member.MEMBER_NAME
     , memberStatus.MEMBER_STATUS_NAME
  from MEMBER member
    left outer join MEMBER_STATUS memberStatus
      on member.MEMBER_STATUS_CODE = memberStatus.MEMBER_STATUS_CODE
 /*BEGIN*/where
   /*IF pmb.MemberId != null*/member.MEMBER_ID = /*pmb.MemberId*/3/*END*/
   /*IF pmb.MemberName != null*/and member.MEMBER_NAME like /*pmb.MemberName*/'S%'/*END*/
 /*END*/
 order by member.MEMBER_ID asc
