using System;
using System.Data;
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
using MySql.Data;
using MySql.Data.MySqlClient;

namespace WpfApplication2
{
    /// <summary>
    /// Interaction logic for billBookPage.xaml
    /// </summary>
    public partial class billBookPage : Page
    {
        public billBookPage()
        {
            InitializeComponent();
        }

        private void newBillButton_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new newBillPage());
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            billBookSearch.Text = "Search";
            string cmd = "SELECT * FROM bill_table;";
            accessDatabase a = new accessDatabase();
            billBookDataGrid.DataContext = a.loadGrid(cmd);
            
        }

        private void billBookDataGrid_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            DataRowView drv = (DataRowView)billBookDataGrid.SelectedItem;
            String result = (drv["bill_id"]).ToString();
            //MessageBox.Show(result);

            this.NavigationService.Navigate(new billDetailPage(result));
        }

        private void billBookSearch_LostFocus(object sender, RoutedEventArgs e)
        {
            if (billBookSearch.Text == "" || billBookSearch.Text == "Search")
            {
                string cmd = "SELECT * FROM bill_table;";
                accessDatabase a = new accessDatabase();
                billBookDataGrid.DataContext = a.loadGrid(cmd);
            }
            else
            {
                string cmd = "SELECT * FROM bill_table WHERE (bill_status LIKE '%" + billBookSearch.Text + "%') OR (bill_id LIKE '%" + billBookSearch.Text + "%') OR (bill_customer_name LIKE '%"+ billBookSearch.Text + "%') OR (bill_date LIKE '%" + billBookSearch.Text + "%');";
                accessDatabase a = new accessDatabase();
                billBookDataGrid.DataContext = a.loadGrid(cmd);
            }
        }



        /* private void billBookDataGrid_LoadingRowDetails(object sender, DataGridRowDetailsEventArgs e)
         {
             DataRowView drv = (DataRowView)billBookDataGrid.SelectedItem;
             String result = (drv["bill_id"]).ToString();
             MessageBox.Show(result);
             string command = "SELECT * FROM billxproduct_table WHERE bill_id = '"+ result +"'";

             string connStr =
                     "server=localhost;user=root;database=sukinome_database;port=3306;password=1234";
             MySqlConnection conn = new MySqlConnection(connStr);
             conn.Open();
             MySqlCommand cmd = new MySqlCommand(command, conn);
             MySqlDataAdapter adp = new MySqlDataAdapter(cmd);
             DataSet ds = new DataSet();
             adp.Fill(ds, "LoadBinding");
             conn.Close();


         }*/
    }
}
