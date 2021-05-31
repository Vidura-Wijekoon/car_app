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

namespace car_app.Userinterfaces
{
    /// <summary>
    /// Interaction logic for Available_cars.xaml
    /// </summary>
    public partial class Available_cars : UserControl
    {
        public Available_cars()
        {
            InitializeComponent();
        }

        private void Grid_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
            }
        }

        private void btnGo_Click(object sender, RoutedEventArgs e)
        {
            Main_Dashboard main_Dashboard = new Main_Dashboard();

        }
    }
}
