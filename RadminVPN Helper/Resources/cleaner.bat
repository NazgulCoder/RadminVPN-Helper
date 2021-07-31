@echo off

echo RadminVPN Helper Cleaner

timeout 2

DEL "C:\Windows\Temp\*.*" /F /Q /S

DEL "C:\Users\%USERNAME%\AppData\Local\Temp\*.*" /F /Q /S

DEL "C:\Windows\Prefetch\*.*" /F /Q /S

echo Job Finished at %time%

pause
exit