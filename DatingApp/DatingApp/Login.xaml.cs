using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading;
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
    public partial class Login : Window
    {
        public Login()
        {
            InitializeComponent();
            this.ErrorTxt.Opacity = 0d;
        }
        
        private void Login_Click(object sender, RoutedEventArgs e)
        {
            if (String.IsNullOrEmpty(UsernameTxtBox.Text) || String.IsNullOrEmpty(PasswordTxtBox.Password))
            {
                this.ErrorTxt.Opacity = 1d;
                return;
            }
            Home home = new Home();
            home.Show();
            Window.GetWindow(this).Close();
        }

        private void Register_Click(object sender, RoutedEventArgs e)
        {
            Register reg = new Register();
            reg.Show();
            Window.GetWindow(this).Close();
        }

        private void OAuth_Click(object sender, RoutedEventArgs e)
        {
            Home home = new Home();
            home.Show();
            Window.GetWindow(this).Close();
        }
    }
}
