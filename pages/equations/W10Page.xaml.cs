using System.Windows.Controls;
namespace Abituria.expressions
{
    public partial class W10Page : Page
    {
        public W10Page()
        {
            InitializeComponent();
            DataContext = new LoginViewModel();
        }
    }
}