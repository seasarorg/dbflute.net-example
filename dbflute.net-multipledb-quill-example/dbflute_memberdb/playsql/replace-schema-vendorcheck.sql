CREATE TABLE VENDOR_CHECK
(
	VENDOR_CHECK_ID NUMERIC(16) NOT NULL PRIMARY KEY,
	DECIMAL_DIGIT NUMERIC(5, 3) NOT NULL,
	INTEGER_NON_DIGIT NUMERIC(5, 0) NOT NULL,
	TYPE_OF_BOOLEAN BOOLEAN NOT NULL,
	TYPE_OF_TEXT TEXT
)  ;


CREATE TABLE VENDOR_SELF_REFERENCE
(
	SELF_REFERENCE_ID NUMERIC(16) NOT NULL PRIMARY KEY,
	SELF_REFERENCE_NAME VARCHAR(200) NOT NULL,
	PARENT_ID NUMERIC(16)
)  ;

ALTER TABLE VENDOR_SELF_REFERENCE ADD CONSTRAINT FK_VENDOR_SELF_REFERENCE_PARENT
	FOREIGN KEY (PARENT_ID) REFERENCES VENDOR_SELF_REFERENCE (SELF_REFERENCE_ID) ;


drop procedure if exists SP_NO_PARAMETER;
-- #df:begin#
create procedure SP_NO_PARAMETER()
begin
end;
-- #df:end#

drop procedure if exists SP_IN_OUT_PARAMETER;
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

drop procedure if exists SP_VARIOUS_TYPE_PARAMETER;
-- #df:begin#
create procedure SP_VARIOUS_TYPE_PARAMETER(
      in v_in_integer integer
    , in v_in_date date
    , in v_in_datetime datetime
)
begin
end;
-- #df:end#

drop procedure if exists SP_RETURN_RESULT_SET;
-- #df:begin#
create procedure SP_RETURN_RESULT_SET()
begin
  select MEMBER_ID, MEMBER_NAME, UPDATE_DATETIME
    from MEMBER;
end;
-- #df:end#

