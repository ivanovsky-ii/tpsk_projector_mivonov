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
using barbi_shop.windows;
namespace barbi_shop.pages
{
    /// <summary>
    /// Логика взаимодействия для service_edit.xaml
    /// </summary>
    public partial class service_edit : Page
    {
        public service_edit()
        {
            InitializeComponent();
        }

        private void add_service_Click(object sender, RoutedEventArgs e)
        {
            service_add add_serv = new service_add();
            add_serv.ShowDialog();
        }

        private void edit_service_Click(object sender, RoutedEventArgs e)
        {
            service_editwindow sw = new service_editwindow();
            sw.ShowDialog();
        }
    }
}
