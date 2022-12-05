using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Application = System.Windows.Application;
using MessageBox = System.Windows.Forms.MessageBox;

namespace MapsUkraine
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

        private void ExitInProgram_Click(object sender, RoutedEventArgs e)
        {
            string message = "Ви хочете закрити програму?";
            string title = "Вихід з програми";

            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);

            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void SignOut_Click(object sender, RoutedEventArgs e)
        {
            string message = "Ви хочете вийти з аккаунту?";
            string title = "Вихід з аккаунту";

            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);

            if (result == System.Windows.Forms.DialogResult.Yes)
            {
               AuthorizathionWindow authorizathionWindow = new AuthorizathionWindow();
               authorizathionWindow.Show();
               Close();
            }
        }

        private void btnAbout_Click(object sender, RoutedEventArgs e)
        {
            AboutWindow aboutWindow = new AboutWindow();
            aboutWindow.Show(); 
            Close();
        }

        private void btnSettings_Click(object sender, RoutedEventArgs e)
        {
            SettingsWindow settingsWindow = new SettingsWindow(); 
            settingsWindow.Show();
            Close();
        }

        private void btnWesternZone_Click(object sender, RoutedEventArgs e)
        {
            cnvsMain.Children.Clear();

            txtbName.Text = "Zakarpatska Oblast";

            Image backgroundImage = new Image();

            backgroundImage.Source = new BitmapImage(new Uri(@"Geographic maps\Zakarpatie.png", UriKind.Relative));

            Canvas.SetLeft(backgroundImage, 120);
            Canvas.SetTop(backgroundImage, 0);


            backgroundImage.Width = 516;
            backgroundImage.Height = 326;

            cnvsMain.Children.Add(backgroundImage);
        }

        private void btnHome_Click(object sender, RoutedEventArgs e)
        {
            cnvsMain.Children.Clear();

            txtbName.Text = "Ukraine";

            Image backgroundImage = new Image();

            backgroundImage.Source = new BitmapImage(new Uri(@"Photo\MainMap.png", UriKind.Relative));

            Canvas.SetLeft(backgroundImage, 100);
            Canvas.SetTop(backgroundImage, 0);


            backgroundImage.Width = 516;
            backgroundImage.Height = 326;

            cnvsMain.Children.Add(backgroundImage);
        }

        private void btnEasternZone_Click(object sender, RoutedEventArgs e)
        {
            cnvsMain.Children.Clear();

            txtbName.Text = "Donetska Oblast";

            Image backgroundImage = new Image();

            backgroundImage.Source = new BitmapImage(new Uri(@"Geographic maps\Donetsk.png", UriKind.Relative));

            Canvas.SetLeft(backgroundImage, 100);
            Canvas.SetTop(backgroundImage, 0);


            backgroundImage.Width = 516;
            backgroundImage.Height = 326;

            cnvsMain.Children.Add(backgroundImage);
        }

        private void SouthernZone_Click(object sender, RoutedEventArgs e)
        {
            cnvsMain.Children.Clear();

            txtbName.Text = "Kherson Oblast";

            Image backgroundImage = new Image();

            backgroundImage.Source = new BitmapImage(new Uri(@"Geographic maps\Kherson.png", UriKind.Relative));

            Canvas.SetLeft(backgroundImage, 100);
            Canvas.SetTop(backgroundImage, 0);


            backgroundImage.Width = 516;
            backgroundImage.Height = 326;

            cnvsMain.Children.Add(backgroundImage);
        }

        private void NorthernZone_Click(object sender, RoutedEventArgs e)
        {
            cnvsMain.Children.Clear();

            txtbName.Text = "Kiev Oblast";

            Image backgroundImage = new Image();

            backgroundImage.Source = new BitmapImage(new Uri(@"Geographic maps\Kiev.png", UriKind.Relative));

            Canvas.SetLeft(backgroundImage, 100);
            Canvas.SetTop(backgroundImage, 0);


            backgroundImage.Width = 516;
            backgroundImage.Height = 326;

            cnvsMain.Children.Add(backgroundImage);
        }

        private void Zakarpatski_iRegion_Click(object sender, RoutedEventArgs e)
        {
            cnvsMain.Children.Clear();

            txtbName.Text = "Zakarpatski'i Region";

            Image backgroundImage = new Image();

            backgroundImage.Source = new BitmapImage(new Uri(@"Topographic maps\Zakarpatia.jpg", UriKind.Relative));

            Canvas.SetLeft(backgroundImage, 100);
            Canvas.SetTop(backgroundImage, 0);


            backgroundImage.Width = 516;
            backgroundImage.Height = 326;

            cnvsMain.Children.Add(backgroundImage);
        }

        private void Zaporizhzhia_Region_Click(object sender, RoutedEventArgs e)
        {
            cnvsMain.Children.Clear();

            txtbName.Text = "Zaporizhzhia Region";

            Image backgroundImage = new Image();

            backgroundImage.Source = new BitmapImage(new Uri(@"Topographic maps\Zaporizhzhia.jpg", UriKind.Relative));

            Canvas.SetLeft(backgroundImage, 100);
            Canvas.SetTop(backgroundImage, 0);


            backgroundImage.Width = 516;
            backgroundImage.Height = 326;

            cnvsMain.Children.Add(backgroundImage);
        }

        private void Ivano_Frankivsk_Region_Click(object sender, RoutedEventArgs e)
        {
            cnvsMain.Children.Clear();

            txtbName.Text = "Ivano-Frankivsk Region";

            Image backgroundImage = new Image();

            backgroundImage.Source = new BitmapImage(new Uri(@"Topographic maps\Ivano-Frankivsk.jpg", UriKind.Relative));

            Canvas.SetLeft(backgroundImage, 100);
            Canvas.SetTop(backgroundImage, 0);


            backgroundImage.Width = 516;
            backgroundImage.Height = 326;

            cnvsMain.Children.Add(backgroundImage);
        }

        private void Lviv_Region_Click(object sender, RoutedEventArgs e)
        {
            cnvsMain.Children.Clear();

            txtbName.Text = "Lviv Region";

            Image backgroundImage = new Image();

            backgroundImage.Source = new BitmapImage(new Uri(@"Topographic maps\Lviv.jpg", UriKind.Relative));

            Canvas.SetLeft(backgroundImage, 100);
            Canvas.SetTop(backgroundImage, 0);


            backgroundImage.Width = 516;
            backgroundImage.Height = 326;

            cnvsMain.Children.Add(backgroundImage);
        }

        private void Kiev_Region_Click(object sender, RoutedEventArgs e)
        {
            cnvsMain.Children.Clear();

            txtbName.Text = "Kiev Region";

            Image backgroundImage = new Image();

            backgroundImage.Source = new BitmapImage(new Uri(@"Topographic maps\Kiev.jpg", UriKind.Relative));

            Canvas.SetLeft(backgroundImage, 100);
            Canvas.SetTop(backgroundImage, 0);


            backgroundImage.Width = 516;
            backgroundImage.Height = 326;

            cnvsMain.Children.Add(backgroundImage);
        }
    }
}
