using MySql.Data.MySqlClient;
using Org.BouncyCastle.Bcpg.OpenPgp;
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

namespace pr10
{
    /// <summary>
    /// Логика взаимодействия для AddWindow.xaml
    /// </summary>
    public partial class AddWindow : Window
    {
        public AddWindow()
        {
            InitializeComponent();
        }
        public string u;
        public AddWindow(string user)
        {
            InitializeComponent();
            u = user;
        }
        private static string connectionString = "server=localhost; port=3306; database=PR10; user=root; password=Nimda123;";
        private void Add_Click(object sender, RoutedEventArgs e)
        {
            string add = "insert into products(vendor_code, name, unit, price, max_disc, provider, manufacturer, category, cur_disc, quantity_in_stock, description, picture) values ('" + TBvendor_code.Text + "', '" + TBname.Text + "', " + Convert.ToInt32(TBunit.Text) + ", " + Convert.ToDecimal(TBprice.Text) + ", " + Convert.ToInt32(TBmax_disc.Text) + ", " + Convert.ToInt32(TBprovider.Text) + ", " + Convert.ToInt32(TBmanufacturer.Text) + ", " + Convert.ToInt32(TBcategory.Text) + ", " + Convert.ToInt32(TBcur_disc.Text) + ", " + Convert.ToInt32(TBqis.Text) + ", '" + TBdescription.Text + "', '" + TBpicture.Text + "'); commit; ";
            MySqlConnection conn = new MySqlConnection(connectionString);
            conn.Open();
            MySqlCommand cmd = new MySqlCommand(add, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("товар добавлен");
            MainWindow w = new MainWindow(u);
            w.Show();
            this.Close();
        }
    }
}