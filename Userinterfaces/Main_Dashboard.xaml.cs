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
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace car_app.Userinterfaces
{
    /// <summary>
    /// Interaction logic for Main_Dashboard.xaml
    /// </summary>
    
    public partial class Main_Dashboard : UserControl
    {

        public Main_Dashboard()
        {
            InitializeComponent();
        }

     
     
        private void ButtonOpenMenu_Click(object sender, RoutedEventArgs e)
        {
            ButtonCloseMenu.Visibility = Visibility.Visible;
            ButtonOpenMenu.Visibility = Visibility.Collapsed;
        }

        private void ButtonCloseMenu_Click(object sender, RoutedEventArgs e)
        {
            ButtonCloseMenu.Visibility = Visibility.Collapsed;
            ButtonOpenMenu.Visibility = Visibility.Visible;
        }
        private int currentElement = 0;

        public static NavigationService NavigationService { get; internal set; }

        private void Left_Click(object sender, RoutedEventArgs e)
        {
            if (currentElement < 2)
            {
                currentElement++;
                AnimateCarousel();
            }
        }

        private void Right_Click(object sender, RoutedEventArgs e)
        {
            if (currentElement > 0)
            {
                currentElement--;
                AnimateCarousel();
            }
        }

        private void AnimateCarousel()
        {
            Storyboard storyboard = (this.Resources["CarouselStoryboard"] as Storyboard);
            DoubleAnimation animation = storyboard.Children.First() as DoubleAnimation;
            animation.To = -this.Width * currentElement;
            storyboard.Begin();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Conditions conditions = new Conditions();
         

        }
    }
}
