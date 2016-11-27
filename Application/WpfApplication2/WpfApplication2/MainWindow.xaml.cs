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




//SELECT *





namespace WpfApplication2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public class accessDatabase  // class which contains funcs to accessdatabase
    {
        private string password = "1234";

        public DataSet loadGrid(string command)         //FUNCTION for loading data from grid
        {
            try
            {
                string connStr =
                    "server=localhost;user=root;database=sukinome_database;port=3306;password=" + password;
                MySqlConnection conn = new MySqlConnection(connStr);
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(command, conn);
                MySqlDataAdapter adp = new MySqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adp.Fill(ds, "LoadDataBinding");
                conn.Close();
                return ds;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
            
        }

        public bool checkInDatabase(string table, string column1, string value1, string column2 = "", string value2 = "")
        {

            try
            {
                string connStr =
                "server=localhost;user=root;database=sukinome_database;port=3306;password=" + password;
                MySqlConnection conn = new MySqlConnection(connStr);

                MySqlCommand myCommand = conn.CreateCommand();
                if (column2 != "")
                {
                    myCommand.CommandText = "SELECT * FROM " + table + " WHERE " + column1 + " = '" + value1 + "' AND " + column2 + " = '" + value2 + "';";
                }
                else
                {
                    myCommand.CommandText = "SELECT * FROM " + table + " WHERE " + column1 + " = '" + value1 + "';";
                }
                conn.Open();

                MySqlDataReader myLoginReader = myCommand.ExecuteReader();

                if (myLoginReader.Read())
                {
                    conn.Close();
                    return true;
                }
                else
                {
                    conn.Close();
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }

        }

        public void addInDatabase(string table, string columns, string values)
        {
            try
            {
                string connStr =
                    "server=localhost;user=root;database=sukinome_database;port=3306;password=" + password;
                MySqlConnection conn = new MySqlConnection(connStr);
                MySqlCommand command = conn.CreateCommand();
                command.CommandText = "INSERT INTO " + table + " (" + columns + ") VALUES (" + values + ");";
                //command.Parameters.AddWithValue("?name", mitarbeiter);
                conn.Open();
                command.ExecuteNonQuery();
                conn.Close();
               // MessageBox.Show("Database Updated, Successfully!");
               // string sdate = System.DateTime.Now.ToString());
                //addInDatabase("masterlog_table","date","'"+ sdate +"'");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);            
            }
        }

        public ComboBox comboBoxfillDatabase(string table, int columnNo )
        {
            try
            {
                ComboBox temp = new ComboBox();
                string connStr =
                    "server=localhost;user=root;database=sukinome_database;port=3306;password=" + password;
                MySqlConnection conn = new MySqlConnection(connStr);
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM "+ table, conn);
                MySqlDataReader myReader = cmd.ExecuteReader();
                
                while(myReader.Read())
                {
                    string value = myReader.GetString(columnNo);
                    temp.Items.Add(value);
                  
                }
                conn.Close();
                return temp;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }

        public void editDatabase(string table, string updateColumnValue, string whichColumn, string whichValue)
        {
            try
            {
                ComboBox temp = new ComboBox();
                string connStr =
                    "server=localhost;user=root;database=sukinome_database;port=3306;password=" + password;
                MySqlConnection conn = new MySqlConnection(connStr);
                conn.Open();
                MySqlCommand cmd = new MySqlCommand
                    ("UPDATE " + table + " SET "+ updateColumnValue +" WHERE "+ whichColumn +" = '"+ whichValue +"';", conn);
                cmd.ExecuteNonQuery();
                conn.Close();
               // MessageBox.Show("Operation Successfull!, Database has been Updated..");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);              
            }
        }

        public string getRowDatabase(string table, int columnNo, string whichColumn, string whichValue)
        {
            try
            {
                string connStr =
                    "server=localhost;user=root;database=sukinome_database;port=3306;password=" + password;
                MySqlConnection conn = new MySqlConnection(connStr);
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM " + table + " WHERE " + whichColumn + " = '" + whichValue +"';", conn);
                MySqlDataAdapter adp = new MySqlDataAdapter(cmd);
                MySqlDataReader myReader = cmd.ExecuteReader();
                myReader.Read();
                return myReader.GetString(columnNo);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }
       
    }  
  
  
                                                                                                                                                                                                                                                                                                                                           
    public partial class MainWindow : Window
    {
        private int nav = 0;
        public MainWindow()
        {
            InitializeComponent();

            myFrame.Source = (new Uri("loginPage.xaml", UriKind.Relative));
        }

        private void myFrame_Navigated(object sender, NavigationEventArgs e)
        {

           
            if (nav == 1)
            {
                tabGrid.Visibility = Visibility.Visible;
                myFrame.NavigationService.RemoveBackEntry();
            }
            //headingText.Text = myFrame.NavigationService.Content.ToString();
            nav++;
            
            

        }

        private void homeButton_Click(object sender, RoutedEventArgs e)
        {
            if (myFrame.NavigationService.Content.ToString() == "WpfApplication2.homePage")
                myFrame.NavigationService.Refresh();
            else
                myFrame.Navigate(new homePage());
            mainWindow.Title = "Home";
        }

        private void billBookButton_Click(object sender, RoutedEventArgs e)
        {
            if (myFrame.NavigationService.Content.ToString() == "WpfApplication2.billBookPage")
                myFrame.NavigationService.Refresh();
            else
                myFrame.Navigate(new billBookPage());
            mainWindow.Title = "Bill Book";

        }

        private void wareHouseButton_Click(object sender, RoutedEventArgs e)
        {
            if (myFrame.NavigationService.Content.ToString() == "WpfApplication2.wareHousePage")
                myFrame.NavigationService.Refresh();
            else
                myFrame.Navigate(new wareHousePage());
            mainWindow.Title = "Ware House";

        }

        private void customerButton_Click(object sender, RoutedEventArgs e)
        {
            if (myFrame.NavigationService.Content.ToString() == "WpfApplication2.customerPage")
                myFrame.NavigationService.Refresh();
                
            else
                myFrame.Navigate(new customerPage());
            mainWindow.Title = "Customer";
           // customerButton.IsEnabled = false;
        }

        private void supplyButton_Click(object sender, RoutedEventArgs e)
        {
            if (myFrame.NavigationService.Content.ToString() == "WpfApplication2.supplyPage")
                myFrame.NavigationService.Refresh();

            else
                myFrame.Navigate(new supplyPage());
            mainWindow.Title = "Supply";
        }

        private void ledgerButton_Click(object sender, RoutedEventArgs e)
        {
            if (myFrame.NavigationService.Content.ToString() == "WpfApplication2.ledgerPage")
                myFrame.NavigationService.Refresh();
            else
                myFrame.Navigate(new ledgerPage());
            mainWindow.Title = "Ledger";
        }

        private void logButton_Click(object sender, RoutedEventArgs e)
        {
            if (myFrame.NavigationService.Content.ToString() == "WpfApplication2.masterLogPage")
                myFrame.NavigationService.Refresh();

            else
                myFrame.Navigate(new masterLogPage());
            mainWindow.Title = "Master Log";
        }
    }
}

