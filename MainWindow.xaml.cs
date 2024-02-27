using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
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
            LoadData("select P.id, P.vendor_code, P.name, U.name as unit, P.price, A.size as max_disc, R.name as provider, M.name as manufacturer, C.name as category, I.discaunt as cur_disc, P.quantity_in_stock, P.description, P.picture from Products as P join Units as U on P.unit = U.id join Maximum_discaunts as A on P.max_disc = A.id join Providers as R on P.provider = R.id join Manufacturers as M on P.manufacturer = M.id join Categories as C on P.category = C.id join Current_discaunts as I on P.cur_disc = I.id;");
        }
        public MainWindow(string user)
        {
            InitializeComponent();
            switch (user)
            {
                case "8lf0g@yandex.ru":
                    LRole.Content = "Администратор"; LFIO.Content = "Богдан Львович Лавров";
                    break;
                case "1zx8@yandex.ru":
                    LRole.Content = "Администратор"; LFIO.Content = "Полина Фёдоровна Смирнова";
                    break;
                case "x@mail.ru":
                    LRole.Content = "Администратор"; LFIO.Content = "София Данииловна Полякова";
                    break;
                case "34d@gmail.com":
                    LRole.Content = "Менеджер"; LFIO.Content = "Марина Данииловна Чеботарева";
                    break;
                case "pxacl@mail.ru":
                    LRole.Content = "Менеджер"; LFIO.Content = "Адам Иванович Ермолов";
                    break;
                case "7o1@gmail.com":
                    LRole.Content = "Менеджер"; LFIO.Content = "Андрей Кириллович Васильев";
                    break;
                case "1@gmail.com":
                    LRole.Content = "Клиент"; LFIO.Content = "Максим Иванович Маслов";
                    break;
                case "iut@gmail.com":
                    LRole.Content = "Клиент"; LFIO.Content = "Михаил Тимурович Симонов";
                    break;
                case "e3t@outlook.com":
                    LRole.Content = "Клиент"; LFIO.Content = "Ксения Михайловна Павлова";
                    break;
                case "41clb6o2g@yandex.ru":
                    LRole.Content = "Клиент"; LFIO.Content = "Григорий Юрьевич Трифонов";
                    break;
            };
        }


        private static string connectionString = "server=localhost; port=3306; database=PR10; user=root; password=Nimda123;";
        public void LoadData(string sql)
        {
            List<Product> crops = new List<Product>();
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                    //("select number, product, quantity, date_order, date_delivery, pickup_point, user, code, status from Orders as O join Products as P on O.Products = P.id join Pickup_points as I on O.Pickup_point = I.id join Users as U on O.User = U.id join Statuses as S on O.Status = S.id", conn);

                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Product record = new Product();
                        record.id = reader.GetInt32("id");
                        record.vendor_code = reader.GetString("vendor_code");
                        record.name = reader.GetString("name");
                        record.unit = reader.GetString("unit");
                        record.price = reader.GetDecimal("price");
                        record.max_disc = reader.GetInt32("max_disc");
                        record.provider = reader.GetString("provider");
                        record.manufacturer = reader.GetString("manufacturer");
                        record.category = reader.GetString("category");
                        record.cur_disc = reader.GetInt32("cur_disc");
                        record.quantity_in_stock = reader.GetInt32("quantity_in_stock");
                        record.description = reader.GetString("description");
                        record.picture = reader.GetString("picture");

                        crops.Add(record);
                    }
                }
            }
            DGProduct.ItemsSource = crops;
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
