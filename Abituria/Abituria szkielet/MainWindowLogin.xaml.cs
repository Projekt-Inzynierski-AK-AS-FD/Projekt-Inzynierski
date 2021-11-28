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
using System.IO;

namespace Abituria
{
    /// <summary>
    /// Logika interakcji dla klasy MainWindowLogin.xaml
    /// </summary>
    public partial class MainWindowLogin : Window
    {
        public MainWindowLogin()
        {
            InitializeComponent();
            Login();
        }

        private void Login()
        {
            string usersFile = @"users.txt";
            List<string> usersList = new List<string>();

            using (StreamReader reader = new StreamReader(usersFile))
            {
                string user = "";
                int i = 0;
                MessageBox.Show(reader.ReadLine() + " mlem???");
                while ((user = reader.ReadLine()) != null || i > 9)
                {
                    MessageBox.Show(user + " mlem???");
                    comboBox1.ItemsSource = new List<string> { "ty mi", "piętnastaka", "dajesz jeżyco?" };
                    i++;
                }
            }

            


            
            


        }
        private static void CreateProfile()
        {
            /*
            using (StreamWriter writer = File.AppendText(usersFile))
            {
                //writer.WriteLine("\n heeeeh?");
                //writer.Close();
            }
            */
        }

        private void BtnAcntExists(object sender, RoutedEventArgs e)
        {
            btn1.Visibility = Visibility.Collapsed;
            comboBox1.Visibility = Visibility.Visible;
        }

        private void BtnCreateNew(object sender, RoutedEventArgs e)
        {

        }

        private void Confirm(object sender, RoutedEventArgs e)
        {
            string eh = comboBox1.SelectedItem as string;
            MessageBox.Show(eh);
        }
    }
}
