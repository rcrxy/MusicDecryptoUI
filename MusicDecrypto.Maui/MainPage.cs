namespace MusicDecrypto.Maui;

using CommunityToolkit.Maui.Markup;

public class MainPage : ContentPage {
   int _count = 0;
   readonly Button CounterBtn;

   public MainPage() {
      CounterBtn = new Button {
         Text = "Click me"
      }
         .SemanticHint("Counts the number of times you click")
         .FillHorizontal();
      CounterBtn.Clicked += OnCounterClicked;

      Content = new ScrollView {
         Content = new VerticalStackLayout {
            Spacing = 25,
            Children = {
               new Image {
                  Source = "dotnet_bot.png",
                  Aspect = Aspect.AspectFit
               }
                  .Height(185)
                  .SemanticDescription("dot net bot in a race car number eight"),

               new Label {
                  Text = "Hello, World!",
                  Style = (Style)Application.Current!.Resources["Headline"]
               }
                  .SemanticHeadingLevel(SemanticHeadingLevel.Level1),

               new Label {
                  Text = "Welcome to \n.NET Multi-platform App UI",
                  Style = (Style)Application.Current!.Resources["SubHeadline"]
               }
                  .SemanticHeadingLevel(SemanticHeadingLevel.Level2)
                  .SemanticDescription("Welcome to dot net Multi platform App U I"),

               CounterBtn
            }
         }.Paddings(30, 0, 30, 0)
      };
   }

   private void OnCounterClicked(object? sender, EventArgs e) {
      _count++;

      if (_count == 1)
         CounterBtn.Text = $"Clicked {_count} time";
      else
         CounterBtn.Text = $"Clicked {_count} times";

      SemanticScreenReader.Announce(CounterBtn.Text);
   }
}
