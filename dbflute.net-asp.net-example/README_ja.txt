
# ========================================================================================
#                                                                                 Overview
#                                                                                 ========
The example project for ASP.NET and DBFlute.NET.


# ========================================================================================
#                                                                              Environment
#                                                                              ===========
[Oracle]
CREATE USER dfnetexdb IDENTIFIED BY dfnetexdb;
grant connect to dfnetexdb;
grant resource to dfnetexdb;
grant create view to dfnetexdb;
grant create synonym to dfnetexdb;
grant create database link to dfnetexdb;
grant create materialized view to dfnetexdb;

And after that, execute ReplaceSchema task.
