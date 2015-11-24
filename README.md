# Server 2012 Shadow Utility
This simple utility allows an administrator to easily control sessions and shadow users on a 2012 Terminal Server.
Since Microsoft has moved Shadow into Server Manager, only Administrators who have access to your whole environment (Brokers, Gateways, Session Hosts ect) can shadow users.
There have been a number of Powershell scripts for Shadowing outside of Server Manager, however this utility performs the same operation inside Windows Forms, listing sessions and allowing operations inside the GUI

## How to use this Utility
- Edit the servers.json file to include the names of your TS Session Host servers, and place it in the same directory as the executable
- Run the executable as a user which is an admin on all the TS Session Host servers you have entered in the file

Administration rights on other TS Infrastructure hosts (Such as Brokers) is not required.

**Shadowing without Admin Rights**

You can grant access via WMIC to Shadow to a user or group using the following command:

wmic /namespace:\\root\CIMV2\TerminalServices PATH Win32_TSPermissionsSetting WHERE (TerminalName="RDP-Tcp") CALL AddAccount "domain\accountname",2

It is possible the account will require access to enumerate users on the Session Host servers as well.
