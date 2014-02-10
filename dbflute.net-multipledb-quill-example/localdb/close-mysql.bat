
cd %~p0
call _env.bat

%MYSQL_HOME%\bin\mysqladmin -u root --port 56606 shutdown

pause
