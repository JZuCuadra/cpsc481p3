using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace DatingApp
{
    /// <summary>
    /// Interaction logic for Register.xaml
    /// </summary>
    public partial class Register : Window
    {
        public Register()
        {
            InitializeComponent();
            ErrorTxt.Opacity = 0;
        }

        private void regBtn_Click(object sender, RoutedEventArgs e)
        {
            string[] fields = {UserNameTxtBox.Text, PasswordTxtBox.Password, RepeatPassTxtBox.Password,
                FirstNameTxtBox.Text, LastNameTxtBox.Text};
            if(fields.Contains(null) || fields.Contains(""))
            {
                ErrorTxt.Opacity = 1d;
                return;
            }
            else if(PasswordTxtBox.Password != RepeatPassTxtBox.Password)
            {
                ErrorTxt.Text = "Passwords must match";
            }
            Survey survey = new Survey();
            survey.Show();
            Window.GetWindow(this).Close();
        }

        private void AddPhotoBtn_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Image Files(*.BMP; *.JPG; *.GIF)| *.BMP; *.JPG; *.GIF | All files(*.*) | *.*";
            if(dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                image.ImageSource = new BitmapImage(new Uri(dialog.FileName));
            }
        }

        private void loadPictures(string path)
        {
            //imageListView.Items.Clear();
            DirectoryInfo dir = new DirectoryInfo(path);
            Regex rgx = new Regex(@"bmp|png|jpg|gif");
            foreach (FileInfo file in dir.GetFiles())
            {
                if (rgx.Match(file.Extension).Success)
                {
                    Image image = new Image();
                    image.Height = 100;
                    image.Width = 100;
                    image.Source = new BitmapImage(new Uri(file.FullName));
                    //imageListView.Items.Add(image);
                }
            }
        }
    }
}
