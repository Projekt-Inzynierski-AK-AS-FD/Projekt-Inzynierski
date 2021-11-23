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
            string username = "";
            string path = @"C:\Users\admin\source\repos\Projekt-Inzynierski-AK-AS-FD\Projekt-Inzynierski\Abituria\user.txt";
            string readText = File.ReadAllText(path);
            this.txt1.Text = readText;
        }
        private static void CreateProfile()
        {

        }
    }
}
