using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
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
    /// Логика взаимодействия для client_edit.xaml
    /// </summary>
    public partial class client_edit : Page
    {
        public client_edit()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            client_add adding_win_cli = new client_add();
            adding_win_cli.ShowDialog();
        }

        private void change_client_btn_Click(object sender, RoutedEventArgs e)
        {
            client_editwindow cw = new client_editwindow();
            cw.ShowDialog();
        }
    }
}
