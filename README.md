# MyOrchardThemes

1.
Clone repository to your local machine.

`git clone https://github.com/YaoaY/MyOrchardThemes.git`

2.
Go to the solution folder,and run `npm install` first.
Because OrchardCore needs gulp script to copy `assets` things(css,js) of each module to their respective `Content` folders.

`D:\MyGitHub\MyOrchardThemes>npm install`

In our case,`Themes.Web` project has an 'assets' folder needs to deal.So we need to run the `build` script once to make sure that our js and css files in assets folder are copied to the `Content` folder.

```
D:\MyGitHub\MyOrchardThemes>npm run build

> myorchardthemes@1.0.0 build D:\MyGitHub\MyOrchardThemes
> gulp build

[12:11:09] Using gulpfile D:\MyGitHub\MyOrchardThemes\gulpfile.js
[12:11:09] Starting 'build'...
[12:11:11] Finished 'build' after 1.78 s
```

3.
Go to the `OrchardCore.ResourceX` folder ,and run `npm install` again.
Because this module uses npm to manage js/css libraries.

`D:\MyGitHub\MyOrchardThemes\src\OrchardCore.ResourceX>npm install`

And of course, we need to run a gulp script to pickup useful files from `node_modules` and throw them into our `Content` folder.

```
D:\MyGitHub\MyOrchardThemes\src\OrchardCore.ResourceX>npm run copy

> orchardcore.resoucesex@1.0.0 copy D:\MyGitHub\MyOrchardThemes\src\OrchardCore.ResourceX
> gulp copy:content

[12:04:50] Using gulpfile D:\MyGitHub\MyOrchardThemes\src\OrchardCore.ResourceX\gulpfile.js
[12:04:50] Starting 'clean:content'...
[12:04:50] Finished 'clean:content' after 8.86 ms
[12:04:50] Starting 'copy:content'...
Main file is not defined for the module font-awesome
[12:04:50] Finished 'copy:content' after 73 ms
```

4.
Now everything is ready. Go to the `Themes.Web` folder, and run `dotnet run`.
```
D:\MyGitHub\MyOrchardThemes\src\Themes.Web>dotnet run
info: Microsoft.AspNetCore.DataProtection.KeyManagement.XmlKeyManager[0]
      User profile is available. Using 'C:\Users\Yong\AppData\Local\ASP.NET\DataProtection-Keys' as key repository and Windows DPAPI to encrypt keys at rest.
Hosting environment: Development
Content root path: D:\MyGitHub\MyOrchardThemes\src\Themes.Web
Now listening on: http://localhost:14342
Application started. Press Ctrl+C to shut down.
```

Open the url in your browser,and login to admin dashboard.
![Theme.png](https://raw.githubusercontent.com/YaoaY/MyOrchardThemes/master/src/TheAdminINSPINIA/Theme.png)


