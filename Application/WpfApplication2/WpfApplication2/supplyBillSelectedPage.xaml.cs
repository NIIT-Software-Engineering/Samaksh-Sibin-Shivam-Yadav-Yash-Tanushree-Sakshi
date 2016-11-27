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
using MySql.Data;
using MySql.Data.MySqlClient;


namespace WpfApplication2
{
    /// <summary>
    /// Interaction logic for supplyBillSelectedPage.xaml
    /// </summary>
    public partial class supplyBillSelectedPage : Page
    {
        private accessDatabase a = new accessDatabase();
        private string billId;

        public supplyBillSelectedPage(string billNo)
        {
            InitializeComponent();

            billId = billNo;

        }

        private void doneButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                string connStr =
                    "server=localhost;user=root;database=sukinome_database;port=3306;password=1234";
                MySqlConnection conn = new MySqlConnection(connStr);
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM billxproduct_table a INNER JOIN warehouse_table b ON a.product_name = b.product_name WHERE bill_id = '" + billId + "';", conn);
                MySqlDataAdapter adp = new MySqlDataAdapter(cmd);
                MySqlDataReader myReader = cmd.ExecuteReader();
             
                while(myReader.Read())
                {
                    string pro = myReader.GetString(1);
                    int old = Convert.ToInt32(myReader.GetString(6));
                    int x = Convert.ToInt32(myReader.GetString(2));
                    old = old - x;
                    a.editDatabase("warehouse_table", "product_quantity = '" + old.ToString() + "'", "product_name", pro);
                }
                //return myReader.GetString();
                a.editDatabase("bill_table", "bill_status = 'Delivered'", "bill_id", billId);
                string date = System.DateTime.Now.ToString();
                a.addInDatabase("log_table", "dateti,actions,what", "'" + date + "','Supplied Bill','" + billId + "'");
                this.NavigationService.GoBack();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                //return null;
            }  

        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            billIDLabel.Content = billId;
            storeNameTextBox.Text = a.getRowDatabase("bill_table", 1, "bill_id", billId);
            taxTextBox.Text = a.getRowDatabase("bill_table", 6, "bill_id", billId);
            taxAmountLabel.Content = a.getRowDatabase("bill_table", 2, "bill_id", billId);
            totalAmountLabel.Content = (Convert.ToDouble(taxAmountLabel.Content) * 100 / (100 + Convert.ToDouble(taxTextBox.Text))).ToString();
            dateTimeLabel.Content = a.getRowDatabase("bill_table", 3, "bill_id", billId);
            string k = a.getRowDatabase("bill_table", 4, "bill_id", billId);

    
                statusLabel.Content = "Created";
                statusLabel.Foreground = Brushes.Blue;
       


            string cmd = "SELECT * FROM billxproduct_table a INNER JOIN warehouse_table b ON a.product_name = b.product_name WHERE bill_id = '" + billId + "';";
            //accessDatabase a = new accessDatabase();
            supplyProductGrid.DataContext = a.loadGrid(cmd);

            //a.checkInDatabase("")


            try
            {
                string connStr = "server=localhost;user=root;database=sukinome_database;port=3306;password=1234";
                MySqlConnection conn = new MySqlConnection(connStr);

                MySqlCommand myCommand = conn.CreateCommand();

                myCommand.CommandText = "SELECT * FROM billxproduct_table a INNER JOIN warehouse_table b ON a.product_name = b.product_name WHERE (product_qty > product_quantity) AND bill_id = '" + billId + "';";

                conn.Open();


                MySqlDataReader myLoginReader = myCommand.ExecuteReader();



                if (myLoginReader.Read())
                {
                    supplyButton.IsEnabled = false;
                    errorMessageTextBlock.Text = "*Cannot Supply A Products required Quantity excedes the Quantity in WareHouse";
                }
                else
                {
                    // MessageBox.Show("can supply");
                    supplyButton.IsEnabled = true;
                    errorMessageTextBlock.Text = "";
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void backButton_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.GoBack();
        }

        private void cancelButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult messageBoxResult = System.Windows.MessageBox.Show("Cancel Bill No : " + billId + " ?","Are you sure?", System.Windows.MessageBoxButton.YesNo);
            if (messageBoxResult == MessageBoxResult.Yes)
            {
                a.editDatabase("bill_table", "bill_status = 'Canceled'", "bill_id", billId);

                string date = System.DateTime.Now.ToString();
                a.addInDatabase("log_table", "dateti,actions,what", "'" + date + "','Canceled Bill','" + billId + "'");
                this.NavigationService.GoBack();
            }
           
        }
    }
}
