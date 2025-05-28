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

namespace wpf_szerda
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
        private void ApplySettings_Click(object sender, RoutedEventArgs e)
        {
            string message = "Beállítások:\n";
            if (chkNotify.IsChecked == true)
            {
                message += "- Értesítések bekapcsolva\n";
            }
            else
            {
                message += "- Értesítések kikapcsolva\n";
            }
            if (rdoLightMode.IsChecked == true)
            {
                message += "- Világos téma kiválasztva";
            }
            else if (rdoDarkMode.IsChecked == true)
            {
                message += "- Sötét téma kiválasztva";
            }
            MessageBox.Show(message, "Beállítások mentve");
        }
    }
}