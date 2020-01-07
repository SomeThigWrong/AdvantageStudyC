@echo off
rem A batch file for AdvantageStudyingC.exe
rem which captures the app's return value
.\AdvantageStudyingC\bin\debug
@if "%ERRORLEVEL%" == "0" goto success
:fail
echo This application has failed!
echo return value = %ERRORLEVEL%
goto end
:success
echo This application has succeeded!
echo return value = %ERRORLEVEL%
goto end
:end
echo All Done.