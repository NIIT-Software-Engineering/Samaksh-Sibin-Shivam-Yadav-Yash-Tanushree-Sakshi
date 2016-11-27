using System;
using System.Collections.Generic;
using System.Data;
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
    /// Interaction logic for ledgerPage.xaml
    /// </summary>
    public partial class ledgerPage : Page
    {
        public ledgerPage()
        {
            InitializeComponent();
       
        }

        private void ledgerDataGrid_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            DataRowView drv = (DataRowView)ledgerDataGrid.SelectedItem;
            String result = (drv["bill_id"]).ToString();
            //MessageBox.Show(result);

            this.NavigationService.Navigate(new ledgerBillSelectedPage(result));
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            
               ledgerSearchTextBox.Text = "Search";
               string cmd = "SELECT * FROM bill_table WHERE bill_status = 'Delivered';";
               accessDatabase a = new accessDatabase();
               ledgerDataGrid.DataContext = a.loadGrid(cmd);
            
            
        }

     

        private void ledgerSearchTextBox_LostFocus(object sender, RoutedEventArgs e)
        {
            if (ledgerSearchTextBox.Text == "" || ledgerSearchTextBox.Text == "Search")
            {
                string cmd = "SELECT * FROM bill_table WHERE bill_status = 'Delivered';";
                accessDatabase a = new accessDatabase();
                ledgerDataGrid.DataContext = a.loadGrid(cmd);
            }
            else
            {
                string cmd = "SELECT * FROM bill_table WHERE bill_status = 'Delivered' AND ((bill_id LIKE '%" + ledgerSearchTextBox.Text + "%') OR (bill_customer_name LIKE '%" + ledgerSearchTextBox.Text + "%') OR (bill_date LIKE '%" + ledgerSearchTextBox.Text + "%'));";
                accessDatabase a = new accessDatabase();
                ledgerDataGrid.DataContext = a.loadGrid(cmd);
            }
        }
    }
}
