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
    /// Interaction logic for Survey.xaml
    /// </summary>
    public partial class Survey : Window
    {
        private List<Tuple<string, string>> questions { get; set; }
        private int index;

        String [] questionList = new String[] {
            " \nDo you like the taste of beer? ",
            " \nDo you like horror movies? ",
            " \nHave you ever traveled around another country alone? ",
            " \nWouldn't be fun to chuck it all and go live on a sailboat? ",
            " \nDo you prefer the people in your life to be simpler or complex? ",
            " \nShould death penalty be abolished? ",
            " \nDo spelling and grammar mistakes annoy you? ",
            " \nWhat is your sexual tendency? ",
            " \nWhat is your relationship goal? "};

        public Survey()
        {
            InitializeComponent();
            questions = new List<Tuple<string, string>>();
            for(int i = 1; i < questionList.Length; i++)
            {
                string title = "QUESTION " + i.ToString();
                string text = questionList[i];
                questions.Add(new Tuple<string, string>(title, text));
            }
            prevBtn_Click(null, null);
        }

        private void nextBtn_Click(object sender, RoutedEventArgs e)
        {
            index++;
            prevBtn.IsEnabled = true;
            TextBlock block = (TextBlock)nextBtn.Content;
            if (index >= questions.Count)
            {
                Home window = new Home();
                window.Show();
                Window.GetWindow(this).Close();
                return;
            }
            else if (index == questions.Count - 1)
            {
                block.Text = "SUMBIT";
            }
            questionTitle.Text = questions[index].Item1;
            questionText.Text = questions[index].Item2;

           /* if (yesBtn.IsChecked == false && noBtn.IsChecked == false) 
            {
                System.Windows.Forms.MessageBox.Show("Please Select an answer");
            }
            else
            {
                index++;
                prevBtn.IsEnabled = true;
                TextBlock block = (TextBlock)nextBtn.Content;
                if (index >= questions.Count)
                {
                    Home window = new Home();
                    window.Show();
                    Window.GetWindow(this).Close();
                    return;
                }
                else if (index == questions.Count - 1)
                {
                    block.Text = "SUMBIT";
                }
                questionTitle.Text = questions[index].Item1;
                questionText.Text = questions[index].Item2;
                yesBtn.IsChecked = false;
                noBtn.IsChecked = false;
            }*/
        }

        private void prevBtn_Click(object sender, RoutedEventArgs e)
        {
            TextBlock block = (TextBlock)nextBtn.Content;
            block.Text = "NEXT";
            index--;
            if(index <= 0)
            {
                index = 0;
                prevBtn.IsEnabled = false;
            }
            questionTitle.Text = questions[index].Item1;
            questionText.Text = questions[index].Item2;
        }

    }
}
