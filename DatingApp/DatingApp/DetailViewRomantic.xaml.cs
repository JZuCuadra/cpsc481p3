using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace DatingApp
{
    /// <summary>
    /// Interaction logic for Login.xaml
    /// </summary>
    public partial class DetailViewRomantic : Window
    {
        public DetailViewRomantic()
        {
            InitializeComponent();

            Grid.SetRow(ProfilePicture, 0);
            Grid.SetRow(NameAge_txt, 1);

            int sections = 10;

            for(int i = 0; i < sections; i++)
            {
                //Section Label
                RowDefinition rowDef = new RowDefinition();
                rowDef.Height = GridLength.Auto;
                DetailPane.RowDefinitions.Add(rowDef);
                TextBlock text = new TextBlock();
                text.Text = "Questionaire Response " + (i + 1) + "\r\n" +
                    "This is the response this user gave during the questionaire. " +
                    "One hopes they were telling the truth. Now it makes even less sense. " +
                    "Indeed, only those who live in...";
                text.Width = 480;
                text.TextWrapping = TextWrapping.Wrap;
                text.Margin = new Thickness(20, 15, 20, 15);
                text.FontSize = 24;
                text.FontFamily = new FontFamily("Roboto");
                text.Foreground = new SolidColorBrush(Color.FromScRgb(1,1,1,1));
                DetailPane.Children.Add(text);
                Grid.SetRow(text, i + 2);
            }
        }
    }
}
