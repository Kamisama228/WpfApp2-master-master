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

namespace WpfApp2.Pages
{
    /// <summary>
    /// Interaction logic for ServiceListPage.xaml
    /// </summary>
    public partial class ServiceListPage : Page
    {
        public ServiceListPage()
        {
            InitializeComponent();
        }

        private void BtOrderClick(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new ServiceOrderPage("Наименование услуги"));
        }

        private void BtOrder2Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new ServiceOrderPage("Наименование услуги1"));
        }
    }
}
