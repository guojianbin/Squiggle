"%WINDIR%\Microsoft.NET\Framework\v4.0.30319\msbuild" "%~dp0\..\Squiggle.sln" /p:Configuration=Release /t:Clean,Build /v:M /fl /flp:LogFile="%~dp0\msbuild.log";Verbosity=Normal /nr:false