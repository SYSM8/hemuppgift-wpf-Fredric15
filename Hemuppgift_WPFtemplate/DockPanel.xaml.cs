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
using System.Windows.Shapes;

namespace Hemuppgift_WPFtemplate
{
    /// <summary>
    /// Interaction logic for DockPanel.xaml
    /// </summary>
    public partial class DockPanel : Window
    {
        public DockPanel()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Image minBild = new Image();
            BitmapImage image = new BitmapImage(new Uri("C:\\Users\\fredr\\source\\repos\\hemuppgift-wpf-Fredric15\\Hemuppgift_WPFtemplate\\TrophyImage.jpg"));
            minBild.Source = image;
            minBild.Height = 200;
            MainGrid.Children.Add(minBild);
        }
    }
}
