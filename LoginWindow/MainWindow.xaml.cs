using System;
using System.Collections.Generic;
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

namespace LoginWindow
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public List<Person> people = new List<Person>();
        public MainWindow()
        {
            InitializeComponent();

            people.Add(new Person { FirstName = "Adam", LastName = "Kubiś" });
            people.Add(new Person { FirstName = "Aleksandra", LastName = "Stołowska" });
            people.Add(new Person { FirstName = "Filip", LastName = "Dura" });
            myComboBox.ItemsSource = people;
        }
        private void submitButton_Click(object sender, RoutedEventArgs e)
        {
            if(myComboBox.SelectedItem != null)
            {
                int x = myComboBox.SelectedIndex;
                MessageBox.Show($"Hello {people[x].FirstName }");
            }
            else
            MessageBox.Show($"Hello { firstNameText.Text }");
        }
    }
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string FullName
        {
            get
            {
                return $"{ FirstName } { LastName }";
            }
        }
    }
}