using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Navigation;

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

        private void LoadPlayerInformation()
        {
            PlayerName.Text = MainWindow.game.Player.Name;
            PlayerInventory.Text = MainWindow.game.Player.ShowInventoryItemNames();
        }

        private void ShowAvatarStatus()
        {
            //check Avatar status
            if (MainWindow.game.Player.currentArea.Name == "Sea of Seawater")
            {
                SolidColorBrush green = new SolidColorBrush(Colors.GreenYellow);
                MainWindow.game.Player.Status = green;
            }
            else
            {
                SolidColorBrush notgreen = new SolidColorBrush(
                    Color.FromArgb(
                        255, //alpha
                        169, //red
                        88, //green
                        125 //blue
                        )
                    );
                MainWindow.game.Player.Status = notgreen;
            }


            //set color status
            AvatarStatus.Fill = MainWindow.game.Player.Status;
        }
        private void ShowLocationButtons()
        {
            //buttons
            Area0.Content = MainWindow.game.Areas[0].Name;
            Area1.Content = MainWindow.game.Areas[1].Name;
            Area2.Content = MainWindow.game.Areas[2].Name;
        }
        private void ShowRobot()
        {
            RobotHead.Source = MainWindow.game.Player.Friend.RobotHeadImageSource;
        }
        private void MapGrid_Loaded(object sender, RoutedEventArgs e)
        {
            LoadPlayerInformation();
            ShowAvatarStatus();
            ShowLocationButtons();
            ShowRobot();
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
