using System.Windows;
namespace Clicker_WPF_
{
    public partial class MainWindow : Window
    {
        private int counter = 0;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            counter++;
            CounterText.Text = $"Счетчик:{counter}";
        }
    }
}