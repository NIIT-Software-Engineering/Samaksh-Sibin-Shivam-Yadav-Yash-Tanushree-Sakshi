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
using Microsoft.VisualBasic;
using System.Text.RegularExpressions;

namespace WpfApplication2
{
    /// <summary>
    /// Interaction logic for ledgerBillSelectedPage.xaml
    /// </summary>
    public partial class ledgerBillSelectedPage : Page
    {
        private accessDatabase a = new accessDatabase();
        private string billId;

        public ledgerBillSelectedPage(string billNo)
        {
            InitializeComponent();
            billId = billNo;
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            
            billIDLabel.Content = billId;
            storeNameTextBox.Text = a.getRowDatabase("bill_table", 1, "bill_id", billId);
            taxTextBox.Text = a.getRowDatabase("bill_table", 6, "bill_id", billId);
            taxAmountLabel.Content = a.getRowDatabase("bill_table", 2, "bill_id", billId);
            totalAmountLabel.Content = (Convert.ToDouble(taxAmountLabel.Content) * 100 / (100 + Convert.ToDouble(taxTextBox.Text))).ToString();
            dateTimeLabel.Content = a.getRowDatabase("bill_table", 3, "bill_id", billId);
            AmtMessageTextBlock.Text = a.getRowDatabase("bill_table", 5, "bill_id", billId);


            string k = a.getRowDatabase("bill_table", 4, "bill_id", billId);


                statusLabel.Content = "Delivered";
                statusLabel.Foreground = Brushes.Orange;
            
         


            string cmd = "SELECT * FROM billxproduct_table WHERE bill_id = '" + billId + "';";
            //accessDatabase a = new accessDatabase();
            ledgerSelectGrid.DataContext = a.loadGrid(cmd);

        }

        private void NumberValidationTextBox(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9/.]+");
            e.Handled = regex.IsMatch(e.Text);
        }




        private void payButton_Click(object sender, RoutedEventArgs e)
        {
            double due = Convert.ToDouble(AmtMessageTextBlock.Text);
            double pay = Convert.ToDouble(AmtPayTextBox.Text);
            if (due >= pay)
            {
                

                if (due == pay)
                {
                    due = due - pay;
                    a.editDatabase("bill_table", "bill_status = 'Completed', bill_amtdue = '0'", "bill_id", billId);
                    string date = System.DateTime.Now.ToString();
                    a.addInDatabase("log_table", "dateti,actions,what", "'" + date + "','Completed Bill','" + billId + "'");
                }
                else
                {
                    due = due - pay;
                    a.editDatabase("bill_table", "bill_amtdue = '" + due + "'", "bill_id", billId);
                    string date = System.DateTime.Now.ToString();
                    a.addInDatabase("log_table", "dateti,actions,what", "'" + date + "','Partial Bill Payment','" + billId + " Amount = "+ pay.ToString()+"'");
                }
                this.NavigationService.GoBack();

            }
            else
                MessageBox.Show("Payment connot exceed Due Amount!!", "error");
            AmtPayTextBox.Text = "";
        }

        private void AmtPayTextBox_LostFocus(object sender, RoutedEventArgs e)
        {
            double km = new double();
            if (Double.TryParse(taxTextBox.Text, out km))
            {
                taxAmountLabel.Content = (Convert.ToDouble(totalAmountLabel.Content) * (km / 100) + Convert.ToDouble(totalAmountLabel.Content)).ToString();

            }
            else
            {
                MessageBox.Show("Invalid tax%");
                taxTextBox.Text = "";
            }
        }

        private void backButton_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.GoBack();
        }
    }
}
