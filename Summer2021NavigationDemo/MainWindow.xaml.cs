using System.Windows;

namespace Summer2021NavigationDemo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public static Game game = new Game();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void MainWindowGrid_Loaded(object sender, RoutedEventArgs e)
        {
            ContentFrame.Navigate(new Start());
           
        }
    }
}
