using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
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

namespace Client
{
    /// <summary>
    /// Логика взаимодействия для OrderWindow.xaml
    /// </summary>
    public partial class OrderWindow : Window
    {
        public OrderWindow()
        {
            InitializeComponent();
        }

        private void CancelButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void OkButton_Click(object sender, RoutedEventArgs e)
        {
            if(NameTextBox.Text != "" && PhoneNumberTextBox.Text != "" && EmailTextBox.Text != "")
            {
                try // тут мы писмо отправляем с нашего имейла
                {
                    MailAddress from = new MailAddress("vnsitcorp@gmail.com", "VNSteam");
                    MailAddress to = new MailAddress(EmailTextBox.Text);
                    MailMessage m = new MailMessage(from, to);
                    m.Subject = "Автовокзал Запорожья";
                    m.Body = "<h2>Ваш билетик пропал :(</h2>";
                    m.IsBodyHtml = true;
                    SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587);
                    smtp.Credentials = new NetworkCredential("vnsitcorp@gmail.com", "dreamteamadmin");
                    smtp.EnableSsl = true;
                    smtp.Send(m);
                    Console.Read();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                QRWindow qrwindow = new QRWindow();
                qrwindow.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Заполните все поля!");
            }
        }
    }
}
