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
    /// Interaction logic for changeUserPasswordPage.xaml
    /// </summary>
    public partial class changeUserPasswordPage : Page
    {
        private accessDatabase a = new accessDatabase();
        public changeUserPasswordPage()
        {
            InitializeComponent();
            string usern = a.getRowDatabase("info", 1, "id", "username");
            if (usern != "userid1")
            {
                userNameTextBox.IsEnabled = false;
                userNameLabel.Content = "UserName : ";
            }
            userNameTextBox.Text = usern;
        }

        private void saveNewCustomerButton_Click(object sender, RoutedEventArgs e)
        {
            if (passwordTextBox.Password == rePasswordTextBox.Password && oldPasswTextBox.Password == a.getRowDatabase("info", 1, "id", "password"))
            {
                MessageBoxResult messageBoxResult = System.Windows.MessageBox.Show("Confirm Password Change?", "Are you sure?", System.Windows.MessageBoxButton.YesNo);
                if (messageBoxResult == MessageBoxResult.Yes)
                {
                    if (userNameTextBox.IsEnabled)
                    {
                        a.editDatabase("info", "datavalue = '" + userNameTextBox.Text + "'", "id", "username");                       
                    }
                    a.editDatabase("info", "datavalue = '" + passwordTextBox.Password + "'", "id", "password");
                    this.NavigationService.GoBack();
                }
            }
            else
            {
                MessageBox.Show("Incorrect old password OR the New Password doesn't match!!", "Error!");
            }
        }

        private void backButton_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.GoBack();
        }
    }
}
