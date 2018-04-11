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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace DatingApp
{
    /// <summary>
    /// Interaction logic for HomeCards.xaml
    /// </summary>
    public partial class HomeCards : UserControl
    {
        public HomeCards()
        {
            InitializeComponent();
            this.buttonHomeCard.Click += ButtonHomeCard_Click;   
        }

        private void ButtonHomeCard_Click(object sender, RoutedEventArgs e)
        {
            Window window = new Messaging();
            window.Show();
            Window.GetWindow(this).Close();
        }
    }
}

