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
    /// Логика взаимодействия для barber_list.xaml
    /// </summary>
    public partial class barber_list : Page
    {
        public barber_list()
        {
            InitializeComponent();
            barbers_view_list.ItemsSource = db_connect.get_context().barbers.ToList();

        }

        private void barbers_view_list_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            navigation_helper.selected_barber = barbers_view_list.SelectedItem as barbers;
        }
    }
}
