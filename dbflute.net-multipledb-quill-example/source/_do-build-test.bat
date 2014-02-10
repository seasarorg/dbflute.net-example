@echo off
setlocal
%~d0
cd %~p0

@set PATH=%windir%\Microsoft.NET\Framework\v4.0.30319;%PATH%

echo ...Building DBFlute.NET MultipleDB Quill Example

msbuild DfExample.sln /p:Configuration=Release /t:Clean;Rebuild

endlocal
