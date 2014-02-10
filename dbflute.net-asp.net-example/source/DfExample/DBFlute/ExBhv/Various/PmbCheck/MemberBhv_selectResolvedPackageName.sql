-- selectResolvedPackageName.sql

-- !ResolvedPackageNamePmb!
-- !!String string1!!
-- !!int? integer1!!
-- !!DateTime? date1!!
-- !!IList<String> list1!!
-- !!System.Collections.Generic.IList<String> list2!!

select member.MEMBER_ID
     , member.MEMBER_NAME
  from MEMBER member
 /*BEGIN*/where
   /*IF pmb.date1 != null*/member.BIRTHDATE <= /*pmb.date1*/'2000-12-12'/*END*/
   /*IF pmb.list1 != null*/and member.MEMBER_STATUS_CODE in /*pmb.list1*/('FML', 'PVS')/*END*/
 /*END*/
 order by member.MEMBER_ID asc
