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
    public enum DIRECTION
    {
        UP,
        LEFT,
        DOWN,
        RIGHT
    }
    /// <summary>
    /// Interaction logic for CompassMap.xaml
    /// </summary>
    public partial class CompassMap : UserControl
    {
        private double _left;
        public double Left
        {
            get
            {
                return _left;
            }
            set
            {
                value = Math.Min(Math.Pow(value - 100, 2) + Math.Pow(this.Top - 100, 2), 2500);
                Canvas.SetLeft(this.StartingPoint, value);
            }
        }

        private double _top;
        public double Top
        {
            get
            {
                return _top;
            }
            set
            {
                value = Math.Min(Math.Pow(this.Left - 100, 2) + Math.Pow(value - 100, 2), 2500);
                Canvas.SetLeft(this.StartingPoint, value);
            }
        }

        public CompassMap()
        {
            InitializeComponent();
            double x = 0;
            double y = 0;
            Canvas.SetTop(this.StartingPoint, y);
            Canvas.SetLeft(this.StartingPoint, x);
            this.Top = y;
            this.Left = x;
        }

        public void Move(DIRECTION direction)
        {
            switch(direction)
            {
                case DIRECTION.DOWN:
                    this.Top -= 1;
                    break;
                case DIRECTION.UP:
                    this.Top += 1;
                    break;
                case DIRECTION.LEFT:
                    this.Left -= 1;
                    break;
                case DIRECTION.RIGHT:
                    this.Left += 1;
                    break;
            }
        }
    }
}
