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
using System.Windows.Navigation;
using System.IO;

namespace Abituria
{
    /// <summary>
    /// Logika interakcji dla klasy MainWindowLogin.xaml
    /// </summary>
    /// 
    public partial class MainWindowLogin : Window
    {
        string usersFile = @"users.txt";

        public MainWindowLogin()
        {
            InitializeComponent();
        }

        private List<string> SetUsersList(string usersFile)
        {
            //comboBox1.ItemsSource = new List<string> {};
            List<string> usersList = new List<string>();

            using (StreamReader reader = new StreamReader(usersFile))
            {
                string user = "";
                int i = 0;

                while ((user = reader.ReadLine()) != null || i > 9)
                {
                    usersList.Add(user);
                    i++;
                }
            }

            comboBox1.ItemsSource = usersList;
            return usersList;
        }

        private void BtnAcntExists(object sender, RoutedEventArgs e)
        {
            btn1.Visibility = Visibility.Collapsed;
            btn2.Visibility = Visibility.Collapsed;
            btnConfirm.Visibility = Visibility.Visible;
            comboBox1.Visibility = Visibility.Visible;

            SetUsersList(usersFile);
        }

        private string ChosenUsername()
        {
            string username = comboBox1.SelectedItem as string;
            return username;
        }

        private void LoginConfirm(object sender, RoutedEventArgs e)
        {
            string username = ChosenUsername();
            MessageBox.Show(username);

            //do zmiany na lepsze, gdy ustawi się frame'y
            var mainWin = new MainWindow();
            mainWin.Owner = this;
            this.Hide();
            mainWin.ShowDialog();
        }

        private void CreateProfile(string newUser, string usersFile, bool isValid)
        {
            MessageBox.Show(newUser);
            using (StreamWriter writer = File.AppendText(usersFile))
            {
                if (isValid == true)
                {
                    writer.WriteLine(newUser);
                }
            }
        }
        private void BtnCreateNew(object sender, RoutedEventArgs e)
        {
            btn1.Visibility = Visibility.Collapsed;
            btn2.Visibility = Visibility.Collapsed;
            inputGB.Visibility = Visibility.Visible;
        }

        private void AddUser(object sender, RoutedEventArgs e)
        {
            string newUsername = nameInput.Text;
            List<string> userslist = SetUsersList(usersFile);
            bool isTaken = true;
            bool isValid = false;

            //dokończyć weryfikację
            foreach (string user in userslist)
            {
                if (user == newUsername)
                {
                    MessageBox.Show("Taki użytkownik już istnieje! Wybierz inną nazwę użytkownika", "Nazwa zajęta");
                    isTaken = true;
                    break;
                }
                else
                {
                    isTaken = false;
                }
            }

            if (newUsername.Length > 15)
            {
                MessageBox.Show("Wybrana nazwa jest za długa!", "Nazwa zbyt długa");
                isValid = false;
            }
            else
            {
                if (isTaken == false)
                {
                    isValid = true;
                }
                else
                {
                    isValid = false;
                }
            }
            CreateProfile(newUsername, usersFile, isValid);
        }
    }
}
