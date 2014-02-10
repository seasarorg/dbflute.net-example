@echo off

%~d0
cd %~p0
call _project.bat

rem /nnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnn
rem Specify the file path to be used as build-properties.
rem nnnnnnnnnn/
set MY_PROPERTIES_PATH=build.properties

rem /nnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnn
rem Execute {JDBC}.
rem nnnnnnnnnn/
call %DBFLUTE_HOME%\etc\cmd\_df-jdbc.cmd %MY_PROPERTIES_PATH%

rem /nnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnn
rem Execute {Document}.
rem nnnnnnnnnn/
call %DBFLUTE_HOME%\etc\cmd\_df-doc.cmd %MY_PROPERTIES_PATH%

rem /nnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnn
rem Execute {Generate}.
rem nnnnnnnnnn/
call %DBFLUTE_HOME%\etc\cmd\_df-generate.cmd %MY_PROPERTIES_PATH%

rem /nnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnnn
rem Execute {Sql2Entity}.
rem nnnnnnnnnn/
call %DBFLUTE_HOME%\etc\cmd\_df-sql2entity.cmd %MY_PROPERTIES_PATH%
