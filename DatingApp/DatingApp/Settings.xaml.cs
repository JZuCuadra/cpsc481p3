﻿using System;
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
    /// Interaction logic for Settings.xaml
    /// </summary>
    public partial class Settings : Window
    {
        public Settings()
        {
            InitializeComponent();
            this.menu.initIndex(3);

            this.retakeQuiz.Click += RetakeQuiz_Click;
        }

        private void RetakeQuiz_Click(object sender, RoutedEventArgs e)
        {
            Survey window = new Survey();
            window.Show();
            Window.GetWindow(this).Close();
            return;
        }
    }
}
