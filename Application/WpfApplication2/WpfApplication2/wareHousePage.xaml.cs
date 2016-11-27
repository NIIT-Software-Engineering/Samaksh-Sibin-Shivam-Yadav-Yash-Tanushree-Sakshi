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
    /// Interaction logic for wareHousePage.xaml
    /// </summary>
    public partial class wareHousePage : Page
    {
        public wareHousePage()
        {
            InitializeComponent();
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            wareHouseSearch.Text = "Search";
            accessDatabase a = new accessDatabase();
            wareHouseDataGrid.DataContext = a.loadGrid("SELECT * FROM wareHouse_table");
        }

        private void addProductButton_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new addProductPage());
        }

        private void refillProductButton_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new refillProductPage());
        }

        private void updateProductButton_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new updateProductPage());
        }

        private void wareHouseSearch_LostFocus(object sender, RoutedEventArgs e)
        {
            if (wareHouseSearch.Text == "" || wareHouseSearch.Text == "Search")
            {
                string cmd = "SELECT* FROM wareHouse_table";
                accessDatabase a = new accessDatabase();
                wareHouseDataGrid.DataContext = a.loadGrid(cmd);
            }
            else
            {
                string cmd = "SELECT * FROM warehouse_table WHERE (product_name LIKE '%" + wareHouseSearch.Text + "%') OR (product_manufacturer LIKE '%" + wareHouseSearch.Text + "%');";
                accessDatabase a = new accessDatabase();
                wareHouseDataGrid.DataContext = a.loadGrid(cmd);
            }
        }
    }
}
