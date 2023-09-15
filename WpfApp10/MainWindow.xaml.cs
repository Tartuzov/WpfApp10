using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
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

namespace WpfApp10
{
    public partial class MainWindow : Window
    {
        List<Employer> employers = new List<Employer>();
        public MainWindow()
        {
            InitializeComponent();
            employers.Add(new Employer("Taras", "Kutuzov", "zdesb"));
            all.ItemsSource = employers;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Employer emp = new Employer();
            emp.name = tb3.Text;
            emp.surname = tb4.Text;
            emp.adress = tb5.Text;
            employers.Add(emp);
            all.Items.Refresh();
        }
        private void Button_Click1(object sender, RoutedEventArgs e)
        {
            all.Focus();
            if (all.SelectedIndex != -1)
            {
                Employer emp = new Employer();
                emp.name = tb3.Text;
                emp.surname = tb4.Text;
                emp.adress = tb5.Text;
                employers[all.SelectedIndex] = emp;
                all.Items.Refresh();
            }
        }
        private void Button_Click2(object sender, RoutedEventArgs e)
        {
            all.Focus();
            if (all.SelectedIndex != -1)
            {
                employers.RemoveAt(all.SelectedIndex);
                all.Items.Refresh();
            }
        }
        public class Employer
        {
            public Employer()
            {

            }
            public Employer(string a, string b, string c)
            {
                name = a;
                surname = b;
                adress = c;
            }
            public string name;
            public string surname;
            public string adress;
            public override string ToString() { return $"{name} {surname} {adress}"; }
        }
    }
}