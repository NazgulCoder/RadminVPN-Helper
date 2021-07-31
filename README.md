# RadminVPN-Helper
a simple unofficial troubleshooting tool for RadminVPN

![Capture](https://user-images.githubusercontent.com/85739956/127749270-43f70628-4eb1-406c-b042-a58092f68788.PNG)

### Instructions
-Run it possibly as Administrator
-You can quickly turn on/off firewall and kill RvControlSvc.exe process (service)
-Fix DNS according whether you are connected with Ethernet0 or Wi-Fi
-Fix IPv6 DNS (it executes the following cmd commands)

```batch
netsh int ipv6 set teredo enterpriseclient
netsh interface teredo set state servername=win1910.ipv6.microsoft.com
```
