using System;
using System.Collections.Generic;
using System.Data;
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

namespace pr10
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            LRole.Content = "Guest";
            LFIO.Content = "";
        }
        public MainWindow(string user)
        {
            InitializeComponent();
            //Label role = new Label();
            //Label fio = new Label();
            switch (user)
            {
                case "8lf0g@yandex.ru": LRole.Content = "Администратор"; LFIO.Content = "Богдан Львович Лавров";
                    break;
                case "1zx8@yandex.ru": LRole.Content = "Администратор"; LFIO.Content = "Полина Фёдоровна Смирнова";
                    break;
                case "x@mail.ru": LRole.Content = "Администратор"; LFIO.Content = "София Данииловна Полякова";
                    break;
                case "34d@gmail.com": LRole.Content = "Менеджер"; LFIO.Content = "Марина Данииловна Чеботарева";
                    break;
                case "pxacl@mail.ru": LRole.Content = "Менеджер"; LFIO.Content = "Адам Иванович Ермолов";
                    break;
                case "7o1@gmail.com": LRole.Content = "Менеджер"; LFIO.Content = "Андрей Кириллович Васильев";
                    break;
                case "1@gmail.com": LRole.Content = "Клиент"; LFIO.Content = "Максим Иванович Маслов";
                    break;
                case "iut@gmail.com": LRole.Content = "Клиент"; LFIO.Content = "Михаил Тимурович Симонов";
                    break;
                case "e3t@outlook.com": LRole.Content = "Клиент"; LFIO.Content = "Ксения Михайловна Павлова";
                    break;
                case "41clb6o2g@yandex.ru": LRole.Content = "Клиент"; LFIO.Content = "Григорий Юрьевич Трифонов";
                    break;
            }
            //LRole = role;
            //LFIO = fio;
        }

        public void LoadData(string sql)
        {

        }

        private void Exit_MouseDown(object sender, MouseButtonEventArgs e)
        {
            EnterWindow enterWindow = new EnterWindow();
            enterWindow.Show();
            this.Close();
        }

        private void SortA_MouseDown(object sender, MouseButtonEventArgs e)
        {

        }

        private void SortZ_MouseDown(object sender, MouseButtonEventArgs e)
        {

        }
    }
}
