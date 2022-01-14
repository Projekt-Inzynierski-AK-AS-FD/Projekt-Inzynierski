using System;
using System.Windows;
using System.Windows.Input;
using System.ComponentModel;
using System.Runtime.InteropServices;
using PropertyChanged;
using Abituria.pages;
using Abituria.viewmodel;
using System.Windows.Controls;
using System.Security;
using System.Threading.Tasks;
using System.Runtime.CompilerServices;

namespace Abituria
{
    [ImplementPropertyChanged]
    public class RegisterViewModel : BaseViewModel///Model widoku dla strony rejestracji
    {
        private static string uName;///Pole prywatne do kopii zapasowej wartości właściwości
        public string UserName///Nazwa użytkownika
        {
            get { return uName; }
            set { uName = value; }
        }
        public bool RegisterIsRunning { get; set; }///Flaga wskazująca, czy proces rejestracji trwa
        public SecureString Password { get; set; }///Hasło użytkownika, set; nie działa
        public ICommand RegisterCommand { get; set; }///Komenda do rejestrowania
        public ICommand GoToLoginPage { get; set; }///Komenda przechodzi do strony logowania
        public RegisterViewModel()///Standardowy konstruktor
        {
            RegisterCommand = new RelayParametrizedCommand((parameter) => Register(parameter));///Tworzenie komend
            GoToLoginPage = new RelayCommand(() => LoginP());
        }
        public async Task Register(object parameter)///Próba zarejestrowania nowego użytkownika
        {
            await RunCommand(() => this.RegisterIsRunning, async () =>
            {
                await Task.Delay(500);///Przekazuje SecureString
                var userName = this.UserName;
                var pass = (parameter as IHavePassword).SecurePassword.Unsecure();///ZMIENIĆ! Nigdy nie powinno się przewchowywać hasła w zmiennej!
                LoginP();
            });
        }
        private void LoginP()
        {
            ((WindowViewModel)((MainWindow)Application.Current.MainWindow).DataContext).CurrentPage = ApplicationPage.Login;
        }
        private ICommand makeAccountCommand;
        public ICommand MakeAccountCommand => makeAccountCommand ??= new RelayCommand(MakeAccount);
        private void MakeAccount()///Tworzenie konta użytkownika
        {
        }
        private bool SetProperty<T>(ref T field, T newValue, [CallerMemberName] string propertyName = null)
        {
            if (!Equals(field, newValue))
            {
                field = newValue;//PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
                return true;
            }
            return false;
        }
        private string registerUserName;
        public string RegisterUserName { get => registerUserName; set => SetProperty(ref registerUserName, value); }
    }
}