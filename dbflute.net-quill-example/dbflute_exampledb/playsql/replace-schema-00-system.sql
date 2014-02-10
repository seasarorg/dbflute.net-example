-- #df:changeUser(system)#
-- #df:checkUser()#
CREATE DATABASE /*$mainUser*/;
GRANT ALL PRIVILEGES ON /*$mainDatabase*/.* TO /*$mainUser*/ IDENTIFIED BY '/*$mainPassword*/';
