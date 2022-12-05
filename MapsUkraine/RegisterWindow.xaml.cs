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
    /// Логика взаимодействия для RegisterWindow.xaml
    /// </summary>
    public partial class RegisterWindow : Window
    {
        public RegisterWindow()
        {
            InitializeComponent();
        }

        private const string DataPath = @"Data"; //Путь до файла з даними

        private static string UserName = ""; // Ім'я корисутвача
        static string UserPassword = ""; // Пароль користувача

        public static bool IsLogin = false; //Перевірка на правильність вводу

        private void btnRegister_Click(object sender, RoutedEventArgs e)
        {
            try // Перевірка на існування файла
            {
                if (!File.Exists(DataPath + "\\Users.txt")) // Якщо файла не існує
                {
                    File.Create(DataPath + "\\Users.txt"); // Створення файла
                }

                bool NotCorrectLoginPassword = true;
                UserName = "";
                do
                {
                    NotCorrectLoginPassword = true;
                    UserName = txtbLogin.Text;
                    if (UserName.Length == 0) // Перевірка на пустий текст бокс
                    {
                        MessageBox.Show("Логін не може бути пустий");
                        return;
                    }

                    UserPassword = pswbPassword.Password;
                    if (UserPassword.Length == 0) // Перевірка на пустий текст бокс
                    {
                        NotCorrectLoginPassword = false;
                        MessageBox.Show("Пароль не може бути пустий");
                        return;
                    }

                    string[] tmpStringArray = File.ReadAllText(DataPath + "\\Users.txt").Replace("\n", string.Empty).Split('\r');

                    foreach (string tmpString in tmpStringArray)
                    {
                        //// Перевірка співпадання логіна та пароля
                        if (string.Compare(tmpString.Split(' ')[0], UserName) == 0)
                        {
                            NotCorrectLoginPassword = false;
                            MessageBox.Show("Такий користувач вже існує");
                            return;
                        }
                        
                    }


                }
                while (!NotCorrectLoginPassword);

                if (NotCorrectLoginPassword == true)
                {
                    string hashOfPassword = BCrypt.Net.BCrypt.HashPassword(UserPassword);
                    File.AppendAllText(DataPath + "\\users.txt", "\r" + UserName + " " + hashOfPassword); // Якщо паролі співпадають, записати їх в блокнот
                    MessageBox.Show("Реєстрація успішна");
                    AuthorizathionWindow authorizathion = new AuthorizathionWindow();
                    authorizathion.Show();
                    Close();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Файли не найдені");
            }
        }
        
        private void btnSignIn_Click(object sender, RoutedEventArgs e)
        {
            AuthorizathionWindow authorizathionWindow = new AuthorizathionWindow();
            authorizathionWindow.Show();
            Close();
        }
    }
}
