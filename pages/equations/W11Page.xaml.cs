using System.Windows.Controls;
namespace Abituria.expressions
{
    public partial class W11Page : Page
    {
        public W11Page()
        {
            InitializeComponent();
            this.DataContext = new LoginViewModel();
        }
    }
}