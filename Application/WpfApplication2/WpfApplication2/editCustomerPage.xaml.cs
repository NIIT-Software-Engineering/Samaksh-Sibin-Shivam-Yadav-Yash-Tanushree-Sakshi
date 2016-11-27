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
    /// Interaction logic for editCustomerPage.xaml
    /// </summary>
    public partial class editCustomerPage : Page
    {
        public static accessDatabase a = new accessDatabase();
        private ComboBox x = a.comboBoxfillDatabase("customer_table", 0);

        private void NumberValidationTextBox(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9]+");
            e.Handled = regex.IsMatch(e.Text);
        }

        private void storeNameComboBox_Fill()
        {

            storeNameComboBox.Items.Clear();
            int len = x.Items.Count;

            for (int i = 0; i < len; i++)
            {
                string tem = x.Items[i].ToString();
                storeNameComboBox.Items.Add(x.Items[i]);
            }
        }

        private void CharValidationTextBox(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^A-z]+");
            e.Handled = regex.IsMatch(e.Text);
        }

        public editCustomerPage()
        {
            InitializeComponent();
        }

        private void editProductButton_Click(object sender, RoutedEventArgs e)
        {
            //if (mobileTextBox.Text.Length == 10 && storeNameComboBox.Text != "" && ownerTextBox.Text != "" && addressTextBox.Text != "")
            int i;
            for (i = 0; i < x.Items.Count; i++)
                if (storeNameComboBox.Text == x.Items[i].ToString())
                    break;

            if (x.Items.Count != i && mobileTextBox.Text.Length == 10 && storeNameComboBox.Text != "" && ownerTextBox.Text != "" && addressTextBox.Text != "")
            {
                //------------------------------------------------------------------------------------------------
                a.editDatabase
                    ("customer_table", "store_mobile = '" + mobileTextBox.Text + "', store_owner = '" + ownerTextBox.Text + "', store_address = '" + addressTextBox.Text + "', store_email = '" + emailTextBox.Text + "'", "store_name", storeNameComboBox.Text);

                string date = System.DateTime.Now.ToString();
                a.addInDatabase("log_table", "dateti,actions,what", "'" + date + "','Updated Customer','" + storeNameComboBox.Text + "'");
                this.NavigationService.GoBack();
            }
            else
            {

                if(x.Items.Count == i)
                    storeNameComboBox.BorderBrush = Brushes.Red;

                if (mobileTextBox.Text.Length != 10)
                    mobileTextBox.BorderBrush = Brushes.Red;

                if (ownerTextBox.Text == "")
                    ownerTextBox.BorderBrush = Brushes.Red;

                if (addressTextBox.Text == "")
                    addressTextBox.BorderBrush = Brushes.Red;

                errorMessage.Text = "Enter Valid Info...!!";
            }


        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            storeNameComboBox_Fill();
        }

        private void storeNameComboBox_LostFocus(object sender, RoutedEventArgs e)
        {
            int i;
            for (i = 0; i < x.Items.Count; i++)
                if (storeNameComboBox.Text == x.Items[i].ToString())
                    break;
            if (x.Items.Count != i)
            {
                //------------------------------------------------------------------------------------------------
                ownerTextBox.Text = a.getRowDatabase("customer_table", 1, "store_name", storeNameComboBox.Text).ToString();
                mobileTextBox.Text = a.getRowDatabase("customer_table", 2, "store_name", storeNameComboBox.Text).ToString();
                addressTextBox.Text = a.getRowDatabase("customer_table", 3, "store_name", storeNameComboBox.Text).ToString();
                emailTextBox.Text = a.getRowDatabase("customer_table", 4, "store_name", storeNameComboBox.Text).ToString();

                errorMessage.Text = "";
                //this.NavigationService.GoBack();
            }
            else
                errorMessage.Text = "Invalid Store Name!!!!!!";
        }
    }
}
