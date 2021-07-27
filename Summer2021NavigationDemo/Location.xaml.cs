using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;

namespace Summer2021NavigationDemo
{
    /// <summary>
    /// Interaction logic for Location.xaml
    /// </summary>
    public partial class Location : Page
    {
        Area area = MainWindow.game.Player.currentArea;
        
        public Location()
        {
            InitializeComponent();
        }

        private void LocationGrid_Loaded(object sender, RoutedEventArgs e)
        {
            LocationName.Text = area.Name;
            LocationDescription.Text = area.Description;
            LocationImage.Source = area.Image;
        }

        private void MapButton_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("Map.xaml", UriKind.Relative));
        }
    }
}
