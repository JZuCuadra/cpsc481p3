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
using MaterialDesignColors;
using MaterialDesignThemes;

namespace DatingApp
{
    public enum ProfileType
    {
        publicProfile,
        myProfile
    }

    public enum PublicProfile
    {
        SAMUEL_GIBBONS,
        HANNAH_DELANO,
        SEBASTIAN_FORMAN,
        ASHLEY_DAVIDSON,
    }

    /// <summary>
    /// Interaction logic for Profile.xaml
    /// </summary>
    public partial class Profile : Window
    {
        //These should be set by the initial quiz. Some should be editable thereafter
        public string personalName = "John Doe";
        public int personalAge = 20;
        public string personalGender = "Male";
        public string personalJob = "Enter Your Job/Occupation Here...";
        public string personalEducation = "Enter Your Education Here...";
        public string personalBio = "Write Your Bio Here...";

        //Use the PublicProfile enum to target the desired info from these arrays
        public static string[] publicNames = 
        {
            "Samuel Gibbons",
            "Hannah Delano",
            "Sebastian Forman",
            "Ashley Davidson"
        };
        
        public static int[] publicAges =
        {
            22,
            24,
            19,
            20
        };
        
        public static string[] publicGenders =
        {
            "Male",
            "Female",
            "Male",
            "Female"
        };
        
        public static string[] publicJobs =
        {
            "Chemical Engineering Student",
            "Criminal Law Student",
            "Performing Arts Student",
            "Biomedical Engineering Student"
        };
        
        public static string[] publicEducations =
        {
            "BEng Chemical Engineering",
            "LLB Criminal Law",
            "BA Performing Arts",
            "BSc Biomedical Technology Engineering"
        };

        //attr:profile is optional, set to view a particular public profile
        public Profile(ProfileType type, PublicProfile profile = PublicProfile.SAMUEL_GIBBONS)
        {
            InitializeComponent();
            menu.initIndex(2);
            if(type == ProfileType.publicProfile)
            {
                foreach (UIElement child in detailsGrid.Children)
                {
                    if (child is TextBox)
                    {
                        ((TextBox)child).IsReadOnly = true;
                        MaterialDesignThemes.Wpf.TextFieldAssist.SetDecorationVisibility(child, Visibility.Hidden);
                        ((TextBox)child).BorderThickness = new Thickness(0);
                    }
                }
                detailsGrid.Children.Remove(this.editPhotosBtn);

                name.Text = publicNames[(int)profile];
                age.Text = publicAges[(int)profile].ToString();
                gender.Text = publicGenders[(int)profile];
                job.Text = publicJobs[(int)profile];
                education.Text = publicEducations[(int)profile];

                bio.Text = "Nunc nec hendrerit massa. Maecenas ut arcu nisi. " +
                    "Aliquam eu leo ut risus lacinia consequat id eget ipsum. " +
                    "Curabitur rutrum nunc porta ipsum egestas eleifend. " +
                    "Nunc vulputate lacinia sapien, in imperdiet augue commodo non.\r\n\r\n" +
                    "Lorem ipsum dolor sit amet, consectetur adipiscing elit. " +
                    "Mauris gravida nec neque non efficitur. " +
                    "Etiam bibendum lectus metus, nec pharetra lacus facilisis ut. " +
                    "Nam urna massa, consequat sit amet augue quis, iaculis placerat risus. " +
                    "Quisque mollis eget nisi sed aliquam. \r\n\r\n" +
                    "Maecenas efficitur tempus velit sed pharetra. " +
                    "Sed bibendum nisl eget magna ultrices luctus. " +
                    "Etiam sed ante eu enim elementum fermentum laoreet eget erat. " +
                    "Pellentesque sit amet commodo mi, ut pulvinar libero. " +
                    "Duis viverra consequat sapien, sed molestie lorem maximus id. " +
                    "Nulla et urna quam.";
            }
            else
            {
                detailsGrid.Children.Remove(messageBtn);
                name.Text = personalName;
                name.IsReadOnly = false;
                
                age.Text = personalAge.ToString();
                gender.Text = personalGender;
                age.IsReadOnly = true;
                MaterialDesignThemes.Wpf.TextFieldAssist.SetDecorationVisibility(age, Visibility.Hidden);
                age.BorderThickness = new Thickness(0);
                gender.IsReadOnly = true;
                MaterialDesignThemes.Wpf.TextFieldAssist.SetDecorationVisibility(gender, Visibility.Hidden);
                gender.BorderThickness = new Thickness(0);
                
                job.Text = personalJob;
                education.Text = personalEducation;
                bio.Text = personalBio;
            }
        }

        //Call this before navigating to another page
        public void savePersonalProfileChanges()
        {
            personalName = name.Text;
            personalJob = job.Text;
            personalEducation = education.Text;
            personalBio = bio.Text;
        }

        private void messageBtn_Click(object sender, RoutedEventArgs e)
        {
            savePersonalProfileChanges();
            Messaging messages = new Messaging();
            messages.Show();
            Window.GetWindow(this).Close();
        }
    }
}
