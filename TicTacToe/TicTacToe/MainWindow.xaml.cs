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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace TicTacToe
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private Player _player = Player.O; // false - x, true - 0 
        private int[,] _matrix = new int[,]
        {
             {0, 0, 0 },
             {0, 0, 0 },
             {0, 0, 0 }

        };

        private void buttonClicked(object sender, RoutedEventArgs e)
        {
            string coordinates = ((Button)sender).Tag.ToString();
            int x = int.Parse(coordinates[0].ToString()) - 1;
            int y = int.Parse(coordinates[1].ToString()) - 1;

            if (_matrix[x, y] == 0)
            {
                _matrix[x, y] = (int)_player;

                ((Button)sender).Content = _player == Player.O ? "0" : "X";
                ((Button)sender).Foreground = _player == Player.O ? Brushes.Blue : Brushes.Red;

                _player = _player == Player.O ? Player.X : Player.O;
            }
            

        }
    }
}
