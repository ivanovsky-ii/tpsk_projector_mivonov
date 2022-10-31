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
using System.Windows.Shapes;
using barbi_shop.data;
namespace barbi_shop.windows
{
    /// <summary>
    /// Логика взаимодействия для menu_window.xaml
    /// </summary>
    public partial class menu_window : Window
    {
        public menu_window()
        {
            InitializeComponent();
            navigation_helper.DBFrame = DBFrame;
            navigation_helper.db_edit_frame = db_edit_frame;
        }

        private void logout()
        {
            user_session.current_employee_id = 0;
            MainWindow login_window = new MainWindow();
            login_window.Show();
            this.Close();
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            logout();
        }



        private void ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ListBoxItem selected_page = ((sender as ListBox).SelectedItem as ListBoxItem);

            switch (selected_page.Content.ToString())
            {
                case "Парикмахеры": //просмотр все, редактирование все старше монтажника  ДОБАВИТЬ КНОПКУ ПРОСМОТРА ВСЕХ ЗАКАЗОВ/ТОЛЬКО МОИХ
                    DBFrame.Navigate(new barbi_shop.pages.barber_list());
                    db_edit_frame.Navigate(new barbi_shop.pages.barber_edit());
                    break;

                case "Услуги":
                    DBFrame.Navigate(new barbi_shop.pages.service_list());
                    db_edit_frame.Navigate(new barbi_shop.pages.service_edit());
                    break;

                case "Клиенты":
                    DBFrame.Navigate(new barbi_shop.pages.client_list());
                    db_edit_frame.Navigate(new barbi_shop.pages.client_edit());
                    break;

                case "Записи":
                    DBFrame.Navigate(new barbi_shop.pages.record_list());
                    db_edit_frame.Navigate(new barbi_shop.pages.record_edit());
                    break;

            }
        }
    }
}
