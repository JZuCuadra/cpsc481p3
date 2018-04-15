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
    /// Interaction logic for Home.xaml
    /// </summary>
    public partial class Home : Window
    {
        public Home()
        {
            InitializeComponent();
            this.menu.initIndex(0);
            for(int i = 0; i < 3; i++)
            {
                HomeCards card = new HomeCards();
                card.Height = 85;
                matchesGrid.Children.Add(card);

                HomeCards1 card1 = new HomeCards1();
                card1.Height = 85;
                matchesGrid.Children.Add(card1);

                HomeCards2 card2 = new HomeCards2();
                card2.Height = 85;
                matchesGrid.Children.Add(card2);

                HomeCards3 card3 = new HomeCards3();
                card3.Height = 85;
                matchesGrid.Children.Add(card3);

            }
 
        }
    }
}
