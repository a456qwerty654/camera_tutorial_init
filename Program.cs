using System;
using SplashKitSDK;

public class Program
{
    public static void Main()
    {
        Window windowOne = new Window("Game window 1", 960, 520);
        Player playerOne = new Player(windowOne);
        do
        {
            SplashKit.ProcessEvents();
            playerOne.HandleInput();
            playerOne.StayOnWindow(windowOne);
            windowOne.Clear(Color.White);
            playerOne.Draw();
            windowOne.Refresh(60);

        } while ((!SplashKit.WindowCloseRequested(windowOne)) && (!playerOne.Quit));
    }
}
