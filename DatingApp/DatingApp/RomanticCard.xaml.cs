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
            Random rand = new Random();
            InitializeComponent();
            nameHeader.Text = Profile.publicNames[rand.Next(0, Profile.publicNames.Length)];
            age.Text = Profile.publicAges[rand.Next(0, Profile.publicAges.Length)].ToString();
            gender.Text = Profile.publicGenders[rand.Next(0, Profile.publicGenders.Length)];
            job.Text = Profile.publicJobs[rand.Next(0, Profile.publicJobs.Length)];
            education.Text = Profile.publicEducations[rand.Next(0, Profile.publicEducations.Length)];
            bio.Text = Profile.publicLoremIpsum.Aggregate((string a, string b) => { return a + b; });
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
