
cd %~p0
call _env.bat

%MYSQL_HOME%\bin\mysqladmin --user=root --host=localhost --port=56606 create librarydb
%MYSQL_HOME%\bin\mysqladmin --user=root --host=localhost --port=56606 create memberdb

pause