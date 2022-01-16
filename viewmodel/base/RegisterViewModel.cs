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
using Abituria.controls;
using Abituria.datamodels;
using System.Linq;

namespace Abituria
{
    public class RegisterViewModel : viewmodel.WindowViewModel///Model widoku dla strony rejestracji
    {
        private string registerUserName;///Pole prywatne do kopii zapasowej wartości właściwości
        public string RegisterUserName { get => registerUserName; set => SetProperty(ref registerUserName, value); }///Nazwa użytkownika
        private string registerPassword;///Pole prywatne do kopii zapasowej wartości właściwości
        public string RegisterPassword { get => registerPassword; set => SetProperty(ref registerPassword, value); }///Nazwa użytkownika
        public bool RegisterIsRunning { get; set; }///Flaga wskazująca, czy proces rejestracji trwa
        public SecureString Password { get; set; }///Hasło użytkownika, set; nie działa
        public ICommand registerCommand { get; set; }///Komenda do rejestrowania
        public ICommand RegisterCommand => registerCommand ??= new RelayCommand(MakeAccount);
        public ICommand GoToLoginPage { get; set; }///Komenda przechodzi do strony logowania
        public RegisterViewModel()///Standardowy konstruktor
        {
            registerCommand = new RelayParametrizedCommand((parameter) => Register(parameter));///Tworzenie komend
            GoToLoginPage = new RelayCommand(() => LoginP());
        }
        public async Task Register(object parameter)///Próba zarejestrowania nowego użytkownika
        {
            await RunCommand(() => this.RegisterIsRunning, async () =>
            {
                await Task.Delay(500);///Przekazuje SecureString
                //var userName = this.UserName;
                //var password = this.Password;//= (parameter as IHavePassword).SecurePassword.Unsecure();///ZMIENIĆ! Nigdy nie powinno się przewchowywać hasła w zmiennej!    
                MakeAccount();
                new RelayCommand(() => LoginP());
            });
        }
        private void MakeAccount()///Tworzenie konta użytkownika
        {
            IDataService<User> userService = new GenericDataService<User>(new SimpleDbContextFactory());
            userService.Create(new User { Username = registerUserName, Password = registerPassword });//.Wait();
            //Console.WriteLine(userService.GetAll().Result.Count());
            string v = userService.GetAll().Result.Count().ToString();
            //MessageBox.Show(v, v, MessageBoxButton.OK, MessageBoxImage.Error);
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
        private void LoginP() => ((WindowViewModel)((MainWindow)Application.Current.MainWindow).DataContext).CurrentPage = ApplicationPage.Login;
    }
}