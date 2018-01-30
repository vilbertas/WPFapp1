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

        private Player? DetermineWinner() //klaustukas reiskia, kad reiksme gali but null
        {
            if (_matrix[0, 0] == 1 
                && _matrix[0, 1] == 1 
                && _matrix[0, 2] == 1)
            {
                return Player.X;
            }
            else if (_matrix[1, 0] == 1
                && _matrix[1, 1] == 1
                && _matrix[1, 2] == 1)
            {
                return Player.X;
            }
            else if (_matrix[2, 0] == 1
                && _matrix[2, 1] == 1
                && _matrix[2, 2] == 1)
            {
                return Player.X;
            }
            else if (_matrix[0, 0] == 1
                && _matrix[1, 0] == 1
                && _matrix[2, 0] == 1)
            {
                return Player.X;
            }
            else if (_matrix[0, 1] == 1
                && _matrix[1, 1] == 1
                && _matrix[2, 1] == 1)
            {
                return Player.X;
            }
            else if (_matrix[0, 2] == 1
                && _matrix[1, 2] == 1
                && _matrix[2, 2] == 1)
            {
                return Player.X;
            }
            else if (_matrix[0, 0] == 1
                && _matrix[1, 1] == 1
                && _matrix[2, 2] == 1)
            {
                return Player.X;
            }
            else if (_matrix[0, 2] == 1
                && _matrix[1, 1] == 1
                && _matrix[2, 0] == 1)
            {
                return Player.X;
            }
            return null;
        }
          

        private void buttonClicked(object sender, RoutedEventArgs e)
        {
            string coordinates = ((Button)sender).Tag.ToString();
            int x = int.Parse(coordinates[0].ToString());
            int y = int.Parse(coordinates[1].ToString());

            if (_matrix[x, y] == 0)
            {
                _matrix[x, y] = (int)_player;

                Player? winner = DetermineWinner();
                if (winner != null)
                {
                    winnerLabel.Content = winner == Player.X ? "X" + " has won" : "0" + " has won";
                }

                ((Button)sender).Content = _player == Player.O ? "0" : "X";
                ((Button)sender).Foreground = _player == Player.O ? Brushes.Blue : Brushes.Red;//nudazo nuliukus ir iksiukus

                _player = _player == Player.O ? Player.X : Player.O;
            }
            

        }
    }
}
