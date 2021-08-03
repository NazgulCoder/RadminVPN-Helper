@echo off

echo RadminVPN Helper Cleaner

timeout 2

DEL "C:\Windows\Temp\*.*" /F /Q /S

DEL "C:\Users\%USERNAME%\AppData\Local\Temp\*.*" /F /Q /S

DEL "C:\Windows\Prefetch\*.*" /F /Q /S

::DEL "%windir%\system32\dllcache\*.*" /F /Q /S

::DEL "%SysteDrive%\Temp\*.*" /F /Q /S

DEL "%USERPROFILE%\Local Settings\Temp\*.*" /F /Q /S

::DEL "%USERPROFILE%\Local Settings\Temporary Internet Files\*.*" /F /Q /S

echo Job Finished at %time%

pause
exit