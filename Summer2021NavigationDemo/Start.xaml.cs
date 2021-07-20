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
    /// Interaction logic for Start.xaml
    /// </summary>
    public partial class Start : Page
    {
        public Start()
        {
            InitializeComponent();
        }

        private void NextButton_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("Map.xaml", UriKind.Relative));
            if (PlayerNameInput.Text != "")
            {
                MainWindow.game.Player.Name = PlayerNameInput.Text;
            }
        }

        private void Grid_Loaded(object sender, RoutedEventArgs e)
        {
            Data.Text = $"Welcome to {MainWindow.game.Name} {MainWindow.game.Player.Name}.\nEnter the name you wish to be known by below\nthen click the button to start your adventure!";
        }
    }
}
