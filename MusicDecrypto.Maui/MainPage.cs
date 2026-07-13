namespace MusicDecrypto.Maui;

using CommunityToolkit.Maui.Markup;
using Microsoft.Maui.Controls.Shapes;
using static CommunityToolkit.Maui.Markup.GridRowsColumns;

public partial class MainPage : ContentPage {
   static readonly double _boxRadius = 5;
   static readonly Color _backgroundColor = new(30, 34, 36);
   static readonly Thickness _margin = new(5);
   static readonly Thickness _padding = new(5);
   static readonly Color _stroke = Colors.LightGray;
   static readonly double _strokeThickness = 0.25;

   public MainPage() {
      Content = new Grid {
         Padding = _padding,

         RowDefinitions = Rows.Define(
            Stars(2), Stars(6), Stars(2)
         ),
         Children = {
            new Grid {
               ColumnDefinitions = Columns.Define(Star, Star),
               Children = {
                  new Border {
                     BackgroundColor = _backgroundColor,
                     Margin = _margin,
                     Padding = _padding,
                     Stroke = _stroke,
                     StrokeThickness = _strokeThickness,
                     StrokeShape = new RoundRectangle {
                        CornerRadius = new CornerRadius(_boxRadius),
                     },

                     Content = new Label {
                        Text = "123"
                     }
                  }.Column(0),

                  new Border {
                     BackgroundColor = _backgroundColor,
                     Margin = _margin,
                     Padding = _padding,
                     Stroke = _stroke,
                     StrokeThickness = _strokeThickness,
                     StrokeShape = new RoundRectangle {
                        CornerRadius = new CornerRadius(_boxRadius),
                     },

                     Content = new Label {
                        Text = "456"
                     }
                  }.Column(1)
               }
            }.Row(0),

            new Border {
               BackgroundColor = _backgroundColor,
               Margin = _margin,
               Padding = _padding,
               Stroke = _stroke,
               StrokeThickness = _strokeThickness,
               StrokeShape = new RoundRectangle {
                  CornerRadius = new CornerRadius(_boxRadius),
               },

               Content = new ScrollView {
                  Content = new VerticalStackLayout {
                     Children = {
                        new Label { Text = "中间内容" }
                     }
                  }
               },
            }.Row(1),

            new Border {
               BackgroundColor = _backgroundColor,
               Margin = _margin,
               Padding = _padding,
               Stroke = _stroke,
               StrokeThickness = _strokeThickness,
               StrokeShape = new RoundRectangle {
                  CornerRadius = new CornerRadius(_boxRadius),
               },

               Content = new Label {
                     Text = "底部"
                  }
               }.Row(2)
            }
      };
   }
}
