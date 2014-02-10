
@ECHO OFF
REM ==========================================
REM                                    DB Boot
REM ==========================================
SET DIR_NAME=%~dp0
PUSHD %DIR_NAME%
TITLE MySQL-Daemon
@ECHO Bootup...

cd %~dp0
call _env.bat

%MYSQL_HOME%\bin\mysqld-nt --defaults-file=.\my.ini

POPD
@ECHO ----------
@ECHO Catch Termination Signal...
@ECHO DB Closed.
@ECHO ----------

pause
