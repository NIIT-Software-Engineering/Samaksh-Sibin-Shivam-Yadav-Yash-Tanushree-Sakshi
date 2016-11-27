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
    /// Interaction logic for addCustomerPage.xaml
    /// </summary>
    public partial class addCustomerPage : Page
    {
        private void NumberValidationTextBox(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9]+");
            e.Handled = regex.IsMatch(e.Text);         
        }

        public addCustomerPage()
        {
            InitializeComponent();
        }

        private void CharValidationTextBox(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^A-z]+");
            e.Handled = regex.IsMatch(e.Text);

        }

        private void saveNewCustomerButton_Click(object sender, RoutedEventArgs e)
        {
            if (mobileTextBox.Text.Length == 10 && storeNameTextBox.Text != "" && ownerTextBox.Text != "" && addressTextBox.Text != "")
            {
                accessDatabase a = new accessDatabase();
                if (a.checkInDatabase("customer_table", "store_name", storeNameTextBox.Text))
                {
                    errorMessage.Text = "Store Already Exists!!!!!!";
                }
                else
                {
                    
                    a.addInDatabase("customer_table", "store_name, store_owner, store_mobile, store_address, store_email", "'"+ storeNameTextBox.Text +"','"+ ownerTextBox.Text + "','"+ mobileTextBox.Text + "','"+ addressTextBox.Text + "','"+ emailTextBox.Text +"'");
                    string date = System.DateTime.Now.ToString();
                    a.addInDatabase("log_table", "dateti,actions,what", "'" + date + "','Added New Custoner','" + storeNameTextBox.Text + "'");

                    this.NavigationService.GoBack();
                }
            }

            else
            {
                if (mobileTextBox.Text.Length != 10)
                    mobileTextBox.BorderBrush = Brushes.Red;

                if (storeNameTextBox.Text == "")
                    storeNameTextBox.BorderBrush = Brushes.Red;

                if (ownerTextBox.Text == "")
                    ownerTextBox.BorderBrush = Brushes.Red;

                if (addressTextBox.Text == "")
                    addressTextBox.BorderBrush = Brushes.Red;

                errorMessage.Text = "Invalid Entries..!!";
            }         
        }
    }
}
