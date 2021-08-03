@echo off

netsh int ip reset

ipconfig /release

ipconfig /all

ipconfig /flushdns

ipconfig /renew

netsh int ip set dns

netsh winsock reset

echo Internet Settings have been resetted correctly. Please restart your Computer

pause
exit