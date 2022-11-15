using Avalonia.Controls;
using Avalonia.Interactivity;
using Foundation;

namespace avalonia_net6_macos_sample;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }

    public void Button_Clicked(object? sender, RoutedEventArgs args)
    {
        var notification = new NSUserNotification();
        notification.Title = "25 Minutes is up!";
        notification.InformativeText = "Add your task to your activity log";
        notification.SoundName = NSUserNotification.NSUserNotificationDefaultSoundName;
        notification.HasActionButton = true;
        NSUserNotificationCenter.DefaultUserNotificationCenter.DeliverNotification(notification);
    }
}