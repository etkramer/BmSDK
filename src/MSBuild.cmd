@echo off

set FILEPATH=%1

for /f "tokens=1,* delims= " %%a in ("%*") do set OTHERARGS=%%b

:: Setup VS environment
call "C:\Program Files\Microsoft Visual Studio\2022\Community\VC\Auxiliary\Build\vcvars32.bat"
echo:

:: Build .sln
msbuild.exe "%FILEPATH%" %OTHERARGS% /p:Configuration=Debug /p:Platform=x86 /nologo /verbosity:m
