using System;
using System.Collections.Generic;
using System.Diagnostics;
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
using System.Windows.Navigation;
using System.Windows.Shapes;
using Abituria.matury;
namespace Abituria
{
    [DebuggerDisplay("{" + nameof(GetDebuggerDisplay) + "(),nq}")]
    public class HintsClass
    {
        public static string AnswerButtonChange(object sender, bool ansChecked)
        {
            Button button = sender as Button;
            string message;
            if (ansChecked)
            {
                button.Background = Brushes.LimeGreen;
                message = "To prawidłowa odpowiedź!";
            }
            else
            {
                button.Background = Brushes.IndianRed;
                message = "Odpowiedź jest niepoprawna. Spróbuj jeszcze raz.";
            }
            return message;
        }
        public static string Hint(int counter, string[] hintsArray)
        {
            string hint;
            // wzór: należy uzupełnić go faktyczną treścią
            switch (counter)
            {
                case 1:
                    hint = hintsArray[0];
                    break;

                case 2:
                    hint = hintsArray[0] + "\n" + hintsArray[1];
                    break;

                case 3:
                    hint = hintsArray[0] + "\n" + hintsArray[1] + "\n" + hintsArray[2];
                    break;
                case 4:
                    hint = hintsArray[0] + "\n" + hintsArray[1] + "\n" + hintsArray[2] + "\n" + hintsArray[3];
                    break;
                    // Itd. do momentu, aż nie wyczerpie się pula podpowiedzi, wtedy:
                default:
                    hint = hintsArray[0] + "\n" + hintsArray[1] + "\n" + hintsArray[2] + "\n" + hintsArray[3];
                    break;
            }
            return hint;
        }
        private string GetDebuggerDisplay()
        {
            return ToString();
        }
    }
}
