echo off

SET APP_NAME=Test.exe
SET ILMERGE_BUILD=Release
SET ILMERGE_VERSION=3.0.41
SET ILMERGE_PATH=%USERPROFILE%\.nuget\packages\ilmerge\%ILMERGE_VERSION%\tools\net452

echo Merging %APP_NAME% ...

"%ILMERGE_PATH%"\ILMerge.exe Bin\%ILMERGE_BUILD%\%APP_NAME%  ^
  /lib:Bin\%ILMERGE_BUILD%\ ^
  /out:%APP_NAME% ^
  Newtonsoft.Json.dll ^
  BouncyCastle.Crypto.dll ^
  CommonServiceLocatior.dll 
:Done
dir %APP_NAME%