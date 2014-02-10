
-- /= = = = = = = = = = = = = = = = = = = =
-- for the test of compound primary key
-- = = = = = = = = = =/
CREATE TABLE WHITE_COMPOUND_PK (
	PK_FIRST_ID INTEGER NOT NULL,
	PK_SECOND_ID INTEGER NOT NULL,
	PK_NAME VARCHAR(200) NOT NULL,
	PRIMARY KEY (PK_FIRST_ID, PK_SECOND_ID)
) ;

CREATE TABLE WHITE_COMPOUND_PK_REF (
	MULTIPLE_FIRST_ID INTEGER NOT NULL,
	MULTIPLE_SECOND_ID INTEGER NOT NULL,
	REF_FIRST_ID INTEGER NOT NULL,
	REF_SECOND_ID INTEGER NOT NULL,
	PRIMARY KEY (MULTIPLE_FIRST_ID, MULTIPLE_SECOND_ID)
) ;

ALTER TABLE WHITE_COMPOUND_PK_REF ADD CONSTRAINT FK_WHITE_COMPOUND_PK_REF
	FOREIGN KEY (REF_FIRST_ID, REF_SECOND_ID)
	REFERENCES WHITE_COMPOUND_PK (PK_FIRST_ID, PK_SECOND_ID) ;

-- for the test of multiple compound key
CREATE TABLE WHITE_COMPOUND_PK_REF_NEST (
	COMPOUND_PK_REF_NEST_ID INTEGER NOT NULL PRIMARY KEY,
	FOO_MULTIPLE_ID INTEGER NOT NULL,
	BAR_MULTIPLE_ID INTEGER NOT NULL,
	QUX_MULTIPLE_ID INTEGER NOT NULL
) ;

ALTER TABLE WHITE_COMPOUND_PK_REF_NEST ADD CONSTRAINT FK_WHITE_COMPOUND_PK_REF_NEST_FOO_BAR
	FOREIGN KEY (FOO_MULTIPLE_ID, BAR_MULTIPLE_ID)
	REFERENCES WHITE_COMPOUND_PK_REF (MULTIPLE_FIRST_ID, MULTIPLE_SECOND_ID) ;

ALTER TABLE WHITE_COMPOUND_PK_REF_NEST ADD CONSTRAINT FK_WHITE_COMPOUND_PK_REF_NEST_BAR_QUX
	FOREIGN KEY (BAR_MULTIPLE_ID, QUX_MULTIPLE_ID)
	REFERENCES WHITE_COMPOUND_PK_REF (MULTIPLE_FIRST_ID, MULTIPLE_SECOND_ID) ;

-- /= = = = = = = = = = = = = = = = = = 
-- for the test of unique reference
-- = = = = = = = = = =/
-- *unsupported yet
--CREATE TABLE WHITE_UQ_REFERENCE (
--	UQ_REFERENCE_ID NUMERIC(16) NOT NULL PRIMARY KEY,
--	UQ_REFERENCE_CODE CHAR(3) NOT NULL,
--	UNIQUE (UQ_REFERENCE_CODE)
--) ;
--
--CREATE TABLE WHITE_UQ_REFERENCE_REF (
--	UQ_REFERENCE_REF_ID NUMERIC(16) NOT NULL PRIMARY KEY,
--	FK_TO_PK_ID NUMERIC(16) NOT NULL,
--	FK_TO_UQ_CODE CHAR(3) NOT NULL,
--	COMPOUND_UQ_FIRST_CODE CHAR(3) NOT NULL,
--	COMPOUND_UQ_SECOND_CODE CHAR(3) NOT NULL,
--	UNIQUE (COMPOUND_UQ_FIRST_CODE, COMPOUND_UQ_SECOND_CODE)
--) ;
--
--ALTER TABLE WHITE_UQ_REFERENCE_REF ADD CONSTRAINT FK_WHITE_UQ_REFERENCE_REF_PK
--	FOREIGN KEY (FK_TO_PK_ID) REFERENCES WHITE_UQ_REFERENCE (UQ_REFERENCE_ID) ;
--
--ALTER TABLE WHITE_UQ_REFERENCE_REF ADD CONSTRAINT FK_WHITE_UQ_REFERENCE_REF_UQ
--	FOREIGN KEY (FK_TO_UQ_CODE) REFERENCES WHITE_UQ_REFERENCE (UQ_REFERENCE_CODE) ;
--
-- for the test of compound unique key
-- and the test of same name key
--CREATE TABLE WHITE_UQ_REFERENCE_REF_NEST (
--	UQ_REFERENCE_REF_NEST_ID NUMERIC(16) NOT NULL PRIMARY KEY,
--	COMPOUND_UQ_FIRST_CODE CHAR(3) NOT NULL,
--	COMPOUND_UQ_SECOND_CODE CHAR(3) NOT NULL
--) ;
--
--ALTER TABLE WHITE_UQ_REFERENCE_REF_NEST ADD CONSTRAINT FK_WHITE_UQ_REFERENCE_REF_NEST_UQ
--	FOREIGN KEY (COMPOUND_UQ_FIRST_CODE, COMPOUND_UQ_SECOND_CODE)
--	REFERENCES WHITE_UQ_REFERENCE_REF (COMPOUND_UQ_FIRST_CODE, COMPOUND_UQ_SECOND_CODE) ;

