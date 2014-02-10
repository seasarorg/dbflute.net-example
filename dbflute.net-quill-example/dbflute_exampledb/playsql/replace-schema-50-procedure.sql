
-- =======================================================================================
--                                                                                   Basic
--                                                                                   =====
-- #df:begin#
create procedure SP_NO_PARAMETER()
begin
end;
-- #df:end#

-- #df:begin#
create procedure SP_IN_OUT_PARAMETER(
      in v_in_varchar varchar(32)
    , out v_out_varchar varchar(32)
    , inout v_inout_varchar varchar(32)
)
begin
  set v_out_varchar = 'ddd';
  set v_inout_varchar = 'eee';
end;
-- #df:end#

-- #df:begin#
create procedure SP_VARIOUS_TYPE_PARAMETER(
      in v_in_integer integer
    , in v_in_deciaml decimal(5, 3)
    , in v_in_date date
    , in v_in_datetime datetime
)
begin
end;
-- #df:end#

-- =======================================================================================
--                                                                        Return ResultSet
--                                                                        ================
-- #df:begin#
create procedure SP_RETURN_RESULT_SET()
begin
  select MEMBER_ID, MEMBER_NAME, BIRTHDATE, FORMALIZED_DATETIME, MEMBER_STATUS_CODE
    from MEMBER;
end;
-- #df:end#

-- #df:begin#
create procedure SP_RETURN_RESULT_SET_MORE()
begin
  select MEMBER_ID, MEMBER_NAME, BIRTHDATE, FORMALIZED_DATETIME, MEMBER_STATUS_CODE
    from MEMBER;
  select * from MEMBER_STATUS;
end;
-- #df:end#

-- #df:begin#
create procedure SP_RETURN_RESULT_SET_WITH(
      in v_in_char char(3)
    , out v_out_varchar varchar(32)
    , inout v_inout_varchar varchar(32)
)
begin
  set v_out_varchar = 'ddd';
  set v_inout_varchar = 'eee';
  select MEMBER_ID, MEMBER_NAME, BIRTHDATE, FORMALIZED_DATETIME, MEMBER_STATUS_CODE
    from MEMBER
   where MEMBER_STATUS_CODE = v_in_char;
  select * from MEMBER_STATUS
   where MEMBER_STATUS_CODE = v_in_char;
end;
-- #df:end#

-- =======================================================================================
--                                                                             Transaction
--                                                                             ===========
-- #df:begin#
-- test for being called from Sql2Entity and Application Execution
create procedure SP_TRANSACTION_INHERIT()
begin
  delete from MEMBER_LOGIN;
end;
-- #df:end#
