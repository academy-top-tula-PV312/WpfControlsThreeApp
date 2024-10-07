using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfControlsThreeApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnLineUp_Click(object sender, RoutedEventArgs e)
        {
            scroll.LineUp();
        }

        private void btnLineDown_Click(object sender, RoutedEventArgs e)
        {
            scroll.LineDown();
        }

        private void btnLineRight_Click(object sender, RoutedEventArgs e)
        {
            scroll.LineRight();
        }

        private void btnLineLeft_Click(object sender, RoutedEventArgs e)
        {
            scroll.LineLeft();
        }

        private void btnToEnd_Click(object sender, RoutedEventArgs e)
        {
            scroll.ScrollToEnd();
        }

        private void btnToHome_Click(object sender, RoutedEventArgs e)
        {
            scroll.ScrollToHome();
        }
    }
}