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
    /// Interaction logic for AddMed.xaml
    /// </summary>
    public partial class AddMed : Window
    {
        Storage storage = new Storage();
        public AddMed()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (prodNameBox.Text != "" && qtyBox.Text != "" && priceBox.Text != "")
            {
                int qty, price;
                bool validQty, validPrice;
                validQty = int.TryParse(qtyBox.Text, out qty);
                validPrice = int.TryParse(priceBox.Text, out price);
                if (validPrice && validQty)
                {
                    storage.addMedicine(prodNameBox.Text, qty, price, storage.getFile().Count + 1);
                    prodNameBox.Text = "";
                    qtyBox.Text = "";
                    priceBox.Text = "";
                    MessageBox.Show("Producto registrado de forma exitosa");
                    return;
                } else
                {
                    errorTxt.Text = "Error, las cantidades no son validas";
                }
            }
            else
            {
                errorTxt.Text = "Error, hay espacios en blanco.";
            }
            errorTxt.Visibility = Visibility.Visible;
        }

    }
}
