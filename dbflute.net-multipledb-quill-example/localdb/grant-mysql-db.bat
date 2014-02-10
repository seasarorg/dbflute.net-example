cd %~p0
call _env.bat

echo GRANT ALL PRIVILEGES ON librarydb.* TO librarydb@localhost IDENTIFIED BY 'librarydb'; | %MYSQL_HOME%\bin\mysql --user=root --host=localhost --port=56606
echo GRANT ALL PRIVILEGES ON memberdb.* TO memberdb@localhost IDENTIFIED BY 'memberdb'; | %MYSQL_HOME%\bin\mysql --user=root --host=localhost --port=56606
echo GRANT ALL PRIVILEGES ON librarydb.* TO memberdb@localhost IDENTIFIED BY 'memberdb'; | %MYSQL_HOME%\bin\mysql --user=root --host=localhost --port=56606

pause