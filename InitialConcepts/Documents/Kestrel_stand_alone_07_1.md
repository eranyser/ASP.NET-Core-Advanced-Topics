# Kestrel as the main Web Server

**Kestrel can be used as the internet facing web server** that process the incoming HTTP requests directly.

In this model we are not using an external web server. 

When we run the ASP.NET core application using the .NET core CLI, Kestrel is the only web server that is used to handle and process the incoming HTTP request. by default it ignores the hosting setting we specified in the csproj file. So the AspNetCoreHostingModel element value in the csproj file is ignored.

![Stand-alone Kestrel](./images/kestrel_stand_alone.png)

| | | |
|-|-|-|
[![Home](../../Documents/Images/home_button.svg)](../../README.md) | [![Previous](../../Documents/Images/back_button.svg)](./Kestrel_07.md) | [![Next](../../Documents/Images/next_button.svg)](./Kestrel_with_reverse_proxy_07_02.md) |
| | |