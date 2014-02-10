
cd %~p0
call _env.bat

%MYSQL_HOME%\bin\mysql --user=root --host=localhost --port=53306 --default-character-set=sjis

pause