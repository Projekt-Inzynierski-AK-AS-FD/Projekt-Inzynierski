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
    public class LoginViewModel : BaseViewModel///Model widoku dla niestandardowego okna
    {
        private static string uName;
        public string UserName///Nazwa użytkownika
        {
            get { return uName; }
            set { uName = value; }
        }
        public string Greeting { get; } = "Dzień dobry, " + uName;
        public bool LoginIsRunning { get; set; }///Flaga wskazująca, czy proces Login trwa
        public SecureString Password { get; set; }///Hasło użytkownika, set; nie działa
        public ICommand LoginCommand { get; set; }///Komenda do logowania
        public ICommand GoToLoginPage { get; set; }///Komenda przechodzi do strony logowania
        public ICommand GoToRegisterPage { get; set; }///Komenda przechodzi do strony RegisterPage
        public ICommand GoToMenuPage { get; set; }///Komenda przechodzi do strony MenuPage
        public ICommand GoToMaturaPage { get; set; }///Komenda przechodzi do strony MenuPage
        public ICommand GoToKalkulatorPage { get; set; }///Komenda przechodzi do strony MenuPage
        public ICommand GoToDzialyPage { get; set; }///Komenda przechodzi do strony MenuPage
        public ICommand GoToZadaniaPage { get; set; }///Komenda przechodzi do strony MenuPage
        public ICommand GoToWzoryPage { get; set; }///Komenda przechodzi do strony MenuPage
        public ICommand GoToKwadratowaPage { get; set; }
        public ICommand GoToWektoryPage { get; set; }
        public ICommand GoToMP21Page { get; set; }
        public ICommand GoToZ1Page { get; set; }
        public ICommand GoToZ2Page { get; set; }
        public ICommand GoToZ3Page { get; set; }
        public ICommand GoToZ4Page { get; set; }
        public ICommand GoToZ5Page { get; set; }
        public ICommand GoToZ6Page { get; set; }
        public ICommand GoToZ7Page { get; set; }
        public ICommand GoToZ8Page { get; set; }
        public ICommand GoToZ9Page { get; set; }
        public ICommand GoToZ10Page { get; set; }
        public ICommand GoToZ11Page { get; set; }
        public ICommand GoToZ12Page { get; set; }
        public ICommand GoToZ13Page { get; set; }
        public ICommand GoToZ14Page { get; set; }
        public ICommand GoToZ15Page { get; set; }
        public ICommand GoToZ16Page { get; set; }
        public ICommand GoToZ17Page { get; set; }
        public ICommand GoToZ18Page { get; set; }
        public ICommand GoToZ19Page { get; set; }
        public ICommand GoToz20Page { get; set; }
        public ICommand GoToZ21Page { get; set; }
        public ICommand GoToZ22Page { get; set; }
        public ICommand GoToZ23Page { get; set; }
        public ICommand GoToZ24Page { get; set; }
        public ICommand GoToZ25Page { get; set; }
        public ICommand GoToZ26Page { get; set; }
        public ICommand GoToZ27Page { get; set; }
        public ICommand GoToZ28Page { get; set; }
        public ICommand GoToZ29Page { get; set; }
        public ICommand GoToZ30Page { get; set; }
        public ICommand GoToZ31Page { get; set; }
        public ICommand GoToZ32Page { get; set; }
        public ICommand GoToZ33Page { get; set; }
        public ICommand GoToZ34Page { get; set; }
        public ICommand GoToZ35Page { get; set; }
        public ICommand GoToWPage { get; set; }///Komenda przechodzi do strony Wzory
        public ICommand GoToW2Page { get; set; }///Komenda przechodzi do strony Wzory
        public ICommand GoToW3Page { get; set; }///Komenda przechodzi do strony Wzory
        public ICommand GoToW4Page { get; set; }///Komenda przechodzi do strony Wzorye
        public ICommand GoToW5Page { get; set; }///Komenda przechodzi do strony 
        public ICommand GoToW6Page { get; set; }
        public ICommand GoToW7Page { get; set; }
        public ICommand GoToW8Page { get; set; }
        public ICommand GoToW9Page { get; set; }
        public ICommand GoToW10Page { get; set; }
        public ICommand GoToW11Page { get; set; }
        public ICommand GoToW12Page { get; set; }
        public ICommand GoToW13Page { get; set; }
        public ICommand GoToW14Page { get; set; }
        public ICommand GoToW15Page { get; set; }
        public ICommand GoToW16Page { get; set; }
        public ICommand GoToW17Page { get; set; }
        public ICommand GoToW18Page { get; set; }
        public LoginViewModel()///Standardowy konstruktor
        {
            LoginCommand = new RelayParametrizedCommand((parameter) => Login(parameter));///Tworzenie komend
            GoToLoginPage = new RelayCommand(() => LoginP());
            GoToRegisterPage = new RelayCommand(() => Register());
            GoToMenuPage = new RelayCommand(() => MainMenu());
            GoToMaturaPage = new RelayCommand(() => Matura());
            GoToKalkulatorPage = new RelayCommand(() => Kalkulator());
            GoToDzialyPage = new RelayCommand(() => Dzialy());
            GoToZadaniaPage = new RelayCommand(() => Zadania());
            GoToWzoryPage = new RelayCommand(() => Wzory());
            GoToKwadratowaPage = new RelayCommand(() => Kwadratowa());
            GoToWektoryPage = new RelayCommand(() => Wektory());
            GoToMP21Page = new RelayCommand(() => MP21());
            GoToZ1Page = new RelayCommand(() => Z1());
            GoToZ2Page = new RelayCommand(() => Z2());
            GoToZ3Page = new RelayCommand(() => Z3());
            GoToZ4Page = new RelayCommand(() => Z4());
            GoToZ5Page = new RelayCommand(() => Z5());
            GoToZ6Page = new RelayCommand(() => Z6());
            GoToZ7Page = new RelayCommand(() => Z7());
            GoToZ8Page = new RelayCommand(() => Z8());
            GoToZ9Page = new RelayCommand(() => Z9());
            GoToZ10Page = new RelayCommand(() => Z10());
            GoToZ11Page = new RelayCommand(() => Z11());
            GoToZ12Page = new RelayCommand(() => Z12());
            GoToZ13Page = new RelayCommand(() => Z13());
            GoToZ14Page = new RelayCommand(() => Z14());
            GoToZ15Page = new RelayCommand(() => Z15());
            GoToZ16Page = new RelayCommand(() => Z16());
            GoToZ17Page = new RelayCommand(() => Z17());
            GoToZ18Page = new RelayCommand(() => Z18());
            GoToZ19Page = new RelayCommand(() => Z19());
            GoToz20Page = new RelayCommand(() => Z20());
            GoToZ21Page = new RelayCommand(() => Z21());
            GoToZ22Page = new RelayCommand(() => Z22());
            GoToZ23Page = new RelayCommand(() => Z23());
            GoToZ24Page = new RelayCommand(() => Z24());
            GoToZ25Page = new RelayCommand(() => Z25());
            GoToZ26Page = new RelayCommand(() => Z26());
            GoToZ27Page = new RelayCommand(() => Z27());
            GoToZ28Page = new RelayCommand(() => Z28());
            GoToZ29Page = new RelayCommand(() => Z29());
            GoToZ30Page = new RelayCommand(() => Z30());
            GoToZ31Page = new RelayCommand(() => Z31());
            GoToZ32Page = new RelayCommand(() => Z32());
            GoToZ33Page = new RelayCommand(() => Z33());
            GoToZ34Page = new RelayCommand(() => Z34());
            GoToZ35Page = new RelayCommand(() => Z35());
            GoToWPage = new RelayCommand(() => W());
            GoToW2Page = new RelayCommand(() => W2());
            GoToW3Page = new RelayCommand(() => W3());
            GoToW4Page = new RelayCommand(() => W4());
            GoToW5Page = new RelayCommand(() => W5());
            GoToW6Page = new RelayCommand(() => W6());
            GoToW7Page = new RelayCommand(() => W7());
            GoToW8Page = new RelayCommand(() => W8());
            GoToW9Page = new RelayCommand(() => W9());
            GoToW10Page = new RelayCommand(() => W10());
            GoToW11Page = new RelayCommand(() => W11());
            GoToW12Page = new RelayCommand(() => W12());
            GoToW13Page = new RelayCommand(() => W13());
            GoToW14Page = new RelayCommand(() => W14());
            GoToW15Page = new RelayCommand(() => W15());
            GoToW16Page = new RelayCommand(() => W16());
            GoToW17Page = new RelayCommand(() => W17());
            GoToW18Page = new RelayCommand(() => W18());
        }
        public async Task Login(object parameter)///Próba zalogowania użytkownika
        {
            await RunCommand(() => this.LoginIsRunning, async () =>
            {
                await Task.Delay(500);///Przekazuje SecureString
                var userName = this.UserName;
                var pass = (parameter as IHavePassword).SecurePassword.Unsecure();///ZMIENIĆ! Nigdy nie powinno się przewchowywać hasła w zmiennej!
                MainMenu();
            });
        }
        private void Register()
        {
            ((WindowViewModel)((MainWindow)Application.Current.MainWindow).DataContext).CurrentPage = ApplicationPage.Register;
        }
        private void MainMenu()
        {
            ((WindowViewModel)((MainWindow)Application.Current.MainWindow).DataContext).CurrentPage = ApplicationPage.Main;
        }
        private void LoginP()
        {
            ((WindowViewModel)((MainWindow)Application.Current.MainWindow).DataContext).CurrentPage = ApplicationPage.Login;
        }
        private void Matura()
        {
            ((WindowViewModel)((MainWindow)Application.Current.MainWindow).DataContext).CurrentPage = ApplicationPage.Matura;
        }
        private void Kalkulator()
        {
            ((WindowViewModel)((MainWindow)Application.Current.MainWindow).DataContext).CurrentPage = ApplicationPage.Kalkulator;
        }
        private void Dzialy()
        {
            ((WindowViewModel)((MainWindow)Application.Current.MainWindow).DataContext).CurrentPage = ApplicationPage.Dzialy;
        }
        private void Zadania()
        {
            ((WindowViewModel)((MainWindow)Application.Current.MainWindow).DataContext).CurrentPage = ApplicationPage.Zadania;
        }
        private void Wzory()
        {
            ((WindowViewModel)((MainWindow)Application.Current.MainWindow).DataContext).CurrentPage = ApplicationPage.Wzory;
        }
        private void Kwadratowa()
        {
            ((WindowViewModel)((MainWindow)Application.Current.MainWindow).DataContext).CurrentPage = ApplicationPage.Kwadratowa;
        }

        private void Wektory()
        {
            ((WindowViewModel)((MainWindow)Application.Current.MainWindow).DataContext).CurrentPage = ApplicationPage.Wektory;
        }

        private void MP21()
        {
            ((WindowViewModel)((MainWindow)Application.Current.MainWindow).DataContext).CurrentPage = ApplicationPage.MP21;
        }

        private void Z1()
        {
            ((WindowViewModel)((MainWindow)Application.Current.MainWindow).DataContext).CurrentPage = ApplicationPage.Z1;
        }

        private void Z2()
        {
            ((WindowViewModel)((MainWindow)Application.Current.MainWindow).DataContext).CurrentPage = ApplicationPage.Z2;
        }

        private void Z3()
        {
            ((WindowViewModel)((MainWindow)Application.Current.MainWindow).DataContext).CurrentPage = ApplicationPage.Z3;
        }

        private void Z4()
        {
            ((WindowViewModel)((MainWindow)Application.Current.MainWindow).DataContext).CurrentPage = ApplicationPage.Z4;
        }


        private void Z5()
        {
            ((WindowViewModel)((MainWindow)Application.Current.MainWindow).DataContext).CurrentPage = ApplicationPage.Z5;
        }

        private void Z6()
        {
            ((WindowViewModel)((MainWindow)Application.Current.MainWindow).DataContext).CurrentPage = ApplicationPage.Z6;
        }

        private void Z7()
        {
            ((WindowViewModel)((MainWindow)Application.Current.MainWindow).DataContext).CurrentPage = ApplicationPage.Z7;
        }

        private void Z8()
        {
            ((WindowViewModel)((MainWindow)Application.Current.MainWindow).DataContext).CurrentPage = ApplicationPage.Z8;
        }

        private void Z9()
        {
            ((WindowViewModel)((MainWindow)Application.Current.MainWindow).DataContext).CurrentPage = ApplicationPage.Z9;
        }

        private void Z10()
        {
            ((WindowViewModel)((MainWindow)Application.Current.MainWindow).DataContext).CurrentPage = ApplicationPage.Z10;
        }

        private void Z11()
        {
            ((WindowViewModel)((MainWindow)Application.Current.MainWindow).DataContext).CurrentPage = ApplicationPage.Z11;
        }

        private void Z12()
        {
            ((WindowViewModel)((MainWindow)Application.Current.MainWindow).DataContext).CurrentPage = ApplicationPage.Z12;
        }

        private void Z13()
        {
            ((WindowViewModel)((MainWindow)Application.Current.MainWindow).DataContext).CurrentPage = ApplicationPage.Z13;
        }

        private void Z14()
        {
            ((WindowViewModel)((MainWindow)Application.Current.MainWindow).DataContext).CurrentPage = ApplicationPage.Z14;
        }

        private void Z15()
        {
            ((WindowViewModel)((MainWindow)Application.Current.MainWindow).DataContext).CurrentPage = ApplicationPage.Z15;
        }

        private void Z16()
        {
            ((WindowViewModel)((MainWindow)Application.Current.MainWindow).DataContext).CurrentPage = ApplicationPage.Z16;
        }

        private void Z17()
        {
            ((WindowViewModel)((MainWindow)Application.Current.MainWindow).DataContext).CurrentPage = ApplicationPage.Z17;
        }

        private void Z18()
        {
            ((WindowViewModel)((MainWindow)Application.Current.MainWindow).DataContext).CurrentPage = ApplicationPage.Z18;
        }

        private void Z19()
        {
            ((WindowViewModel)((MainWindow)Application.Current.MainWindow).DataContext).CurrentPage = ApplicationPage.Z19;
        }

        private void Z20()
        {
            ((WindowViewModel)((MainWindow)Application.Current.MainWindow).DataContext).CurrentPage = ApplicationPage.Z20;
        }

        private void Z21()
        {
            ((WindowViewModel)((MainWindow)Application.Current.MainWindow).DataContext).CurrentPage = ApplicationPage.Z21;
        }

        private void Z22()
        {
            ((WindowViewModel)((MainWindow)Application.Current.MainWindow).DataContext).CurrentPage = ApplicationPage.Z22;
        }

        private void Z23()
        {
            ((WindowViewModel)((MainWindow)Application.Current.MainWindow).DataContext).CurrentPage = ApplicationPage.Z23;
        }

        private void Z24()
        {
            ((WindowViewModel)((MainWindow)Application.Current.MainWindow).DataContext).CurrentPage = ApplicationPage.Z24;
        }

        private void Z25()
        {
            ((WindowViewModel)((MainWindow)Application.Current.MainWindow).DataContext).CurrentPage = ApplicationPage.Z25;
        }

        private void Z26()
        {
            ((WindowViewModel)((MainWindow)Application.Current.MainWindow).DataContext).CurrentPage = ApplicationPage.Z26;
        }

        private void Z27()
        {
            ((WindowViewModel)((MainWindow)Application.Current.MainWindow).DataContext).CurrentPage = ApplicationPage.Z27;
        }

        private void Z28()
        {
            ((WindowViewModel)((MainWindow)Application.Current.MainWindow).DataContext).CurrentPage = ApplicationPage.Z28;
        }

        private void Z29()
        {
            ((WindowViewModel)((MainWindow)Application.Current.MainWindow).DataContext).CurrentPage = ApplicationPage.Z29;
        }

        private void Z30()
        {
            ((WindowViewModel)((MainWindow)Application.Current.MainWindow).DataContext).CurrentPage = ApplicationPage.Z30;
        }

        private void Z31()
        {
            ((WindowViewModel)((MainWindow)Application.Current.MainWindow).DataContext).CurrentPage = ApplicationPage.Z31;
        }

        private void Z32()
        {
            ((WindowViewModel)((MainWindow)Application.Current.MainWindow).DataContext).CurrentPage = ApplicationPage.Z32;
        }

        private void Z33()
        {
            ((WindowViewModel)((MainWindow)Application.Current.MainWindow).DataContext).CurrentPage = ApplicationPage.Z33;
        }

        private void Z34()
        {
            ((WindowViewModel)((MainWindow)Application.Current.MainWindow).DataContext).CurrentPage = ApplicationPage.Z34;
        }

        private void Z35()
        {
            ((WindowViewModel)((MainWindow)Application.Current.MainWindow).DataContext).CurrentPage = ApplicationPage.Z35;
        }

        private void W()
        {
            ((WindowViewModel)((MainWindow)Application.Current.MainWindow).DataContext).CurrentPage = ApplicationPage.W;
        }

        private void W2()
        {
            ((WindowViewModel)((MainWindow)Application.Current.MainWindow).DataContext).CurrentPage = ApplicationPage.W2;
        }

        private void W3()
        {
            ((WindowViewModel)((MainWindow)Application.Current.MainWindow).DataContext).CurrentPage = ApplicationPage.W3;
        }

        private void W4()
        {
            ((WindowViewModel)((MainWindow)Application.Current.MainWindow).DataContext).CurrentPage = ApplicationPage.W4;
        }

        private void W5()
        {
            ((WindowViewModel)((MainWindow)Application.Current.MainWindow).DataContext).CurrentPage = ApplicationPage.W5;
        }

        private void W6()
        {
            ((WindowViewModel)((MainWindow)Application.Current.MainWindow).DataContext).CurrentPage = ApplicationPage.W6;
        }

        private void W7()
        {
            ((WindowViewModel)((MainWindow)Application.Current.MainWindow).DataContext).CurrentPage = ApplicationPage.W7;
        }

        private void W8()
        {
            ((WindowViewModel)((MainWindow)Application.Current.MainWindow).DataContext).CurrentPage = ApplicationPage.W8;
        }

        private void W9()
        {
            ((WindowViewModel)((MainWindow)Application.Current.MainWindow).DataContext).CurrentPage = ApplicationPage.W9;
        }

        private void W10()
        {
            ((WindowViewModel)((MainWindow)Application.Current.MainWindow).DataContext).CurrentPage = ApplicationPage.W10;
        }

        private void W11()
        {
            ((WindowViewModel)((MainWindow)Application.Current.MainWindow).DataContext).CurrentPage = ApplicationPage.W11;
        }

        private void W12()
        {
            ((WindowViewModel)((MainWindow)Application.Current.MainWindow).DataContext).CurrentPage = ApplicationPage.W12;
        }

        private void W13()
        {
            ((WindowViewModel)((MainWindow)Application.Current.MainWindow).DataContext).CurrentPage = ApplicationPage.W13;
        }

        private void W14()
        {
            ((WindowViewModel)((MainWindow)Application.Current.MainWindow).DataContext).CurrentPage = ApplicationPage.W14;
        }

        private void W15()
        {
            ((WindowViewModel)((MainWindow)Application.Current.MainWindow).DataContext).CurrentPage = ApplicationPage.W15;
        }
        private void W16()
        {
            ((WindowViewModel)((MainWindow)Application.Current.MainWindow).DataContext).CurrentPage = ApplicationPage.W16;
        }
        private void W17()
        {
            ((WindowViewModel)((MainWindow)Application.Current.MainWindow).DataContext).CurrentPage = ApplicationPage.W17;
        }
        private void W18()
        {
            ((WindowViewModel)((MainWindow)Application.Current.MainWindow).DataContext).CurrentPage = ApplicationPage.W18;
        }

        private ICommand makeAccountCommand;
        public ICommand MakeAccountCommand => makeAccountCommand ??= new RelayCommand(MakeAccount);

        private void MakeAccount()
        {
        }

        private bool SetProperty<T>(ref T field, T newValue, [CallerMemberName] string propertyName = null)
        {
            if (!Equals(field, newValue))
            {
                field = newValue;
                //PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
                return true;
            }

            return false;
        }

        private string registerUserName;

        public string RegisterUserName { get => registerUserName; set => SetProperty(ref registerUserName, value); }
    }
}
