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
    /// Interaction logic for MenuOverlay.xaml
    /// </summary>
    public partial class MenuOverlay : UserControl
    {
        private int navIndex;
        public MenuOverlay()
        {
            InitializeComponent();
            
        }

        public void initIndex(int i)
        {
            this.navIndex = i;
            this.navBar.SelectedIndex = i < -1 || i > 2 ? -1 : i;
            this.navBar.SelectionChanged += navBar_SelectionChanged;
        }

        private void navBar_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            int selected = this.navBar.SelectedIndex;
            if (selected == navIndex) return;
            Window window;
            switch (selected)
            {
                case 0:
                    window = new Home();
                    break;
                case 1:
                    window = new CompassSearch();
                    break;
                case 2:
                    window = new Profile(ProfileType.myProfile);
                    break;
                default:
                    window = null;
                    break;
            }
            if(window != null)
            {
                window.Show();
                Window.GetWindow(this).Close();
            }
        }

        private void settingsBtn_Click(object sender, RoutedEventArgs e)
        {
            Window window = Window.GetWindow(this);
            if(!(window is Settings))
            {
                Settings settings = new Settings();
                settings.Show();
                window.Close();
            }
        }
    }
}
