using System.Windows.Controls;
namespace Abituria.expressions
{
    public partial class W12Page : Page
    {
        public W12Page()
        {
            InitializeComponent();
            this.DataContext = new LoginViewModel();
        }
    }
}