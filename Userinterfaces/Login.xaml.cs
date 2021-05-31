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
using car_app.DataBase;
using car_app.Models;

namespace car_app.Userinterfaces
{
    /// <summary>
    /// Interaction logic for Login.xaml
    /// </summary>
    public partial class Login : UserControl
    {
        


        public Login()
        {
            InitializeComponent();
            
            using (DatabaseRepository repository = new DatabaseRepository())
            {
                Customer customer = new Customer()
                {
                    ID = 1,
                    Username = "test1@gmail.com",
                    Password = "1234"
                };

                repository.Customers.Add(customer);

            }
        }

        

        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            Main_Dashboard main_Dashboard = new Main_Dashboard();

            
        }

        

        private void Border_MouseDown(object sender,  MouseButtonEventArgs e)
        {
           
        }

       
        private void btnExit_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
    }
}
