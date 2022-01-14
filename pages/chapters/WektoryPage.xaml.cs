using System.Windows.Controls;
namespace Abituria.dzialy
{
    public partial class WektoryPage : Page
    {
        public WektoryPage()
        {
            InitializeComponent();
            DataContext = new LoginViewModel();
        }
    }
}