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
using barbi_shop.windows;

namespace barbi_shop.pages
{
    /// <summary>
    /// Логика взаимодействия для record_edit.xaml
    /// </summary>
    public partial class record_edit : Page
    {
        
        public record_edit()
        {
            InitializeComponent();
        }

        private void add_record_Click(object sender, RoutedEventArgs e)
        {
            record_add ra = new record_add();
            ra.ShowDialog();
        }

        private void edit_record_Click(object sender, RoutedEventArgs e)
        {
            record_editwindow rew = new record_editwindow();
            rew.ShowDialog();
        }
    }
}
