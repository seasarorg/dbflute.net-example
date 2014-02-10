-- #OptionMember#

-- !OptionMemberPmb!
-- !!int? memberId!!
-- !!String memberName:like!!

select member.MEMBER_ID
     , member.MEMBER_NAME
     , member.MEMBER_STATUS_CODE -- for Classification Test of Sql2Entity
     , memberStatus.MEMBER_STATUS_NAME
/*END*/
  from MEMBER member
    left outer join MEMBER_STATUS memberStatus
      on member.MEMBER_STATUS_CODE = memberStatus.MEMBER_STATUS_CODE
 /*BEGIN*/where
   /*IF pmb.MemberId != null*/member.MEMBER_ID = /*pmb.MemberId*/3/*END*/
   /*IF pmb.MemberName != null*/and member.MEMBER_NAME like /*pmb.MemberName*/'ス%'/*END*/
   /*END*/
 /*END*/
 order by member.MEMBER_ID asc
