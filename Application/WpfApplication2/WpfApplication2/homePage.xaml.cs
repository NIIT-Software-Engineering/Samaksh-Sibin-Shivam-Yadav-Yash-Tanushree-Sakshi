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
    /// Interaction logic for dashBoardPage.xaml
    /// </summary>
    public partial class homePage : Page
    {
        private accessDatabase a = new accessDatabase();

        public homePage()
        {
            InitializeComponent();
            // string userName = "Yash";


        }

        private void aboutButton_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new aboutPage());
        }

        private void usepassChangeButton(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new changeUserPasswordPage());
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            string user = a.getRowDatabase("info", 1, "id", "username");
            homeTextBlock.Text = "Welcome, " + user;
        }
    }
}
