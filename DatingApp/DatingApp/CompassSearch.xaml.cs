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
using MaterialDesignThemes.Wpf;

namespace DatingApp
{
    
    /// <summary>
    /// Interaction logic for CompassSearch.xaml
    /// </summary>
    public partial class CompassSearch : Window
    {
        public CompassSearch()
        {
            InitializeComponent();
            this.menu.initIndex(1);
            for (int r = 0; r < compassGrid.RowDefinitions.Count; r++)
            {
                for (int c = 0; c < compassGrid.ColumnDefinitions.Count; c++)
                {
                    UserControl card = CreateCard();
                    SetPosition(card, c, r);
                }
            }
        }

        private UserControl CreateCard()
        {
            UserControl card = new RomanticCard();
            card.VerticalAlignment = VerticalAlignment.Stretch;
            card.HorizontalAlignment = HorizontalAlignment.Stretch;
            return card;
        }

        private void SetPosition(UserControl card, int x, int y)
        {
            if (x < 0 || x >= compassGrid.ColumnDefinitions.Count) throw new ArgumentException();
            if (y < 0 || y >= compassGrid.ColumnDefinitions.Count) throw new ArgumentException();
            card.SetValue(Grid.RowProperty, y);
            card.SetValue(Grid.ColumnProperty, x);
            if (!compassGrid.Children.Contains(card))
            {
                compassGrid.Children.Add(card);
            }
        }

        private void compassSearchWindow_KeyUp(object sender, KeyEventArgs e)
        {
            switch (e.Key)
            {
                case Key.Left:
                    ShiftHorizontal(true);
                    break;
                case Key.Right:
                    ShiftHorizontal(false);
                    break;
                case Key.Up:
                    ShiftVertical(true);
                    break;
                case Key.Down:
                    ShiftVertical(false);
                    break;
                default:
                    break;
            }

        }

        private void ShiftHorizontal(bool left = false)
        {
            int offset = left ? -1 : 1;
            int position = left ? compassGrid.ColumnDefinitions.Count - 1 : 0;
            for (int r = 0; r < compassGrid.RowDefinitions.Count; r++)
            {
                var items = compassGrid.Children
                    .Cast<UserControl>()
                    .Where(i => Grid.GetRow(i) == r)
                    .OrderBy(i => Grid.GetColumn(i))
                    .ToList();
                compassGrid.Children.Remove(left ? items.First() : items.Last());
                items.RemoveAt(left ? 0 : items.Count - 1);
                foreach (UserControl item in items)
                {
                    item.SetValue(Grid.ColumnProperty, (int)item.GetValue(Grid.ColumnProperty) + offset);
                }
                RomanticCard card = (RomanticCard)CreateCard();
                card.age.Text = DateTime.Now.ToLongTimeString();
                SetPosition(card, position, r);
            }
        }

        private void ShiftVertical(bool up = false)
        {
            int offset = up ? -1 : 1;
            int position = up ? compassGrid.RowDefinitions.Count - 1 : 0;
            for(int c = 0; c < compassGrid.ColumnDefinitions.Count; c++)
            {
                var items = compassGrid.Children
                    .Cast<UserControl>()
                    .Where(i => Grid.GetColumn(i) == c)
                    .OrderBy(i => Grid.GetRow(i))
                    .ToList();
                compassGrid.Children.Remove(up ? items.First() : items.Last());
                items.RemoveAt(up ? 0 : items.Count - 1);
                foreach(UserControl item in items)
                {
                    item.SetValue(Grid.RowProperty, (int)item.GetValue(Grid.RowProperty) + offset);
                }
                RomanticCard card = (RomanticCard)CreateCard();
                card.age.Text = DateTime.Now.ToLongTimeString();
                SetPosition(card, c, position);
            }
        }
    }
}
