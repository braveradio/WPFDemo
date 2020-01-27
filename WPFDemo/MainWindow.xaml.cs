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
using PluginInterface;

namespace WPFDemo
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        PluginImplementer PI;
        List<Person> people = new List<Person>();
        public MainWindow()
        {
            InitializeComponent();

            people.Add(new Person() { FirstName = "Steve", LastName = "Mayson" });
            people.Add(new Person() { FirstName = "Brad", LastName = "Perry" });
            people.Add(new Person() { FirstName = "Kate", LastName = "Mallson" });

            myComboBox.ItemsSource = people;

        }

        private void submitButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show($"Hello { firstNameText.Text} ");
            Console.WriteLine("Hello Motherfucker" + new Random().Next(1,10));
        }
    }
}
