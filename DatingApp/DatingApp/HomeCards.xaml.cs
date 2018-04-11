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
        private bool isMatched { get; set; }
        public HomeCards()
        {
            InitializeComponent();
            this.buttonHomeCard.Click += ButtonHomeCard_Click;    

        }

        private void ButtonHomeCard_Click(object sender, RoutedEventArgs e)
        {
            buttonHomeCard.Visibility = Visibility.Hidden;
            Window window = new Messaging();
            window.Show();
            Window.GetWindow(this).Close();
        }

        public void makeMatch()
        {
            /*if (isMatched) return;
            Button btn = new Button();
            btn.Style = (Style)FindResource("MaterialDesignFlatButton");
            TextBlock text = new TextBlock();
            Canvas.SetTop(btn, 15d);
            Canvas.SetLeft(btn, 300d);
            text.Text = "VIEW PROFILE";
            btn.Content = text;
            contentCanvas.Children.Add(btn);
            btn.Click += message_Click;*/
        }

        private void message_Click(object sender, RoutedEventArgs e)
        {
            Window window = new Profile(ProfileType.publicProfile);
            window.Show();
            Window.GetWindow(this).Close();
        }
    }
}

