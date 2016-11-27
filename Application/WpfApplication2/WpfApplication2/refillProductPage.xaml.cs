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
using System.Text.RegularExpressions;

namespace WpfApplication2
{
    /// <summary>
    /// Interaction logic for refillProductPage.xaml
    /// </summary>
    public partial class refillProductPage : Page
    {
        public static accessDatabase a = new accessDatabase();
        private ComboBox x = a.comboBoxfillDatabase("warehouse_table", 0);


        private void NumberValidationTextBox(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9]+");
            e.Handled = regex.IsMatch(e.Text);
        }

        private void productNameComboBox_Fill()
        {
            
            productNameComboBox.Items.Clear(); 
            int len = x.Items.Count;

            for (int i = 0; i < len; i++)
            { 
                string tem = x.Items[i].ToString();
                 productNameComboBox.Items.Add(x.Items[i]);
            }
        }

        public refillProductPage()
        {
            InitializeComponent();
        }

        private void addProductButton_Click(object sender, RoutedEventArgs e)
        {
            int i;            
            for (i = 0; i < x.Items.Count; i++)
                if (productNameComboBox.Text == x.Items[i].ToString())
                    break;

            if(x.Items.Count != i)
            {
                //------------------------------------------------------------------------------------------------
                string qtyStr = a.getRowDatabase("warehouse_table", 1, "product_name", productNameComboBox.Text);
                int qty = Convert.ToInt32(qtyStr);

                qty += Convert.ToInt32(quantityTextBox.Text);
                qtyStr = qty.ToString();

                a.editDatabase("warehouse_table", "product_quantity = '"+ qtyStr +"'", "product_name", productNameComboBox.Text);

                string date = System.DateTime.Now.ToString();
                a.addInDatabase("log_table", "dateti,actions,what", "'" + date + "','Refilled Product','" + productNameComboBox.Text +" "+quantityTextBox.Text+"'");
                this.NavigationService.GoBack();
            }
            else
            {
                errorMessage.Text = "No Such product exists in WareHouse!!!!!!!";
                productNameComboBox.BorderBrush = Brushes.Red;
            }
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            productNameComboBox_Fill();
        }

  
    }
}
