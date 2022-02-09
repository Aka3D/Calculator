using Common;
using System.Windows;

namespace Calculator
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

        private void calculate_Click(object sender, RoutedEventArgs e)
        {
            var resultDouble = calculate.CalculationMethod(textBox_number1.Text);
            /*
            string op = comboBox_Operation.Text;
            float number1 = float.Parse(textBox_number1.Text);
            float number2 = float.Parse(textBox_number2.Text);
            string endresult = calculate.LoadState(number1, number2);
            calculation.Content = $"{number1} {op} {number2} = {endresult}";
            */
            lblcalculation.Content = resultDouble;
        }
    }
}
