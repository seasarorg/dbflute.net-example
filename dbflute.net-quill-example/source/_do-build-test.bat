@echo off
setlocal
%~d0
cd %~p0

@set PATH=%windir%\Microsoft.NET\Framework\v4.0.30319;%PATH%

echo ...Building DBFlute.NET Basic Example
call ..\koropokkur.net\build\2010\VSArrangeConsole.exe DfExample.sln ALL ..\koropokkur.net\build\2010\VSArrange.config
msbuild DfExample.sln /p:Configuration=Release /t:Clean;Rebuild

endlocal
