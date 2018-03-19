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
    /// Interaction logic for PersonalityTest.xaml
    /// </summary>
    public partial class PersonalityTest : Window
    {
        public PersonalityTest()
        {
            InitializeComponent();
            this.NextButton.Click += NextButton_Click;

            PreferencesComboBox.Items.Add("Homosexual");
            PreferencesComboBox.Items.Add("Heterosexual");
            PreferencesComboBox.Items.Add("Bisexual");

            RelationComboBox.Items.Add("Commited Relationship");
            RelationComboBox.Items.Add("Uncommited Relationship");
            RelationComboBox.Items.Add("Frienship");
        }

        private void NextButton_Click(object sender, RoutedEventArgs e)
        {
            this.TestCanvas.Visibility = Visibility.Hidden;
            // add functionality here
        }
    }
}
