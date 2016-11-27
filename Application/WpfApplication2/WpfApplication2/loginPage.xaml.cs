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
    /// Interaction logic for Page1.xaml
    /// </summary>
    public partial class loginPage : Page
    {   
        private accessDatabase a = new accessDatabase();
        public loginPage()
        {
            InitializeComponent();
            
            if(!a.checkInDatabase("info","id","username"))
            {
                a.addInDatabase("info", "id,datavalue", "'username','userid1'");
                a.addInDatabase("info", "id,datavalue", "'password','password1234'");
            }
        }

        private void loginButton_Click(object sender, RoutedEventArgs e)
        {

            string user = a.getRowDatabase("info", 1, "id", "username");
            string pass = a.getRowDatabase("info", 1, "id", "password");
            if (userTextBox.Text == user && passwordBox.Password == pass)
            {

                this.NavigationService.Navigate(new homePage());   //Uri("dashBoardPage.xaml", UriKind.Relative);
                //this.NavigationService.Navigate(dash);
            }
            
            else
            {
                incorrectMessage.Visibility = Visibility.Visible;
                userTextBox.BorderBrush = Brushes.Red;
                passwordBox.BorderBrush = Brushes.Red;
                passwordBox.Password = "";
                userTextBox.Text = "";               
            }



        }
    }
}
