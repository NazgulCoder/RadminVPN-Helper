# RadminVPN-Helper
a simple unofficial troubleshooting tool for RadminVPN

![Capture](https://user-images.githubusercontent.com/85739956/127749270-43f70628-4eb1-406c-b042-a58092f68788.PNG)

### Instructions
-Run it possibly as Administrator <br/>
-You can quickly turn on/off firewall and kill RvControlSvc.exe process (service) <br/>
-Fix DNS according whether you are connected with Ethernet0 or Wi-Fi (Google DNS will be set and cache will be purged) <br/>
-Fix IPv6 DNS (it executes the following cmd commands) <br/>

```batch
netsh int ipv6 set teredo enterpriseclient
netsh interface teredo set state servername=win1910.ipv6.microsoft.com
```

-Error 1603 Fixer will launch the Microsoft Troubleshooting tool to fix .msi packages from being installed or uninstalled <br/>
-Disable WinDefender (it won't kill WinDefender but will just help you shutting it down in case you have issues with RadminVPN) <br/>
-Cleaner will delete some junk temp files to help fixing your issues with RadminVPN <br/>

### Tips
Indeed it is strongly recommended to still follow the official guides from RadminTech Support on the official Discord. <br/>
<a href="https://discord.gg/BHsfTuXxMn" target="_blank">RadminVPN Official Discord</a> <br/>
Uninstalling with RevoUninstaller and a full system cleaning with CCleaner for files and registry is more than welcome <br/>

### Planned Features
Uninstall engine like RevoUninstaller to increase user-friendliness and make this tool "click and go" <br/>
Improve the batch cleaner <br/>
Add a firewall helper to blacklist and whitelist IPs and Apps (so you can block users from public networks) <br/>

Project is very simple and pretty basic coding skills were required, however this source may be helpful for somebody to learn something. <br/>
If you want to contribute to the project please do not hesitate to open a pull request or write me on Discord (you can find me on RadminVPN Discord posted above)
