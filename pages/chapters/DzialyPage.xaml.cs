using System.Windows.Controls;
namespace Abituria.pages
{
    public partial class DzialyPage : Page
    {
        public DzialyPage()
        {
            InitializeComponent();
            this.DataContext = new LoginViewModel();
        }    
    }
}
