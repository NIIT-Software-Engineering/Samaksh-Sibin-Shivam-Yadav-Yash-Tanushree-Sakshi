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
    /// Interaction logic for billDetailPage.xaml
    /// </summary>
    public partial class billDetailPage : Page
    {
        accessDatabase a = new accessDatabase();
        public billDetailPage(string billId)
        {
            InitializeComponent();

            billIDLabel.Content = billId;
            storeNameTextBox.Text = a.getRowDatabase("bill_table", 1, "bill_id", billId);
            taxTextBox.Text = a.getRowDatabase("bill_table", 6, "bill_id", billId);
            taxAmountLabel.Content = a.getRowDatabase("bill_table", 2, "bill_id", billId);
            totalAmountLabel.Content = (Convert.ToDouble(taxAmountLabel.Content)*100/(100 + Convert.ToDouble(taxTextBox.Text))).ToString();
            dateTimeLabel.Content = a.getRowDatabase("bill_table", 3, "bill_id", billId);
            string k = a.getRowDatabase("bill_table", 4, "bill_id", billId);
            if(k == "Created")
            {
                statusLabel.Content = "Created";
                statusLabel.Foreground = Brushes.Blue;
            }
            else if (k == "Delivered")
            {
                statusLabel.Content = "Delivered";
                statusLabel.Foreground = Brushes.Orange;
            }
            else if (k == "Completed")
            {
                statusLabel.Content = "Completed";
                statusLabel.Foreground = Brushes.Green;
            }
            else
            {
                statusLabel.Content = "Canceled";
                statusLabel.Foreground = Brushes.Gray;
            }


            string cmd = "SELECT * FROM billxproduct_table WHERE bill_id = '"+ billId +"';";
            //accessDatabase a = new accessDatabase();
            productGrid.DataContext = a.loadGrid(cmd);



        }

        private void doneButton_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.GoBack();
        }
    }
}
