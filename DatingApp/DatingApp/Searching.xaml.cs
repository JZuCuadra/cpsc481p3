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
using System.Windows.Media.Effects;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace DatingApp
{
    /// <summary>
    /// Interaction logic for Searching.xaml
    /// </summary>
    public partial class Searching : Window
    {
        DispatcherTimer timer = new DispatcherTimer();

        public Searching()
        {
            InitializeComponent();

            timer.Interval = new TimeSpan(0, 0, 0, 0, 17);
            timer.Tick += new EventHandler(timer_Tick);
            timer.Start();

            Thickness margin = new Thickness(0, 245, 0, 100);

            SearchScrollPane.Margin = margin;
            int numCards = 30;
            int cardGap = 20;
            SearchScrollPane.Height = numCards*(380+cardGap) + 120;

            for (int i = 0; i<numCards; i++)
            {
                ProfileCard card = new ProfileCard();
                card.Name = "Profile_" + i;
                card.MouseLeftButtonDown += new MouseButtonEventHandler(mouseClick);
                SearchScrollPane.Children.Add(card);
                RowDefinition rowDef = new RowDefinition();
                rowDef.Height = GridLength.Auto;
                SearchScrollPane.RowDefinitions.Add(rowDef);
                Grid.SetRow(card, i);
                margin = new Thickness(0, cardGap/2, 0, cardGap/2);
                card.Margin = margin;

                //this.SearchScrollPane.RowDefinitions.ElementAt(i);
            }
        }

        private void mouseClick(object sender, EventArgs e)
        {
            SearchScreen.Children.Add(new MatchAnimation());

            (sender as ProfileCard).MouseLeftButtonDown -= mouseClick;
        }

        void timer_Tick(object sender, EventArgs e)
        {
            foreach(ProfileCard p in SearchScrollPane.Children)
            {
                BlurEffect blur = new BlurEffect();

                double ycoord = Math.Abs(255 - p.TransformToAncestor(Application.Current.MainWindow).Transform(new Point(0, 0)).Y);
                double crispZone = 50;
                if (ycoord < crispZone)
                    blur.Radius = 0;
                else
                    blur.Radius = (ycoord-crispZone)*0.025;

                p.RomanticCard.Effect = blur;
                p.RomanticCard.Opacity = 1 - blur.Radius*0.05;
            }
        }
    }
}
