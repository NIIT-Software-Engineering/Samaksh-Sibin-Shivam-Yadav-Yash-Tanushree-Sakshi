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
using System.Data;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace WpfApplication2
{
    /// <summary>
    /// Interaction logic for customerPage.xaml
    /// </summary>
    public partial class customerPage : Page
    {
        public customerPage()
        {
            InitializeComponent();                  
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            customerSearchTextBox.Text = "Search";
            accessDatabase a = new accessDatabase();
            customerDataGrid.DataContext = a.loadGrid("SELECT store_name,store_owner,store_mobile,store_address,store_email FROM customer_table;");

        }

        private void customerAddButton_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new addCustomerPage());
        }

        private void customerEditButton_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new editCustomerPage());
        }

        private void customerSearchTextBox_LostFocus(object sender, RoutedEventArgs e)
        {
            if (customerSearchTextBox.Text == "" || customerSearchTextBox.Text == "Search")
            {
                accessDatabase a = new accessDatabase();
                customerDataGrid.DataContext = a.loadGrid("SELECT store_name,store_owner,store_mobile,store_address,store_email FROM customer_table;");

            }
            else
            {
                string cmd = "SELECT store_name,store_owner,store_mobile,store_address,store_email FROM customer_table WHERE (store_name LIKE '%"+ customerSearchTextBox.Text +"%') OR ( store_owner LIKE '%"+ customerSearchTextBox.Text +"%') OR (store_mobile LIKE '%"+ customerSearchTextBox.Text + "%') OR (store_address LIKE '%" + customerSearchTextBox.Text + "%') OR (store_email LIKE '%" + customerSearchTextBox.Text + "%');";
                accessDatabase a = new accessDatabase();
                customerDataGrid.DataContext = a.loadGrid(cmd);
            }
        }
    }
}
