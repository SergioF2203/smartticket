using System.Windows;



namespace ApplicationInterface
{
   

    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void AdminButton_Click(object sender, RoutedEventArgs e)
        {
            AdminAuthoriяationWindow aaw = new AdminAuthoriяationWindow();
            aaw.ShowDialog();
            this.Close();
        }
    }
}
