using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security;
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
using Abituria;
namespace Abituria.pages
{
    public partial class LoginPage : BasePage<LoginViewModel>, IHavePassword
    {
        public LoginPage()
        {
            InitializeComponent();
            DataContext = new LoginViewModel();
        }

        public SecureString GetSecurePassword() => PasswordText.SecurePassword;///Chronione hasło dla tej strony
    }
}