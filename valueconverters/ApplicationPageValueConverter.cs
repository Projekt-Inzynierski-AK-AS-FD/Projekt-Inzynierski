using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using Abituria.pages;
using System.IO;
using Abituria.viewmodel;

namespace Abituria
{
    public class ApplicationPageValueConverter : BaseValueConverter<ApplicationPageValueConverter>///Zamienia strone aplikacji na aktualną strone
    {
        public override object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            switch ((ApplicationPage)value)///Znajdź odpowiednią strone
            {
                case ApplicationPage.Login:
                    return new LoginPage();
                case ApplicationPage.Main:
                    return new MainPage();
                case ApplicationPage.Register:
                    return new RegisterPage();
                case ApplicationPage.Matura:
                    return new MaturaPage();
                case ApplicationPage.Kalkulator:
                    return new KalkulatorPage();
                case ApplicationPage.Dzialy:
                    return new DzialyPage();
                case ApplicationPage.Zadania:
                    return new ZadaniaPage();
                case ApplicationPage.Wzory:
                    return new WzoryPage();
                default:
                    Debugger.Break();
                    return null;
            }
        }
        public override object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
