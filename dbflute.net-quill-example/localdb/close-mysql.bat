
cd %~p0
call _env.bat

%MYSQL_HOME%\bin\mysqladmin -u root --port 53306 shutdown

pause
