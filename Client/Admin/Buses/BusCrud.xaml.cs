using Client.AdminService;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace Client.Admin
{
    /// <summary>
    /// Логика взаимодействия для BusCrud.xaml
    /// </summary>
    public partial class BusCrud : Window
    {


        DLAdmin dl = new DLAdmin();
        public BusCrud()
        {
            InitializeComponent();
        }

        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            AddBusWindow abw = new AddBusWindow();
            abw.Show();
            this.Close();
        
        }

        private void ExitButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }


        private void DeleteButton_Click(object sender, RoutedEventArgs e)
        {
            AdminPanel ap = (AdminPanel)App.Current.MainWindow;
            if(ap.BusListView.SelectedItems.Count > 0)
            {
               var b = (Bus)ap.BusListView.SelectedItem;
                dl.DeleteBus(b.Id);
                
            }
   
        }

        private void EditButton_Click(object sender, RoutedEventArgs e)
        {
            EditBusWindow ebw = new EditBusWindow();
            ebw.Show();
        }

        private void ExitButton_Click_1(object sender, RoutedEventArgs e)
        {

        }
    }
}
