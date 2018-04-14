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
    public enum ProfileType {
        publicProfile,
        myProfile
    }
    /// <summary>
    /// Interaction logic for Profile.xaml
    /// </summary>
    public partial class Profile : Window
    {
        public Profile(ProfileType type)
        {
            InitializeComponent();
            this.menu.initIndex(2);
            if(type == ProfileType.publicProfile)
            {
                foreach (UIElement child in detailsGrid.Children)
                {
                    if (child is TextBox)
                    {
                        ((TextBox)child).IsReadOnly = true;
                    }
                }
                detailsGrid.Children.Remove(this.editPhotosBtn);
            }
            else
            {
                detailsGrid.Children.Remove(this.messageBtn);
            }
        }

        private void messageBtn_Click(object sender, RoutedEventArgs e)
        {
            Messaging messages = new Messaging();
            messages.Show();
            Window.GetWindow(this).Close();
        }
    }
}
