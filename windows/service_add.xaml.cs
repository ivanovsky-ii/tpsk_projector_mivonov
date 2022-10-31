using barbi_shop.barbi_database;
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
using barbi_shop.pages;

namespace barbi_shop.windows
{
    /// <summary>
    /// Логика взаимодействия для service_add.xaml
    /// </summary>
    public partial class service_add : Window
    {
        services serv = new services();
        public service_add()
        {
            InitializeComponent();
        }

        private void add_new_service_btn_Click(object sender, RoutedEventArgs e)
        {
            serv.service_name = service_name_tb.Text;
            serv.service_price = service_price_tb.Text;

           


            db_connect.get_context().services.Add(serv);
            db_connect.get_context().SaveChanges();
            navigation_helper.DBFrame.Navigate(new service_list());
            this.Close();

        }

        private void add_service_photo_btn_Click(object sender, RoutedEventArgs e)
        {
            Microsoft.Win32.OpenFileDialog dlg = new Microsoft.Win32.OpenFileDialog();


            // Set filter for file extension and default file extension 
            dlg.DefaultExt = ".png";
            dlg.Filter = "JPEG Files (*.jpeg)|*.jpeg|PNG Files (*.png)|*.png|JPG Files (*.jpg)|*.jpg|GIF Files (*.gif)|*.gif";


            // Display OpenFileDialog by calling ShowDialog method 
            Nullable<bool> result = dlg.ShowDialog();


            // Get the selected file name and display in a TextBox 
            if (result == true)
            {
                // Open document 
                string filename = dlg.FileName;
                add_service_photo_btn.Content = filename;
            }
        }
    }
}
