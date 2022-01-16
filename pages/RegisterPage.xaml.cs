using System.Security;
using Abituria.viewmodel;
using System.ComponentModel;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System;
namespace Abituria
{
    public partial class RegisterPage : BasePage<RegisterViewModel>//, IHavePassword
    {
        public RegisterPage()
        {
            InitializeComponent();
            DataContext = new RegisterViewModel();
        }
        //public SecureString SecurePassword => PasswordText.SecurePassword;///Chronione hasło dla tej strony
    }
}