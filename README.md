## Polaris ArenaNet GuildWars 2
Please notice this project is not anymore on development. Few time after we published our API wrapper for C#, ArenaNet decided to update their API for GW2, the updated API has breaking changes and we simply decided not to restart the development. 
This project is just a reference for the API client we implemented at that time.

## Project Description
This project provides wrapper libraries that provide high-level access to the Guild Wars 2 API

## Featuring

## Our library features:
Supporting a custom Http Client
Supporting a custom JSON derializer.
Everything is backed on interfaces, thus providing mock implementation or static content should be easy to implement (and handle through a dependency injection framework).
It has been build on PCL (Portable Class Library), this effectively means that you could use it on almost any .NET project (e.g. Windows Phone 7.x, Windows Phone 8.x, Desktop (WPF, MFC, Win32), Windows Store 8 or 8.1 as well as PCL is supported).

## Road map
Basically I am a human, and there is only one of me. This project is interesting and anyone is welcome to support it. The code in here is not the final repository, however I'll be deploying in here updates from my private repository. 
So, why?
Well It started with our first application: KUMQUAT. Initially on Windows Phone 8, then Windows Phone 7 and finally on Windows Store. All of them are using the same library client. Our project KUMQUAT has been released on three different platforms. 
Here are the links where you can see our app and different screenshots:

## Windows Store
http://apps.microsoft.com/windows/app/kumquat/8a692da9-1635-4dcf-ad54-e467259fb56a

## Windows Phone
http://www.windowsphone.com/s?appid=c4cf5870-0686-4980-b7b7-84f6f2c5d8c1

## How to use it?

Simple get the nuget packages, for example using the PowerShell console:

`PM> Install-Package Polaris.ArenaNet.GuildWars2.HttpClient`

`PM> Install-Package Polaris.ArenaNet.GuildWars2.Json`

`PM> Install-Package Polaris.ArenaNet.GuildWars2`

Then you could do the following:

`var gw2WebClient = new ArenaNet.GuildWars2.Gw2WebClient(ArenaNet.GuildWars2.Gw2HttpClient.Instance, ArenaNet.GuildWars2.Gw2JsonDeserializer.Instance);`
`var worlds = await gw2WebClient.GetWorlds("en");`


Simple, right? That's the idea.
Best of lucks!
