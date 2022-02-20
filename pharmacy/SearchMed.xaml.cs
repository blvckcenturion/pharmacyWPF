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
using System.Windows.Shapes;

namespace pharmacy
{
    /// <summary>
    /// Interaction logic for SearchMed.xaml
    /// </summary>
    public partial class SearchMed : Window
    {
        Storage storage = new Storage();
        List<Medicine> meds;
        public SearchMed()
        {
            InitializeComponent();
        }

        private void txtSearch_TextChanged(object sender, TextChangedEventArgs e)
        {
            List<Medicine> result = new List<Medicine>();

            if (nameCheckBox.IsChecked == true)
            {
                foreach (Medicine med in storage.getFile())
                {
                    if (med.Name.ToLower() == txtSearch.Text.ToLower()) result.Add(med);
                }
            } else if(priceCheckBox.IsChecked == true)
            {
                int price;
                bool validNumber = int.TryParse(txtSearch.Text, out price);
                if (validNumber)
                {
                    foreach (Medicine med in storage.getFile())
                    {
                        if (med.Price == price) result.Add(med);
                    }
                }
            }
            resultGrid.ItemsSource = result;
        }
    }
}
