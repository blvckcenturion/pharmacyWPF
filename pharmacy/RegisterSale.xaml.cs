using System;
using System.Collections.Generic;
using System.IO;
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
    /// Interaction logic for RegisterSale.xaml
    /// </summary>
    public partial class RegisterSale : Window
    {
        Storage storage = new Storage();


        public RegisterSale()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            errorTxt.Visibility = Visibility.Hidden;
            errorTxt.Text = "";
            int id = -1;
            int qty = 0;
            List<Medicine> meds = storage.getFile();
            bool validId = int.TryParse(idBox.Text, out id);
            bool validQty = int.TryParse(priceBox.Text, out qty);
            if (validId)
            {
                if(validQty && qty > 0)
                {
                    int item = -1;
                    for (int i = 0; i < meds.Count; i++)
                    {
                        if (meds[i].Id == id)
                        {
                            item = i;
                            break;
                        }
                    }

                    if (item > -1)
                    {
                        Medicine med = meds[item];
                        if (med.QtyInExistance >= qty)
                        {
                            int result = med.QtyInExistance - qty;
                            string[] lines = File.ReadAllLines(storage.path);
                            lines[item] = med.Name + "/" + result + "/" + med.Price + "/" + med.Id;
                            File.WriteAllLines(storage.path, lines);
                            MessageBox.Show("Venta realizada de forma exitosa");
                            return;
                        }
                        errorTxt.Visibility = Visibility.Visible;
                        errorTxt.Text = "La cantidad es superior al stock.";
                        return;
                    }
                    errorTxt.Visibility = Visibility.Visible;
                    errorTxt.Text = "ID no encontrado";
                    return;
                }
                errorTxt.Visibility = Visibility.Visible;
                errorTxt.Text = "Cantidad no valida";
                return;
            }
            errorTxt.Visibility = Visibility.Visible;
            errorTxt.Text = "ID no valido";
        }

    }
}
