
PURGE RECYCLEBIN;

CREATE MATERIALIZED VIEW SUMMARY_MEMBER_PURCHASE
refresh complete
on commit
AS
select purchase.MEMBER_ID
     , sum(purchase.PURCHASE_PRICE) as ALLSUM_PURCHASE_PRICE
     , max(purchase.PURCHASE_DATETIME) as LATEST_PURCHASE_DATETIME
  from PURCHASE purchase
 group by purchase.MEMBER_ID
;

-- #df:assertCountZero#
select count(*)
  from MEMBER
 where MEMBER_STATUS_CODE = 'FML'
   and FORMALIZED_DATETIME is null
;

-- #df:assertListZero#
select member.MEMBER_ID, member.MEMBER_NAME
  from MEMBER member
 where member.MEMBER_STATUS_CODE = 'WDL'
   and not exists (select withdrawal.MEMBER_ID
                     from MEMBER_WITHDRAWAL withdrawal
                    where withdrawal.MEMBER_ID = member.MEMBER_ID
       )
;
