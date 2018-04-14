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
            for(int i = 0; i < 5; i++)
            {
                RomanticCard card = new RomanticCard();
                card.Height = 300;
                card.makeMatch();
                matchesGrid.Children.Add(card);
            }
        }
    }
}
