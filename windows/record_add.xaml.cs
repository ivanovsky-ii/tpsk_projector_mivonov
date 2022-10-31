using barbi_shop.barbi_database;
using barbi_shop.data;
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
using barbi_shop.pages;  
namespace barbi_shop.windows
{
    /// <summary>
    /// Логика взаимодействия для record_add.xaml
    /// </summary>
    public partial class record_add : Window
    {
        records rec = new records();
        public record_add()
        {
            InitializeComponent();
        }

       

        private void add_new_record_btn_Click(object sender, RoutedEventArgs e)
        {
            rec.service_id = Convert.ToInt32(record_service_tb.Text);
            rec.barber_id = Convert.ToInt32(barber_record_tb.Text);
            rec.client_id = Convert.ToInt32(client_record_tb.Text);
            rec.record_date_and_time = Convert.ToDateTime(record_date_and_time_tb.Text);
            rec.record_comment = record_comment_tb.Text;

            db_connect.get_context().records.Add(rec);
            db_connect.get_context().SaveChanges();

            navigation_helper.DBFrame.Navigate(new record_list());
            navigation_helper.selected_record = null;
            this.Close();

        }
    }
}
