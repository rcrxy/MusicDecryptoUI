namespace MusicDecrypto.Maui;

public class AppShell : Shell {
   public AppShell() {
      Title = "Music Decrypto";
      FlyoutBehavior = FlyoutBehavior.Disabled;

      Items.Add(new ShellContent {
         Route = "MainPage",
         ContentTemplate = new DataTemplate(static () => new MainPage())
      });
   }
}
