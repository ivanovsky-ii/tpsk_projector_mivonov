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
namespace barbi_shop
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void login_button_click(object sender, RoutedEventArgs e)
        {
            #region Скрытие текста ошибок
            IncorrectPasswordErrorText.Visibility = Visibility.Hidden;
            EmptyLoginErrorText.Visibility = Visibility.Hidden;
            EmptyPasswordErrorText.Visibility = Visibility.Hidden;
            #endregion
            #region Проверка имени пользователя и пароля на соответствие, переход на следующее окно
            if (EmployeeId.Text != "") //проверяем на пустое значение поле ID
            {
                if (EmployeePassword.Password != "") //проверяем на пустое значение поле для пароля
                {
                    #region Создание локальных переменных для запроса к модели базы данных
                    string login_for_check = EmployeeId.Text;
                    string password_for_check = EmployeePassword.Password;
                    #endregion


                    // aaaa
                    try
                    {
                        var user_id_check = db_connect.get_context().accounts.FirstOrDefault(U => U.login == login_for_check);

                        if (user_id_check != null) //если логин правильный
                        {
                            var password_check = db_connect.get_context().accounts.FirstOrDefault(U => U.login == login_for_check && U.password == password_for_check);

                            if (password_check != null) //если логин и пароль правильные
                            {
                                #region Установка значений для дальнейшего доступа - айди сотрудника и его уровень допуска
                                user_session.current_employee_id = password_check.account_id; //сохраняет айди сотрудника
                                #endregion
                                menu_window menu_window = new menu_window();
                                menu_window.Show();
                                this.Close();
                            }
                            else //если пароль неправильынй
                            {
                                MessageBox.Show("Указан неверный пароль!");
                                EmployeePassword.Password = "";
                            }
                        }
                        else //если логин неправильный
                        {
                            MessageBox.Show("Указан неверный логин!");
                            EmployeeId.Text = "";
                            EmployeePassword.Password = "";
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Ошибка! \n Обратитесь к системному администратору. \n Код ошибки: {ex}");
                    }
                    //aaaa
                }
                else //если не введен пароль
                {
                    EmptyPasswordErrorText.Visibility = Visibility.Visible;
                }
            }
            else //если не введен логин
            {
                EmptyLoginErrorText.Visibility = Visibility.Visible;
            }
            //aaa
            #endregion

        }
    }
}
