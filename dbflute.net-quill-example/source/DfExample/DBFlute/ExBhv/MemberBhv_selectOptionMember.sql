-- #df:entity#

-- !df:pmb!
-- !!int? memberId!!
-- !!String memberName:likePrefix!!
-- !!String memberAccount:like!!
-- !!DateTime? fromFormalizedDate:fromDate!!
-- !!DateTime? toFormalizedDate:toDate!!
-- !!String memberStatusCode:cls(MemberStatus)!!
-- !!int? paymentCompleteFlg:cls(Flg)!!

select member.MEMBER_ID
     , member.MEMBER_NAME
     , member.BIRTHDATE
     , member.FORMALIZED_DATETIME
     , member.MEMBER_STATUS_CODE -- for Classification Test of Sql2Entity
     , memberStatus.MEMBER_STATUS_NAME
     , 0 as DUMMY_FLG -- for Classification Test of Sql2Entity
     , 0 as DUMMY_NOFLG -- for Classification Test of Sql2Entity
/*END*/
  from MEMBER member
    left outer join MEMBER_STATUS memberStatus
      on member.MEMBER_STATUS_CODE = memberStatus.MEMBER_STATUS_CODE
 /*BEGIN*/where
   /*IF pmb.MemberId != null*/
   member.MEMBER_ID = /*pmb.MemberId*/3
   /*END*/
   /*IF pmb.MemberName != null*/
   and member.MEMBER_NAME like /*pmb.MemberName*/'S%'
   /*END*/
   /*IF pmb.MemberAccount != null*/
   and member.MEMBER_ACCOUNT like /*pmb.MemberAccount*/'%v%'
   /*END*/
   /*IF pmb.FromFormalizedDate != null*/
   and member.FORMALIZED_DATETIME >= /*pmb.FromFormalizedDate*/'1964-12-27'
   /*END*/
   /*IF pmb.ToFormalizedDate != null*/
   and member.FORMALIZED_DATETIME < /*pmb.ToFormalizedDate*/'1974-04-17'
   /*END*/
   /*IF pmb.MemberStatusCode != null*/
   and member.MEMBER_STATUS_CODE = /*pmb.MemberStatusCode*/'WDL'
   /*END*/
   /*END*/
 /*END*/
 order by member.MEMBER_ID asc
