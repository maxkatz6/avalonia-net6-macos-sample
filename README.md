# avalonia-net6-macos-sample

Default Avalonia template from https://github.com/AvaloniaUI/avalonia-dotnet-templates works on macOS without problems.
But if you want to use build-in .NET bundling mechanism and have access to the macOS native APIs, you can choose a new "net6.0-macos" target framework.
Changes from the default template:
1. Change target framework from "net6.0" to "net6.0-macos". Multitarget or multiple projects can help with cross platfom.
2. Add `<RuntimeIdentifier>osx-x64</RuntimeIdentifier>`
3. Add `<SelfContained>true</SelfContained>` as macOS bundle can only be self-contained.
4. Add configured Info.plist file to your project. 
5. If you use macOS APIs, don't forget to call `NSApplication.Init();` from your `Main` method.
6. And finally change `OutputType` from `WinExe` to `Exe`.

After that you can build an app bundle:
`dotnet publish -c Release`

Or use native API:
```
var notification = new NSUserNotification();
notification.Title = "25 Minutes is up!";
notification.InformativeText = "Add your task to your activity log";
notification.SoundName = NSUserNotification.NSUserNotificationDefaultSoundName;
notification.HasActionButton = true;
NSUserNotificationCenter.DefaultUserNotificationCenter.DeliverNotification(notification);
```



Alternative approach (not shown in this repo) - continue to use generic "net6.0" target and use https://github.com/egramtel/dotnet-bundle to create an app bundle and https://www.nuget.org/packages/MonoMac.NetStandard/ to access the APIs.