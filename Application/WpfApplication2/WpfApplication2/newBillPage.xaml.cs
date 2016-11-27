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
using System.Text.RegularExpressions;


namespace WpfApplication2
{
    /// <summary>
    /// Interaction logic for newBillPage.xaml
    /// </summary>
    /// 

    public class productClass
    {
        public string productName { get; set; }
        public int quantity { get; set; }
        public int amtPBox { get; set; }
        public int amt { get; set; }
    }

    public partial class newBillPage : Page
    {
        private float totalAmt;
        public static accessDatabase a = new accessDatabase();
        private ComboBox x = a.comboBoxfillDatabase("warehouse_table", 0);
        private ComboBox y = a.comboBoxfillDatabase("customer_table", 0);
        private string[] products = new string[30];
        private int[] quantity = new int[30];
        private int proNum = 0;
        private int[] amtList = new int[30];
        private int[] amtPProductList = new int[30];


        private void billIDLabel_Init()
        {

            char[] dateArray = System.DateTime.Now.ToShortDateString().ToCharArray();
           

            char[] trimArray = new char[6];
            trimArray[0] = dateArray[0];
            trimArray[1] = dateArray[1];
            trimArray[2] = dateArray[3];
            trimArray[3] = dateArray[4];
            trimArray[4] = dateArray[8];
            trimArray[5] = dateArray[9];
            string trimTodayDate = new string(trimArray);

            if (a.checkInDatabase("info", "id", "lastbillid"))
            {
                
                char[] lastEntryId = a.getRowDatabase("info", 1, "id", "lastbillid").ToCharArray();
           
                char[] lastEntryDate = new char[6];
                for (int i = 0, k = 2; k < 8; i++, k++)
                    lastEntryDate[i] = lastEntryId[k];

                char[] lastEntryEnd = new char[5];
                for (int i = 0, k = 8; k < 10; i++, k++)
                    lastEntryEnd[i] = lastEntryId[k];

               
                //string lastEntryId = a.getRowDatabase("info", 1, "id", "1");
               
                if (trimTodayDate == new string(lastEntryDate))
                {             
                    int abc = Convert.ToInt32(new string(lastEntryEnd));
                    abc++;
                    char[] ab = new char[2];
                    if (abc < 10)
                    {
                        
                        char[] c    = abc.ToString().ToCharArray();
                        ab[0] = '0';
                        ab[1] = c[0];
                    }
                        billIDLabel.Content = "GG" + trimTodayDate + new string(ab);
                }
                else
                    billIDLabel.Content = "GG" + trimTodayDate + "00";
                
               
                //a.editDatabase("info", "lastbill_id ='" + billIDLabel.Content + "'", "id", "1");
            }
            else
            {
                billIDLabel.Content = "GG" + trimTodayDate + "00";
                // a.editDatabase("info", "lastbill_id ='" + billIDLabel.Content + "'", "id", "1");
            }
        }

        private void NumberValidationTextBox(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9]+");
            e.Handled = regex.IsMatch(e.Text);
        }

