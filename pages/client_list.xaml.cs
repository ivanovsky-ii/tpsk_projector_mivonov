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
using barbi_shop.barbi_database;
using barbi_shop.data;

namespace barbi_shop.pages
{
    /// <summary>
    /// Логика взаимодействия для client_list.xaml
    /// </summary>
    public partial class client_list : Page
    {
        public client_list()
        {
            InitializeComponent();
            clients_view_list.ItemsSource = db_connect.get_context().clients.ToList();
        }

        private void clients_view_list_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            navigation_helper.selected_client = clients_view_list.SelectedItem as clients;
        }
    }
}
