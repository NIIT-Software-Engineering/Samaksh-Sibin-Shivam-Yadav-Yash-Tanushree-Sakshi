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
    /// Interaction logic for addProductPage.xaml
    /// </summary>
    public partial class addProductPage : Page
    {  

        private void NumberValidationTextBox(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9]+");
            e.Handled = regex.IsMatch(e.Text);           
        }

        public addProductPage()
        {
            InitializeComponent();
        }

          

        private void saveNewProductButton_Click(object sender, RoutedEventArgs e)
        {
            if (productNameTextBox.Text != "" && quantityPBoxTextBox.Text != "" && quantityTextBox .Text != "" && Convert.ToInt32(quantityPBoxTextBox.Text) != 0 && manufacturerTextBox.Text != "" && pricePBoxTextBox.Text != "" && Convert.ToInt32(pricePBoxTextBox.Text) != 0)
            {
                accessDatabase a = new accessDatabase();
                if (a.checkInDatabase("customer_table", "store_name", productNameTextBox.Text))
                {
                    errorMessage.Text = "Product Already Exists!!!!!!";
                }
                else
                {

                    a.addInDatabase("warehouse_table", "product_name, product_quantity, product_pricepbox, product_manufacturer, product_qtypbox", "'" + productNameTextBox.Text + "','" + quantityTextBox.Text + "','" + pricePBoxTextBox.Text + "','" + manufacturerTextBox.Text + "','" + quantityPBoxTextBox.Text +"'");
                    string date = System.DateTime.Now.ToString();
                    a.addInDatabase("log_table", "dateti,actions,what", "'" + date + "','Added New Product','" + productNameTextBox.Text + "'");
                    this.NavigationService.GoBack();
                }
            }

            else
            {
                if (productNameTextBox.Text == "")
                    productNameTextBox.BorderBrush = Brushes.Red;

                if (quantityPBoxTextBox.Text == "" || quantityPBoxTextBox.Text == "0")
                    quantityPBoxTextBox.BorderBrush = Brushes.Red;

                if (quantityTextBox.Text == "")
                    quantityTextBox.BorderBrush = Brushes.Red;

                if (manufacturerTextBox.Text == "")
                    manufacturerTextBox.BorderBrush = Brushes.Red;

                if (pricePBoxTextBox.Text == "" || pricePBoxTextBox.Text == "0")
                    pricePBoxTextBox.BorderBrush = Brushes.Red;

                errorMessage.Text = "Invalid Entries..!!";
            }
        }
    }
}