        private void taxNumberValidationTextBox(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9/.]+");
            e.Handled = regex.IsMatch(e.Text);
        }

        private void productNameComboBox_Fill()
        {

            productNameComboBox.Items.Clear();
            int len = x.Items.Count;

            for (int i = 0; i < len; i++)
            {
                string tem = x.Items[i].ToString();
                productNameComboBox.Items.Add(x.Items[i]);
            }
        }

        private void storeNameComboBox_Fill()
        {

            storeNameComboBox.Items.Clear();
            int len = y.Items.Count;

            for (int i = 0; i < len; i++)
            {
                string tem = y.Items[i].ToString();
                storeNameComboBox.Items.Add(y.Items[i]);
            }
        }

        public newBillPage()
        {
            InitializeComponent();
            totalAmt = 0;
            totalAmountLabel.Content = totalAmt.ToString();
        }

       

        private void addProductButton_Click(object sender, RoutedEventArgs e)
        {
            int i;
            for (i = 0; i < x.Items.Count; i++)
                if (productNameComboBox.Text == x.Items[i].ToString())
                    break;

            if (x.Items.Count != i && quantityTextBox.Text != "" && Convert.ToInt32(quantityTextBox.Text) != 0)
            {
                products[proNum] = productNameComboBox.Text;
                quantity[proNum] = Convert.ToInt32(quantityTextBox.Text);


                string x = a.getRowDatabase("warehouse_table", 2, "product_name", productNameComboBox.Text);
                amtPProductList[proNum] = Convert.ToInt32(x);
                amtList[proNum] = amtPProductList[proNum] * quantity[proNum];

                totalAmt = totalAmt + amtList[proNum];
                totalAmountLabel.Content = totalAmt.ToString();
                productGrid.Items.Add(new productClass { productName = products[proNum], quantity = quantity[proNum], amtPBox = amtPProductList[proNum], amt = amtList[proNum] });
                proNum++;

                if (proNum == 1)
                    removePreviousEntry.IsEnabled = true;
                if (taxTextBox.Text != "")
                    taxAmountLabel.Content = Convert.ToDouble(totalAmountLabel.Content) * (Convert.ToDouble(taxTextBox.Text) / 100) + Convert.ToDouble(totalAmountLabel.Content);



            }
            else
                MessageBox.Show("Enter Valid Product and Quantity should not be equal to 0.");
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            productNameComboBox_Fill();
            storeNameComboBox_Fill();
            dateTimeLabel.Content = System.DateTime.Now.ToString();
            billIDLabel_Init();
        }

        private void removePreviousEntry_Click(object sender, RoutedEventArgs e)
        {
            proNum--;
            totalAmt = totalAmt - amtList[proNum];
            totalAmountLabel.Content = totalAmt.ToString();
            productGrid.Items.RemoveAt(proNum);
            if (proNum == 0)
                removePreviousEntry.IsEnabled = false;
            if (taxTextBox.Text != "")
                taxAmountLabel.Content = Convert.ToDouble(totalAmountLabel.Content) * (Convert.ToDouble(taxTextBox.Text) / 100) + Convert.ToDouble(totalAmountLabel.Content);
        }

        private void taxTextBox_LostFocus(object sender, RoutedEventArgs e)
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

        private void cancelButton_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.GoBack();
        }

        private void doneButton_Click(object sender, RoutedEventArgs e)
        {
            int i;
            for (i = 0; i < y.Items.Count; i++)
                if (storeNameComboBox.Text == y.Items[i].ToString())
                    break;

            if (y.Items.Count != i && taxTextBox.Text != "" && taxTextBox.Text != "0" && proNum > 0 && storeNameComboBox.Text != "")
            {
                a.addInDatabase("bill_table", "bill_id,bill_customer_name,bill_date,bill_amt,bill_amtdue,bill_tax", "'" + billIDLabel.Content + "','" + storeNameComboBox.Text + "','" + dateTimeLabel.Content + "','" + taxAmountLabel.Content + "','" + taxAmountLabel.Content + "','"+ taxTextBox.Text +"'");
                for (int m = 0; m < proNum; m++)
                    a.addInDatabase("billxproduct_table", "bill_id, product_name, product_qty, pricepproduct, amount", "'" + billIDLabel.Content + "','" + products[m] + "','" + quantity[m] + "','" + amtPProductList[m] + "','"+ amtList[m]+"'");
                if (a.checkInDatabase("info", "id", "lastbillid"))
                {
                    a.editDatabase("info", "datavalue = '" + billIDLabel.Content + "'", "id", "lastbillid");
                }
                else
                    a.addInDatabase("info", "id, datavalue", "'lastbillid','" + billIDLabel.Content + "'");

                string date = System.DateTime.Now.ToString();
                a.addInDatabase("log_table", "dateti,actions,what", "'" + date + "','New Bill','" + billIDLabel.Content + "'");
                this.NavigationService.GoBack();
            }
            else
                MessageBox.Show("Enter Valid Details..");
        }
    }
}