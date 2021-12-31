using System.Windows;
using PropertyChanged;
using System.ComponentModel;
namespace Abituria.viewmodel
{
    [ImplementPropertyChanged]
    public class WindowViewModel : BaseViewModel///Model widoku dla niestandardowego okna
    {
        private Window mWindow;///Okno, które kontroluje Model widoku
        private int mOuterMarginSize = 10;///Margines okna pozwalający na cień
        private int mWindowsRadius = 10;///Promień od krawędzi okna
        public string Test { get; set; } = "BonusBGC";
        public int ResizeBorder { get; set; } = 6;
        public Thickness ResizeBorderThickness { get { return new Thickness(ResizeBorder); } }
        public int OuterMarginSize///Zmaksymalizowane okno nie będzie miało przeźroczystego marginesu
        {
            get
            {
                return mWindow.WindowState == WindowState.Maximized ? 0 : mOuterMarginSize;
            }
            set
            {
                mOuterMarginSize = value;
            }
        }
        public int WindowsRadius
        {
            get
            {
                return mWindow.WindowState == WindowState.Maximized ? 0 : mWindowsRadius;
            }
            set
            {
                mWindowsRadius = value;
            }
        }
        public WindowViewModel(Window window)///Standardowy konstruktor
        {
            mWindow = window;
            mWindow.StateChanged += (sender, e) =>
            {

            };
        }
    }
}
