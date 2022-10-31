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
using barbi_shop.data;
using barbi_shop.windows;
namespace barbi_shop.pages
{
    /// <summary>
    /// Логика взаимодействия для barber_edit.xaml
    /// </summary>
    public partial class barber_edit : Page
    {
        public barber_edit()
        {
            InitializeComponent();
        }

        private void add_client_Click(object sender, RoutedEventArgs e)
        {
            barber_add adding_win = new barber_add();
            adding_win.ShowDialog();
        }

        private void edit_barber_Click(object sender, RoutedEventArgs e)
        {
            if (navigation_helper.selected_barber != null)
            {
                barber_editwindow bw = new barber_editwindow();
                bw.ShowDialog();
            }
            else MessageBox.Show("Ошибка","Выберите данные для изменения", MessageBoxButton.OK, MessageBoxImage.Error);
            
            
        }
    }
}
