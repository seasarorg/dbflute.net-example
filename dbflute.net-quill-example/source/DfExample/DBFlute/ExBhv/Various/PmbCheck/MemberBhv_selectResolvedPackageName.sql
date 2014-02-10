
-- !ResolvedPackageNamePmb!
-- !!String string1!!
-- !!int? integer1!!
-- !!DateTime? date1!!
-- !!IList<String> list1!!
-- !!IList<String> list2!!
-- !!$$CDef$$.Flg cdefFlg!!
-- !!IList<$$CDef$$.MemberStatus> cdefList:ref(MEMBER.MEMBER_STATUS_CODE)!!
-- !!IList<$$CDef$$.MemberStatus> memberStatusCodeList:ref(MEMBER)!!
-- !!byte[] bytes!!

select member.MEMBER_ID
     , member.MEMBER_NAME
  from MEMBER member
 /*BEGIN*/where
   /*IF pmb.Date1 != null*/member.BIRTHDATE <= /*pmb.Date1*/'2000-12-12'/*END*/
   /*IF pmb.List1 != null*/and member.MEMBER_STATUS_CODE in /*pmb.List1*/('FML', 'PVS')/*END*/
 /*END*/
 order by member.MEMBER_ID asc
