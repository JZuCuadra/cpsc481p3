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
    /// Interaction logic for RomanticCard.xaml
    /// </summary>
    public partial class RomanticCard : UserControl
    {
        private bool isMatched { get; set; }
        public RomanticCard()
        {
            InitializeComponent();
        }

        public void makeMatch()
        {
            if (isMatched) return;
            Button btn = new Button();
            btn.Style = (Style)FindResource("MaterialDesignFlatButton");
            TextBlock text = new TextBlock();
            Canvas.SetTop(btn, 256d);
            Canvas.SetLeft(btn, 150d);
            text.Text = "VIEW PROFILE";
            btn.Content = text;
            contentCanvas.Children.Add(btn);
            btn.Click += message_Click;
        }

        private void message_Click(object sender, RoutedEventArgs e)
        {
            Window window = new Profile(ProfileType.publicProfile);
            window.Show();
            Window.GetWindow(this).Close();
        }
    }
}
