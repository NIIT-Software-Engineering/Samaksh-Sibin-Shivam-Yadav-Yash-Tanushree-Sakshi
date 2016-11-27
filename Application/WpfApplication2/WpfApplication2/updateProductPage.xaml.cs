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
    /// Interaction logic for updateProductPage.xaml
    /// </summary>
    public partial class updateProductPage : Page
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

        public updateProductPage()
        {
            InitializeComponent();
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            productNameComboBox_Fill();
        }

        private void productNameComboBox_LostFocus(object sender, RoutedEventArgs e)
        {
            int i;
            for (i = 0; i < x.Items.Count; i++)
                if (productNameComboBox.Text == x.Items[i].ToString())
                    break;
            if (x.Items.Count != i)
            {
                //------------------------------------------------------------------------------------------------
                quantityTextBox.Text = a.getRowDatabase("warehouse_table", 1, "product_name", productNameComboBox.Text).ToString();
                pricePBoxTextBox.Text = a.getRowDatabase("warehouse_table", 2, "product_name", productNameComboBox.Text).ToString();
                manufacturerTextBox.Text = a.getRowDatabase("warehouse_table", 3, "product_name", productNameComboBox.Text).ToString();
                quantityPBoxTextBox.Text = a.getRowDatabase("warehouse_table", 4, "product_name", productNameComboBox.Text).ToString();

                errorMessage.Text = "";
                //this.NavigationService.GoBack();
            }
            else
                errorMessage.Text = "Invalid Product Name!!!!!!";
        }

        private void updateProductButton_Click(object sender, RoutedEventArgs e)
        {
            //if (mobileTextBox.Text.Length == 10 && storeNameComboBox.Text != "" && ownerTextBox.Text != "" && addressTextBox.Text != "")
            int i;
            for (i = 0; i < x.Items.Count; i++)
                if (productNameComboBox.Text == x.Items[i].ToString())
                    break;

            if (x.Items.Count != i && quantityPBoxTextBox.Text != "" && quantityTextBox.Text != "" && Convert.ToInt32(quantityPBoxTextBox.Text) != 0 && manufacturerTextBox.Text != "" && pricePBoxTextBox.Text != "" && Convert.ToInt32(pricePBoxTextBox.Text) != 0)
            {
                //------------------------------------------------------------------------------------------------
                a.editDatabase
                    ("warehouse_table", "product_quantity = '" + quantityTextBox.Text + "', product_qtypbox = '" + quantityPBoxTextBox.Text + "', product_pricepbox = '" + pricePBoxTextBox.Text + "', product_manufacturer = '" + manufacturerTextBox.Text + "'", "product_name", productNameComboBox.Text);

                string date = System.DateTime.Now.ToString();
                a.addInDatabase("log_table", "dateti,actions,what", "'" + date + "','Updated Product','" + productNameComboBox.Text + "'");
                this.NavigationService.GoBack();
            }
            else
            {

                if (x.Items.Count == i)
                    productNameComboBox.BorderBrush = Brushes.Red;

                if (manufacturerTextBox.Text.Length != 10)
                    manufacturerTextBox.BorderBrush = Brushes.Red;

                if (quantityPBoxTextBox.Text == "")
                    quantityPBoxTextBox.BorderBrush = Brushes.Red;

                if (pricePBoxTextBox.Text == "")
                    pricePBoxTextBox.BorderBrush = Brushes.Red;

                errorMessage.Text = "Enter Valid Info...!!";
            }


        }

    }
}
