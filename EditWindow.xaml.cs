using MySql.Data.MySqlClient;
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
using System.Xml.Linq;

namespace pr10
{
    /// <summary>
    /// Логика взаимодействия для EditWindow.xaml
    /// </summary>
    public partial class EditWindow : Window
    {
        public EditWindow()
        {
            InitializeComponent();
        }
        public EditWindow(int id, string vendor_code, string name, string unit, decimal price, int max_disc, string provider, string manufacturer, string category, int cur_disc, int quantity_in_stock, string description, string picture)
        {
            InitializeComponent();
            Lid.Content = Convert.ToString(id);
            TBvendor_code.Text = vendor_code;
            TBname.Text = name;
            TBunit.Text = unit;
            TBprice.Text = Convert.ToString(price);
            TBmax_disc.Text = Convert.ToString(max_disc);
            TBprovider.Text = provider;
            TBmanufacturer.Text = manufacturer;
            TBcategory.Text = category;
            TBcur_disc.Text = Convert.ToString(cur_disc);
            TBqis.Text = Convert.ToString(quantity_in_stock);
            TBdescription.Text = description;
            TBpicture.Text = picture;
        }
        private static string connectionString = "server=localhost; port=3306; database=PR10; user=root; password=Nimda123;";
        private void BEdit_Click(object sender, RoutedEventArgs e)
        {
            int id = Convert.ToInt32(Lid.Content);
            string edit = "update products set vendor_code = '" + TBvendor_code.Text + "', name = '" + TBname.Text + "', unit = " + Convert.ToInt32(TBunit.Text) + ", price = " + Convert.ToDecimal(TBprice.Text) + ", max_disc = " + Convert.ToInt32(TBmax_disc.Text) + ", provider = " + Convert.ToInt32(TBprovider.Text) + ", manufacturer = " + Convert.ToInt32(TBmanufacturer.Text) + ", category = " + Convert.ToInt32(TBcategory.Text) + ", cut_disc = " + Convert.ToInt32(TBcur_disc.Text) + ", quantity_in_stock = " + Convert.ToInt32(TBqis.Text) + ", description = '" + TBdescription.Text + "', picture = '" + TBpicture.Text + "' where ID = @id; commit;";
            MySqlConnection conn = new MySqlConnection(connectionString);
            conn.Open();
            MySqlCommand cmd = new MySqlCommand(edit, conn);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("товар с id " + id + " изменён");
        }
    }
}
