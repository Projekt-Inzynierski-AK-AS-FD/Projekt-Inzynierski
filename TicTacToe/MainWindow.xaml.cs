using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace TicTacToe
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public bool IsPlayer1Turn { get; set; } = true;
        public int Counter { get; set; }
        public MainWindow()
        {
            InitializeComponent();
        }

        public void NewGame()
        {
            IsPlayer1Turn = false;
            Counter = 0;
            Button_0_0.Content = null;
            Button_1_0.Content = null;
            Button_2_0.Content = null;
            Button_0_1.Content = null;
            Button_1_1.Content = null;
            Button_2_1.Content = null;
            Button_0_2.Content = null;
            Button_1_2.Content = null;
            Button_2_2.Content = null;

            Button_0_0.Background = Brushes.White;
            Button_1_0.Background = Brushes.White;
            Button_2_0.Background = Brushes.White;
            Button_0_1.Background = Brushes.White;
            Button_1_1.Background = Brushes.White;
            Button_2_1.Background = Brushes.White;
            Button_0_2.Background = Brushes.White;
            Button_1_2.Background = Brushes.White;
            Button_2_2.Background = Brushes.White;
        }

        public void Button_Click(object sender, RoutedEventArgs e)
        {
            IsPlayer1Turn ^= true;
            Counter++;

            if (Counter > 9)
            {
                NewGame();
                return;
            }

            var button = sender as Button;
            button.Content = IsPlayer1Turn ? "O" : "X";
            if (button.Content == null)
            {
                button.Content = IsPlayer1Turn ? "O" : "X";
                Counter++;
            }

            if (Counter == 9 && !(button.Content == null))
            {
                Counter++;
            }

            if (CheckIfPlayerWon())
            {
                Counter = 10;
            }
            /*
            if (IsPlayer1Turn)
                IsPlayer1Turn = false;
            else
                IsPlayer1Turn = true;
            */
            if (CheckIfPlayerWon())
            {
                Counter = 9;
            }
        }

        private bool CheckIfPlayerWon()
        {
           if (Button_0_0.Content != null)
                if(Button_0_0.Content == Button_0_1.Content && Button_0_1.Content == Button_0_2.Content)
            {
                Button_0_0.Background = Brushes.Green;
                Button_0_1.Background = Brushes.Green;
                Button_0_2.Background = Brushes.Green;
                return true;
            }
            if (Button_1_0.Content != null)
                if (Button_1_0.Content == Button_1_1.Content && Button_1_1.Content == Button_1_2.Content)
            {
                Button_1_0.Background = Brushes.Green;
                Button_1_1.Background = Brushes.Green;
                Button_1_2.Background = Brushes.Green;
                return true;
            }
            if (Button_2_0.Content != null)
                if (Button_2_0.Content == Button_2_1.Content && Button_2_1.Content == Button_2_2.Content)
            {
                Button_2_0.Background = Brushes.Green;
                Button_2_1.Background = Brushes.Green;
                Button_2_2.Background = Brushes.Green;
                return true;
            }
            if (Button_0_0.Content != null)
                if (Button_0_0.Content == Button_1_0.Content && Button_1_0.Content == Button_2_0.Content)
            {
                Button_0_0.Background = Brushes.Green;
                Button_1_0.Background = Brushes.Green;
                Button_2_0.Background = Brushes.Green;
                return true;
            }
            if (Button_0_1.Content != null)
                if (Button_0_1.Content == Button_1_1.Content && Button_1_1.Content == Button_2_1.Content)
            {
                Button_0_1.Background = Brushes.Green;
                Button_1_1.Background = Brushes.Green;
                Button_2_1.Background = Brushes.Green;
                return true;
            }
            if (Button_0_2.Content != null)
                if (Button_0_2.Content == Button_1_2.Content && Button_1_2.Content == Button_2_2.Content)
            {
                Button_0_2.Background = Brushes.Green;
                Button_1_2.Background = Brushes.Green;
                Button_2_2.Background = Brushes.Green;
                return true;
            }
            if (Button_0_0.Content != null)
                if (Button_0_0.Content == Button_1_1.Content && Button_1_1.Content == Button_2_2.Content)
            {
                Button_0_0.Background = Brushes.Green;
                Button_1_1.Background = Brushes.Green;
                Button_2_2.Background = Brushes.Green;
                return true;
            }
            if (Button_0_2.Content != null)
                if (Button_0_2.Content == Button_1_1.Content && Button_1_1.Content == Button_2_0.Content)
            {
                Button_0_2.Background = Brushes.Green;
                Button_1_1.Background = Brushes.Green;
                Button_2_0.Background = Brushes.Green;
                return true;
            }
            return false;
        }

        private void Button___Click(object sender, RoutedEventArgs e)
        {

        }
    }

}
