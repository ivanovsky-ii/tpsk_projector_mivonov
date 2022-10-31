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

namespace barbi_shop.windows
{
    /// <summary>
    /// Логика взаимодействия для client_add.xaml
    /// </summary>
    public partial class client_add : Window
    {
        clients cl = new clients();
        public client_add()
        {
            InitializeComponent();
        }

        private void add_new_client_btn_Click(object sender, RoutedEventArgs e)
        {
            cl.client_name = client_surname_tb.Text;
            cl.client_phone = client_phone_tb.Text;
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
                clien11t_photo_tb.Text = filename;
            }


            db_connect.get_context().clients.Add(cl);
            db_connect.get_context().SaveChanges();

            this.Close();
        }
    }
}
