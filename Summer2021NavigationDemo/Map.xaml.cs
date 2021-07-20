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

namespace Summer2021NavigationDemo
{
    /// <summary>
    /// Interaction logic for Map.xaml
    /// </summary>
    public partial class Map : Page
    {
        //Refactor challenge - reduce redundancy in code : )
        public Map()
        {
            InitializeComponent();
        }

        private void MapGrid_Loaded(object sender, RoutedEventArgs e)
        {
            PlayerName.Text = MainWindow.game.Player.Name;
            PlayerInventory.Text = MainWindow.game.Player.ShowInventoryItemNames();

            //buttons
            Area0.Content = MainWindow.game.Areas[0].Name;
            Area1.Content = MainWindow.game.Areas[1].Name;
            Area2.Content = MainWindow.game.Areas[2].Name;
        }

        private void Area0_Click(object sender, RoutedEventArgs e)
        {
            MainWindow.game.Player.currentArea = MainWindow.game.Areas[0];
            NavigationService.Navigate(new Uri("Location.xaml", UriKind.Relative));
        }

        private void Area1_Click(object sender, RoutedEventArgs e)
        {
            MainWindow.game.Player.currentArea = MainWindow.game.Areas[1];
            NavigationService.Navigate(new Uri("Location.xaml", UriKind.Relative));
        }

        private void Area2_Click(object sender, RoutedEventArgs e)
        {
            MainWindow.game.Player.currentArea = MainWindow.game.Areas[2];
            NavigationService.Navigate(new Uri("Location.xaml", UriKind.Relative));
        }
    }
}
