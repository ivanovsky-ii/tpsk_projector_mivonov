using barbi_shop.barbi_database;
using Microsoft.Win32;
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
using System.IO;


namespace barbi_shop.windows
{
    /// <summary>
    /// Логика взаимодействия для barber_add.xaml
    /// </summary>
    public partial class barber_add : Window
    {
        barbers barb = new barbers();

        public barber_add()
        {
            InitializeComponent();

        }

        private void add_new_barber_btn_Click(object sender, RoutedEventArgs e)
        {
            barb.barber_name = barber_surname_tb.Text;
            barb.barber_post = barber_post_tb.Text;
            barb.barber_information = barber_information_tb.Text;


            db_connect.get_context().barbers.Add(barb);
            db_connect.get_context().SaveChanges();
            this.Close();

        }

        private void barber_photo_tb_Click(object sender, RoutedEventArgs e)
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
                barber_photo_tb.Content = filename;
            }

            

        }
    }
}
