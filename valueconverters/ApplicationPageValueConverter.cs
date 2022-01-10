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
                case ApplicationPage.Kwadratowa:
                    return new KwadratowaPage();
                case ApplicationPage.Wektory:
                    return new WektoryPage();
                case ApplicationPage.MP21:
                    return new MP21Page();
                case ApplicationPage.Z1:
                    return new Z1Page();
                case ApplicationPage.Z2:
                    return new Z2Page();
                case ApplicationPage.Z3:
                    return new Z3Page();
                case ApplicationPage.Z4:
                    return new Z4Page();
                case ApplicationPage.Z5:
                    return new Z5Page();
                case ApplicationPage.Z6:
                    return new Z6Page();
                case ApplicationPage.Z7:
                    return new Z7Page();
                case ApplicationPage.Z8:
                    return new Z8Page();
                case ApplicationPage.Z9:
                    return new Z9Page();
                case ApplicationPage.Z10:
                    return new Z10Page();
                case ApplicationPage.Z11:
                    return new Z11Page();
                case ApplicationPage.Z12:
                    return new Z12Page();
                case ApplicationPage.Z13:
                    return new Z13Page();
                case ApplicationPage.Z14:
                    return new Z14Page();
                case ApplicationPage.Z15:
                    return new Z15Page();
                case ApplicationPage.Z16:
                    return new Z16Page();
                case ApplicationPage.Z17:
                    return new Z17Page();
                case ApplicationPage.Z18:
                    return new Z18Page();
                case ApplicationPage.Z19:
                    return new Z19Page();
                case ApplicationPage.Z20:
                    return new Z20Page();
                case ApplicationPage.Z21:
                    return new Z21Page();
                case ApplicationPage.Z22:
                    return new Z22Page();
                case ApplicationPage.Z23:
                    return new Z23Page();
                case ApplicationPage.Z24:
                    return new Z24Page();
                case ApplicationPage.Z25:
                    return new Z25Page();
                case ApplicationPage.Z26:
                    return new Z26Page();
                case ApplicationPage.Z27:
                    return new Z27Page();
                case ApplicationPage.Z28:
                    return new Z28Page();
                case ApplicationPage.Z29:
                    return new Z29Page();
                case ApplicationPage.Z30:
                    return new Z30Page();
                case ApplicationPage.Z31:
                    return new Z31Page();
                case ApplicationPage.Z32:
                    return new Z32Page();
                case ApplicationPage.Z33:
                    return new Z33Page();
                case ApplicationPage.Z34:
                    return new Z34Page();
                case ApplicationPage.Z35:
                    return new Z35Page();
                case ApplicationPage.W1:
                    return new W1Page();
                case ApplicationPage.W2:
                    return new W2Page();
                case ApplicationPage.W3:
                    return new W3Page();
                case ApplicationPage.W4:
                    return new W4Page();
                case ApplicationPage.W5:
                    return new W5Page();
                case ApplicationPage.W6:
                    return new W6Page();
                case ApplicationPage.W7:
                    return new W7Page();
                case ApplicationPage.W8:
                    return new W8Page();
                case ApplicationPage.W9:
                    return new W9Page();
                case ApplicationPage.W10:
                    return new W10Page();
                case ApplicationPage.W11:
                    return new W11Page();
                case ApplicationPage.W12:
                    return new W12Page();
                case ApplicationPage.W13:
                    return new W13Page();
                case ApplicationPage.W14:
                    return new W14Page();
                case ApplicationPage.W15:
                    return new W15Page();
                case ApplicationPage.W16:
                    return new W16Page();
                case ApplicationPage.W17:
                    return new W17Page();
                case ApplicationPage.W18:
                    return new W18Page();
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
