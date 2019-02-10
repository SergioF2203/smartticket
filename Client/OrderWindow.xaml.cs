using Client.CustomerService;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Runtime.CompilerServices;
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
using Client.CustomerService;

namespace Client
{
    /// <summary>
    /// Логика взаимодействия для OrderWindow.xaml
    /// </summary>
    public partial class OrderWindow : Window, INotifyPropertyChanged
    {
	    private DLCustomer _dlCustomer;

		private Trip _trip;
        private string _city;
        private string _dep;
        private string _nPlaces;
        private double _price;

        public OrderWindow(Trip trip, List<int> places)
        {
            Trip = trip;
            Places = places;

            City = Trip.Direction.City;
            Dep = Trip.Departure.ToString();
            NPlaces = places.Count.ToString();
            Price = Trip.Direction.Price * Int32.Parse(NPlaces);

            DataContext = this;

			_dlCustomer = new DLCustomer();

            InitializeComponent();
        }

        public string City {
            get { return _city; }
            set
            { _city = value;
                OnPropertyChanged(nameof(City));
            }
        }

        public string Dep
        {
            get { return _city; }
            set
            {
                _dep = value;
                OnPropertyChanged(nameof(Dep));
            }
        }

        public string NPlaces
        {
            get { return _nPlaces; }
            set
            {
                _nPlaces = value;
                OnPropertyChanged(nameof(NPlaces));
            }
        }

        public double Price
        {
            get { return _price; }
            set
            {
                _price = value;
                OnPropertyChanged(nameof(Price));
            }
        }

        public Trip Trip
        {
            get { return _trip; }
            set {
                _trip = value;
                OnPropertyChanged(nameof(Trip));
            }
        }
        public List<int> Places { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }


        private void CancelButton_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void OkButton_Click(object sender, RoutedEventArgs e)
        {
            if(NameTextBox.Text != "" && PhoneNumberTextBox.Text != "" && EmailTextBox.Text != "")
            {
				Customer customer = new Customer
				{
					Name = NameTextBox.Text,
					Phone = PhoneNumberTextBox.Text,
					Email = EmailTextBox.Text
				};

				_dlCustomer.AddOrders(CreateOrders(), customer);

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
                Close();
                
            }
            else
            {
                MessageBox.Show("Заполните все поля!");
            }
        }

        private List<Order> CreateOrders()
        {
            List<Order> orders = new List<Order>();
            foreach(var item in Places)
            {
                Order order = new Order
                {
                    TripId = Trip.Id,
                    PlaceNumber = item
                };
                orders.Add(order);
            }
            return orders;
        }
    }
}
