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
using System.Windows.Threading;

namespace DatingApp
{
    /// <summary>
    /// Interaction logic for MatchAnimation.xaml
    /// </summary>
    public partial class MatchAnimation : UserControl
    {
        DispatcherTimer timer = new DispatcherTimer();
        double scale = 0;

        public MatchAnimation()
        {
            InitializeComponent();

            Heart.RenderTransform = new ScaleTransform(scale, scale);

            timer.Interval = new TimeSpan(0, 0, 0, 0, 17);
            timer.Tick += new EventHandler(timer_Tick);
            timer.Start();
        }

        void timer_Tick(object sender, EventArgs e)
        {
            scale += 0.5;

            Heart.RenderTransform = new ScaleTransform(scale, scale);

            if (scale > 10)
                Heart.Opacity -= 0.05;
        }
    }
}
