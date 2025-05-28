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

namespace Wpf_1_menuk
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
        private void New_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Új fájlt hoztál létre");
        }
        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
        private void About_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Ez egy egyszerű WPF alkalmazás", "Névjegy");
        }
        private void Button1_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Az első gombot nyomtad meg");
        }
        private void Button2_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("A második gombot nyomtad meg");
        }
        private void Copy_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Másolás");
        }
        private void Paste_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Beillesztés");
        }
    }
}