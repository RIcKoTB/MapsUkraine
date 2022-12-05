using System;
using System.Collections.Generic;
using System.IO;
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

namespace MapsUkraine
{
    /// <summary>
    /// Логика взаимодействия для AuthorizathionWindow.xaml
    /// </summary>
    public partial class AuthorizathionWindow : Window
    {
        public AuthorizathionWindow()
        {
            InitializeComponent();
        }

        private const string DataPath = @"Data"; //Путь до файла з даними

        private static string UserName = ""; // Ім'я корисутвача
        static string UserPassword = ""; // Пароль користувача

        public static bool IsLogin = false; //Перевірка на правильність вводу

        private void btnSignIn_Click(object sender, RoutedEventArgs e)
        {
            if (File.Exists(DataPath + "\\Users.txt"))
            {
                UserName = txtbLogin.Text;
                if (UserName.Length == 0)
                {
                    MessageBox.Show("Логін не може бути пустий");
                    return;
                }

                UserPassword = pswbPassword.Password;
                if (UserPassword.Length == 0)
                {
                    MessageBox.Show("Пароль не може бути пустий");
                    return;
                }
                string[] tmpStringArray = File.ReadAllText(DataPath + "\\Users.txt").Replace("\n", string.Empty).Split('\r');



                foreach (string tmpString in tmpStringArray)
                {
                    if ((tmpString.Split(' ')[0] == UserName) && BCrypt.Net.BCrypt.Verify(UserPassword, tmpString.Split(' ')[1]) == true)
                    {
                        IsLogin = true;
                        MessageBox.Show("Авторизація успішна");
                        MainWindow mainWindow = new MainWindow();
                        mainWindow.Show();
                        Close();    
                    }
                }
            }
            else
            {
                MessageBox.Show("Проблеми з авторизацією");
            }
            if (!IsLogin) MessageBox.Show("Не вірний логін або пароль");



           
        }

        private void btnSignUp_Click(object sender, RoutedEventArgs e)
        {
            RegisterWindow registerWindow = new RegisterWindow();
            registerWindow.Show();
            Close();
        }
    }
}
