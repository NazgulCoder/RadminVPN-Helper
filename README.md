# RadminVPN-Helper
a simple unofficial troubleshooting tool for RadminVPN. Please keep in mind this tool is in beta-testing and is not approved by Famatech. I have received approval from Administrator to develope it and find volunteers to test it out.

![Capture](https://user-images.githubusercontent.com/85739956/128055563-34d5502c-4766-41e0-bcad-fe0f711d771e.PNG)

![Capture2](https://user-images.githubusercontent.com/85739956/128055406-99ca69f5-2cc2-4d1b-8c3f-e0d9f5b51d12.PNG)


### Instructions
-Run it possibly as Administrator <br/>
-You can quickly turn on/off firewall and kill RvControlSvc.exe process (service) <br/>
-Fix DNS according whether you are connected with Ethernet0 or Wi-Fi (Google DNS will be set and cache will be purged) <br/>
-Fix IPv6 DNS (it executes the following cmd commands) <br/>

```batch
netsh int ipv6 set teredo enterpriseclient
netsh interface teredo set state servername=win1910.ipv6.microsoft.com
```
-Reset Internet Settings will reset IPs, DNS, WinSock etc... <br/>
-Error 1603 Fixer will launch the Microsoft Troubleshooting tool to fix .msi packages from being installed or uninstalled <br/>
-Disable WinDefender (it won't kill WinDefender but will just help you shutting it down in case you have issues with RadminVPN) <br/>
-Cleaner will delete some junk temp files to help fixing your issues with RadminVPN <br/>
-Uninstaller will call the wmic command to execute a full uninstall of .msi packages

### Tips
Indeed it is strongly recommended to still follow the official guides from RadminTech Support on the official Discord. <br/>
<a href="https://discord.gg/BHsfTuXxMn" target="_blank">RadminVPN Official Discord</a> <br/>
Uninstalling with RevoUninstaller and a full system cleaning with CCleaner for files and registry is more than welcome <br/>

### Planned Features
Uninstall engine like RevoUninstaller to increase user-friendliness and make this tool "click and go" <br/>
Network Metric helper <br/>
Add a firewall helper to blacklist and whitelist IPs and Apps (so you can block users from public networks) <br/>

### Changelog
```
03/08/2021 V 1.1
Improved cleaner
Added Reset Internet Settings
Added Uninstaller with cycle to 1click remove all Radmin programs
```

### Download & VirusTotal Scan (for those who are not into coding)
<a href="https://github.com/NazgulCoder/RadminVPN-Helper/releases" target="_blank">Download</a> <br/>
<a href="https://www.virustotal.com/gui/file-analysis/NzAyOTgxOWVkNjVjNjQ3MjI3MzJiYTkxNzZiNjRlM2U6MTYyODAxMDA3Nw==/detection" target="_blank">VirusTotal Scan</a> <br/> 
They are false positive, in fact they are pretty unknown AntiViruses companies, however if you feel unsafe you can download the project and compile it yourself <br/> <br/>



Project is very simple and pretty basic coding skills were required, however this source may be helpful for somebody to learn something. <br/>
If you want to contribute to the project please do not hesitate to open a pull request or write me on Discord (you can find me on RadminVPN Discord posted above)

### License MIT - RadminVPN-Helper
Copyright 2021

Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated documentation files (the "Software"), to deal in the Software without restriction, including without limitation the rights to use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the Software, and to permit persons to whom the Software is furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
