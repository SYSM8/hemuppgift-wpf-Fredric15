using System.Windows;

namespace Hemuppgift_WPFtemplate
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //HEJ
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            GridWindow GridWindow = new GridWindow();
            GridWindow.Show();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            StackPanelWindow StackPanel = new StackPanelWindow();
            StackPanel.Show();
        }
    }
}