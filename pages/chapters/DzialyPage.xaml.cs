using System.Windows.Controls;
namespace Abituria.pages
{
    public partial class DzialyPage : Page
    {
        public DzialyPage()
        {
            InitializeComponent();
            DataContext = new LoginViewModel();
        }    
    }
}