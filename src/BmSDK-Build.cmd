@echo off

set CWD=%cd%
echo %CWD%

call "C:\Program Files\Microsoft Visual Studio\2022\Community\VC\Auxiliary\Build\vcvars32.bat"
echo:

:: Build .sln
msbuild.exe "../BmSDK.sln" /p:Configuration=Debug /p:Platform=x86 /nologo /verbosity:m