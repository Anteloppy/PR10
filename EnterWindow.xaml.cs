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
using System.Windows.Shapes;

namespace pr10
{
    /// <summary>
    /// Логика взаимодействия для EnterWindow.xaml
    /// </summary>
    public partial class EnterWindow : Window
    {
        bool chc = true;
        public EnterWindow()
        {
            InitializeComponent();
            CapchaHide();
        }

        public void CapchaHide()
        {
            this.Height = 250;
            GridLengthConverter gridLengthConverter = new GridLengthConverter();
            LogWinRow3.Height = (GridLength)gridLengthConverter.ConvertFrom("0*");
            SPCapcha.Visibility = Visibility.Hidden;
        }

        //добавить пользователя в скобки
        public void EnterToSystem(string user)
        {
            MainWindow mainWindow = new MainWindow(user);
            mainWindow.Show();
            this.Close();
        }

        public void CapchaGenerate()
        {
            Random rnd = new Random();
            char randomChar;
            randomChar = (char)rnd.Next('A', 'Z');
            LCapcha1.Content = randomChar;
            randomChar = (char)rnd.Next('A', 'Z');
            LCapcha2.Content = randomChar;
            randomChar = (char)rnd.Next('0', '9');
            LCapcha3.Content = randomChar;
            randomChar = (char)rnd.Next('A', 'Z');
            LCapcha4.Content = randomChar;
        }

        public void CapchaShow()
        {
            MessageBox.Show("Login or password are not correct");
            chc = false;
            this.Height = 400;
            GridLengthConverter gridLengthConverter = new GridLengthConverter();
            LogWinRow3.Height = (GridLength)gridLengthConverter.ConvertFrom("4*");
            CapchaGenerate();
            SPCapcha.Visibility = Visibility.Visible;
            string capcha = Convert.ToString(LCapcha1.Content) + Convert.ToString(LCapcha2.Content) + Convert.ToString(LCapcha3.Content) + Convert.ToString(LCapcha4.Content);
            //text = text.Substring(2);
        }

        public void Enter_Click(object sender, RoutedEventArgs e)
        {
            if (chc == true)
            switch (TBLogin.Text)
            {
                case "8lf0g@yandex.ru":
                    if (TBPassword.Text == "2L6KZG")
                        EnterToSystem("8lf0g@yandex.ru");
                    else CapchaShow();
                    break;
                case "1zx8@yandex.ru":
                    if (TBPassword.Text == "uzWC67")
                        EnterToSystem("1zx8@yandex.ru");
                    else CapchaShow();
                    break;
                case "x@mail.ru":
                    if (TBPassword.Text == "8ntwUp")
                        EnterToSystem("x@mail.ru");
                    else CapchaShow();
                    break;
                case "34d@gmail.com":
                    if (TBPassword.Text == "YOyhfR")
                        EnterToSystem("34d@gmail.com");
                    else CapchaShow();
                    break;
                case "pxacl@mail.ru":
                    if (TBPassword.Text == "RSbvHv")
                        EnterToSystem("pxacl@mail.ru");
                    else CapchaShow();
                    break;
                case "7o1@gmail.com":
                    if (TBPassword.Text == "rwVDh9")
                        EnterToSystem("7o1@gmail.com");
                    else CapchaShow();
                    break;
                case "1@gmail.com":
                    if (TBPassword.Text == "LdNyos")
                        EnterToSystem("1@gmail.com");
                    else CapchaShow();
                    break;
                case "iut@gmail.com":
                    if (TBPassword.Text == "gynQMT")
                        EnterToSystem("iut@gmail.com");
                    else CapchaShow();
                    break;
                case "e3t@outlook.com":
                    if (TBPassword.Text == "AtnDjr")
                        EnterToSystem("e3t@outlook.com");
                    else CapchaShow();
                    break;
                case "41clb6o2g@yandex.ru":
                    if (TBPassword.Text == "JlFRCZ")
                        EnterToSystem("41clb6o2g@yandex.ru");
                    else CapchaShow();
                    break;
                    default: CapchaShow();
                    break;
            }
        }

        public void CheckCapcha_Click(object sender, RoutedEventArgs e)
        {
            string capcha = Convert.ToString(LCapcha1.Content) + Convert.ToString(LCapcha2.Content) + Convert.ToString(LCapcha3.Content) + Convert.ToString(LCapcha4.Content);
            if (capcha.Equals(TBCapcha.Text))
            {
                MessageBox.Show("Capcha has checked");
                chc = true;
            }
            else
            {
                MessageBox.Show("Capcha hasn't checked!", "Write capcha again");
                TBCapcha.Text = "";
            }
        }

        private void BGuest_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close();
        }
    }
}
