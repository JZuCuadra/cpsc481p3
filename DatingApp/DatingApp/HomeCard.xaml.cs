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
        }

        private void image_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            Window window = new Profile(ProfileType.publicProfile, PublicProfile.ASHLEY_DAVIDSON);
            window.Show();
            Window.GetWindow(this).Close();
        }

        private void content_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            Window window = new Messaging();
            window.Show();
            Window.GetWindow(this).Close();
        }
    }
}

