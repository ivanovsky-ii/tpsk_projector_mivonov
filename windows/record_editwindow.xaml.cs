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
using barbi_shop.barbi_database;
using barbi_shop.pages;

namespace barbi_shop.windows
{
    /// <summary>
    /// Логика взаимодействия для record_editwindow.xaml
    /// </summary>
    public partial class record_editwindow : Window
    {

        public record_editwindow()
        {
            InitializeComponent();

            record_service_tb.Text = Convert.ToString(navigation_helper.selected_record.service_id);
            barber_record_tb.Text = Convert.ToString(navigation_helper.selected_record.barber_id);
            client_record_tb.Text = Convert.ToString(navigation_helper.selected_record.client_id);
            record_date_and_time_tb.Text = Convert.ToString(navigation_helper.selected_record.record_date_and_time);
            record_comment_tb.Text = navigation_helper.selected_record.record_comment;


        }

        private void edit_record_btn_Click(object sender, RoutedEventArgs e)
        {
            navigation_helper.selected_record.service_id = Convert.ToInt32(record_service_tb.Text);
            navigation_helper.selected_record.barber_id = Convert.ToInt32(barber_record_tb.Text);
            navigation_helper.selected_record.client_id = Convert.ToInt32(client_record_tb.Text);
            navigation_helper.selected_record.record_date_and_time = Convert.ToDateTime(record_date_and_time_tb.Text);
            navigation_helper.selected_record.record_comment = record_comment_tb.Text;

            db_connect.get_context().SaveChanges();
            navigation_helper.DBFrame.Navigate(new record_list());
            navigation_helper.selected_record = null;
            this.Close();
        }
    }
}