-- /= = = = = = = = = = = = = = = = = = 
-- for the test of no-primary-key table
-- = = = = = = = = = =/
CREATE TABLE WHITE_NO_PK (
	NO_PK_ID NUMERIC(16) NOT NULL,
	NO_PK_NAME VARCHAR(32),
	NO_PK_INTEGER INTEGER
) ;

-- /= = = = = = = = = = = = = = = = = = = = = = = =
-- for the test of all-in-one table classification
-- = = = = = = = = = =/
CREATE TABLE WHITE_ALL_IN_ONE_CLS (
	CLS_CATEGORY_CODE CHAR(3) NOT NULL,
	CLS_ELEMENT_CODE CHAR(3) NOT NULL,
	ATTRIBUTE_EXP TEXT NOT NULL,
	PRIMARY KEY (CLS_CATEGORY_CODE, CLS_ELEMENT_CODE)
) ;

CREATE TABLE WHITE_ALL_IN_ONE_CLS_REF (
    CLS_REF_ID INTEGER NOT NULL,
	FOO_CODE CHAR(3) NOT NULL,
	BAR_CODE CHAR(3) NOT NULL,
	QUX_CODE CHAR(3) NOT NULL,
	PRIMARY KEY (CLS_REF_ID)
) ;

-- /= = = = = = = = = = = = = = = = = = = = = = = = = = =
-- for the test of columnExcept on databaseInfoMap.dfprop
-- = = = = = = = = = =/
CREATE TABLE WHITE_COLUMN_EXCEPT (
	EXCEPT_COLUMN_ID NUMERIC(16) NOT NULL PRIMARY KEY,
	COLUMN_EXCEPT_TEST INTEGER -- actually NOT except
) ;

-- /= = = = = = = = = = = = = = = = = = =
-- for the test of MyselfInScopeSubQuery
-- = = = = = = = = = =/
CREATE TABLE WHITE_MYSELF (
	MYSELF_ID integer NOT NULL PRIMARY KEY,
	MYSELF_NAME varchar(80) NOT NULL
) ;

CREATE TABLE WHITE_MYSELF_CHECK ( 
	MYSELF_CHECK_ID integer NOT NULL PRIMARY KEY,
	MYSELF_CHECK_NAME varchar(80) NOT NULL,
	MYSELF_ID integer
) ;

ALTER TABLE WHITE_MYSELF_CHECK ADD CONSTRAINT FK_WHITE_MYSELF_CHECK_SELF
	FOREIGN KEY (MYSELF_ID) REFERENCES WHITE_MYSELF (MYSELF_ID) ;

-- /= = = = = = = = = = = = = = = = = = 
-- for the test of self reference
-- = = = = = = = = = =/

CREATE TABLE WHITE_SELF_REFERENCE (
	SELF_REFERENCE_ID NUMERIC(16) NOT NULL PRIMARY KEY,
	SELF_REFERENCE_NAME VARCHAR(200) NOT NULL,
	PARENT_ID NUMERIC(16)
) ;

ALTER TABLE WHITE_SELF_REFERENCE ADD CONSTRAINT FK_WHITE_SELF_REFERENCE_PARENT
	FOREIGN KEY (PARENT_ID) REFERENCES WHITE_SELF_REFERENCE (SELF_REFERENCE_ID) ;

-- /= = = = = = = = = = = = = = = = = = = = = = = = = =
-- for the test of ReplaceSchema delimiter data loading
-- = = = = = = = = = =/
CREATE TABLE WHITE_DELIMITER (
	DELIMITER_ID NUMERIC(16) NOT NULL PRIMARY KEY,
	NUMBER_NULLABLE INTEGER,
	STRING_CONVERTED VARCHAR(200) NOT NULL,
	STRING_NON_CONVERTED VARCHAR(200),
	DATE_DEFAULT DATE NOT NULL
) ;

-- /= = = = = = = = = = = = = = = = = = 
-- for the test of quoted table name
-- = = = = = = = = = =/
CREATE TABLE WHITE_QUOTED (
	"SELECT" INTEGER NOT NULL PRIMARY KEY,
	"FROM" VARCHAR(200)
) ;

-- /= = = = = = = = = = = = = = = = = = =
-- for the test of PgReservationWord
-- = = = = = = = = = =/
CREATE TABLE WHITE_PG_RESERV (
	CLASS integer NOT NULL PRIMARY KEY,
	"CASE" integer,
	PACKAGE integer,
	"DEFAULT" integer,
	NEW integer,
	NATIVE integer,
	VOID integer,
	PUBLIC integer,
	PROTECTED integer,
	PRIVATE integer,
	INTERFACE integer,
	ABSTRACT integer,
	FINAL integer,
	FINALLY integer,
	"RETURN" integer,
	"DOUBLE" integer,
	"FLOAT" integer,
	SHORT integer,
	TYPE char(3),
	RESERV_NAME varchar(32) NOT NULL
) ;

CREATE TABLE WHITE_PG_RESERV_REF (
	REF_ID integer NOT NULL PRIMARY KEY,
	CLASS integer
) ;

ALTER TABLE WHITE_PG_RESERV_REF ADD CONSTRAINT FK_WHITE_PG_RESERV_REF_CLASS
	FOREIGN KEY (CLASS) REFERENCES WHITE_PG_RESERV (CLASS) ;
