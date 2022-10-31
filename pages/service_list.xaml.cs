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

namespace barbi_shop.pages
{
    /// <summary>
    /// Логика взаимодействия для service_list.xaml
    /// </summary>
    public partial class service_list : Page
    {
        public service_list()
        {
            InitializeComponent();
            service_view_list.ItemsSource = db_connect.get_context().services.ToList();
        }
    }
}
