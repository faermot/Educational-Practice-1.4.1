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

namespace Tic_tac_toe
{
    public partial class MainWindow : Window
    {
        string player = "X";
        string[,] board = new string[3, 3];

        public MainWindow()
        {
            InitializeComponent();
            Restart();
        }

        private void Cell_Click(object sender, RoutedEventArgs e)
        {
            if (sender == cell1 && string.IsNullOrEmpty(cell1.Content.ToString()))
            {
                cell1.Content = player;
                board[0, 0] = player;
            }
            else if (sender == cell2 && string.IsNullOrEmpty(cell2.Content.ToString()))
            {
                cell2.Content = player;
                board[0, 1] = player;
            }
            else if (sender == cell3 && string.IsNullOrEmpty(cell3.Content.ToString()))
            {
                cell3.Content = player;
                board[0, 2] = player;
            }
            else if (sender == cell4 && string.IsNullOrEmpty(cell4.Content.ToString()))
            {
                cell4.Content = player;
                board[1, 0] = player;
            }
            else if (sender == cell5 && string.IsNullOrEmpty(cell5.Content.ToString()))
            {
                cell5.Content = player;
                board[1, 1] = player;
            }
            else if (sender == cell6 && string.IsNullOrEmpty(cell6.Content.ToString()))
            {
                cell6.Content = player;
                board[1, 2] = player;
            }
            else if (sender == cell7 && string.IsNullOrEmpty(cell7.Content.ToString()))
            {
                cell7.Content = player;
                board[2, 0] = player;
            }
            else if (sender == cell8 && string.IsNullOrEmpty(cell8.Content.ToString()))
            {
                cell8.Content = player;
                board[2, 1] = player;
            }
            else if (sender == cell9 && string.IsNullOrEmpty(cell9.Content.ToString()))
            {
                cell9.Content = player;
                board[2, 2] = player;
            }
            else return;

            if (CheckWinner())
            {
                MessageBox.Show($"Игрок {player} победил!");
                Restart();
                return;
            }

            if (IsDraw())
            {
                MessageBox.Show("Ничья!");
                Restart();
                return;
            }

            if (player == "X") player = "O";
            else player = "X";


            playerText.Text = $"Ход: {player}";
        }


        bool CheckWinner()
        {
            for (int i = 0; i < 3; i++)
            {
                if (board[i, 0] == player && board[i, 1] == player && board[i, 2] == player)
                    return true;
                if (board[0, i] == player && board[1, i] == player && board[2, i] == player)
                    return true;
            }

            if (board[0, 0] == player && board[1, 1] == player && board[2, 2] == player)
                return true;
            if (board[0, 2] == player && board[1, 1] == player && board[2, 0] == player)
                return true;

            return false;
        }

        private bool IsDraw()
        {
            foreach (var cell in board)
            {
                if (string.IsNullOrEmpty(cell)) return false;
            }
            return true;
        }

        void RestartButton_Click(object sender, RoutedEventArgs e)
        {
            Restart();
        }

        void Restart()
        {
            board = new string[3, 3];
            player = "X";

            cell1.Content = "";
            cell2.Content = "";
            cell3.Content = "";
            cell4.Content = "";
            cell5.Content = "";
            cell6.Content = "";
            cell7.Content = "";
            cell8.Content = "";
            cell9.Content = "";
        }
    }
}
