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

namespace WpfApplication2
{
    /// <summary>
    /// Interaction logic for masterLogPage.xaml
    /// </summary>
    public partial class masterLogPage : Page
    {
        public masterLogPage()
        {
            InitializeComponent();
        }

        private void logSearchTextBox_LostFocus(object sender, RoutedEventArgs e)
        {
            if (logSearchTextBox.Text == "" || logSearchTextBox.Text == "Search")
            {
                string cmd = "SELECT * FROM log_table;";
                accessDatabase a = new accessDatabase();
                logDataGrid.DataContext = a.loadGrid(cmd);
            }
            else
            {
                string cmd = "SELECT * FROM log_table WHERE (actions LIKE '%" + logSearchTextBox.Text + "%' OR dateti LIKE '%" + logSearchTextBox.Text + "%' OR what LIKE '%" + logSearchTextBox.Text + "%');";
                //string cmd = "SELECT * FROM customer_table WHERE (store_name LIKE '%" + customerSearchTextBox.Text + "%') OR ( store_owner LIKE '%" + customerSearchTextBox.Text + "%') OR (store_mobile LIKE '%" + customerSearchTextBox.Text + "%') OR (store_address LIKE '%" + customerSearchTextBox.Text + "%') OR (store_email LIKE '%" + customerSearchTextBox.Text + "%');";
                //string cmd = "SELECT * FROM bill_table WHERE bill_status = 'Created' AND ((bill_id LIKE '%" + supplySearchTextBox.Text + "%') OR (bill_customer_name LIKE '%" + supplySearchTextBox.Text + "%') OR (bill_date LIKE '%" + supplySearchTextBox.Text + "%'));";
                accessDatabase a = new accessDatabase();
                logDataGrid.DataContext = a.loadGrid(cmd);
            }
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            logSearchTextBox.Text = "Search";
            string cmd = "SELECT * FROM log_table;";
            accessDatabase a = new accessDatabase();
            logDataGrid.DataContext = a.loadGrid(cmd);
        }
    }
}
