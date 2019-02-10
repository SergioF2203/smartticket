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
using System.Windows.Navigation;
using System.Windows.Shapes;
using Client.Admin;
using Client.CustomerService;

namespace Client
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            replaceRadiobuttonOnForm();
            //OrderWindow orderWindow = new OrderWindow();
            //orderWindow.Show();
            //это для тестирования
            //Admin.AdminLogin al = new Admin.AdminLogin();
            //al.Show();

        }
        //test 47 places Bus window
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //BusShema47 bs47 = new BusShema47();
            //bs47.Show();
            SelectTrip selectTrip = new SelectTrip();
            selectTrip.Show();
        }

        private void ExitButton_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            Admin.AdminLogin al = new AdminLogin();
            al.Show();
            Close();
        }

        private void replaceRadiobuttonOnForm()
        {
            DLCustomer dlc = new DLCustomer();
            List<Direction> direction = dlc.GetDirections();

            foreach (var rb in mainCanvas.Children)
            {
                if (rb is RadioButton)
                {
                    RadioButton rdbt = rb as RadioButton;
                    foreach (Direction drct in direction)
                    {
                        if (rdbt.Name == drct.City)
                        {
                            Thickness thickness = rdbt.Margin;
                            thickness.Left = dlc.ToCoordinates(drct.Coordinates)[0];
                            thickness.Top = dlc.ToCoordinates(drct.Coordinates)[1];
                            rdbt.Margin = thickness;
                            rdbt.IsEnabled = drct.IsActive;
                        }
                    }
                }

            }

        }

        private void Rdiobutton_Click(object sender, RoutedEventArgs e)
        {
            nextButton.Visibility = Visibility.Visible;
            nextButton.IsEnabled = true;
        }

    }
}
