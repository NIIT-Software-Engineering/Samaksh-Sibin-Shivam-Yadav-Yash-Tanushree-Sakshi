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

namespace WpfApplication2
{
    /// <summary>
    /// Interaction logic for supplyPage.xaml
    /// </summary>
    public partial class supplyPage : Page
    {
        public supplyPage()
        {
            InitializeComponent();
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            supplySearchTextBox.Text = "Search";
            string cmd = "SELECT * FROM bill_table WHERE bill_status = 'Created';";
            accessDatabase a = new accessDatabase();
            supplyDataGrid.DataContext = a.loadGrid(cmd);
        }

        private void supplyDataGrid_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            
            DataRowView drv = (DataRowView)supplyDataGrid.SelectedItem;
            String result = (drv["bill_id"]).ToString();
            //MessageBox.Show(result);

            this.NavigationService.Navigate(new supplyBillSelectedPage(result));
        }

        private void supplySearchTextBox_LostFocus(object sender, RoutedEventArgs e)
        {
            if (supplySearchTextBox.Text == "" || supplySearchTextBox.Text == "Search")
            {
                string cmd = "SELECT * FROM bill_table WHERE bill_status = 'Created';";
                accessDatabase a = new accessDatabase();
                supplyDataGrid.DataContext = a.loadGrid(cmd);
            }
            else
            {
                string cmd = "SELECT * FROM bill_table WHERE bill_status = 'Created' AND ((bill_id LIKE '%" + supplySearchTextBox.Text + "%') OR (bill_customer_name LIKE '%" + supplySearchTextBox.Text + "%') OR (bill_date LIKE '%" + supplySearchTextBox.Text + "%'));";
                accessDatabase a = new accessDatabase();
                supplyDataGrid.DataContext = a.loadGrid(cmd);
            }
        }
    }
}
