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

namespace pharmacy
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            AddMed med = new AddMed();
            med.Show();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Data data = new Data();
            data.Show();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            SearchMed search = new SearchMed();
            search.Show();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            RegisterSale register = new RegisterSale();
            register.Show();
        }
    }
}
