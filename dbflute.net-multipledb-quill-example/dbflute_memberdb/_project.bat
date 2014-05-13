@echo off

set ANT_OPTS=-Xmx256M

set MY_PROJECT_NAME=memberdb

set DBFLUTE_HOME=..\mydbflute\dbflute-0.8.9.58

if "%pause_at_end%"=="" set pause_at_end=y
