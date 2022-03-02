using Common;
using System;
using System.Windows;

namespace Calculator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        double PreviousValue;
        public MainWindow()
        {
            InitializeComponent();
            btnDezimal.Visibility = Visibility.Hidden;
        }

        private void calculate_Click(object sender, RoutedEventArgs e)
        {
            var resultDouble = calculate.CalculationMethod(textBox_number1.Text);
            lblcalculation.Content = resultDouble;
            PreviousValue = resultDouble;
            livHistoryList.Items.Insert(0, textBox_number1.Text + " = " + resultDouble);
        }

        private void fraction_Click(object sender, RoutedEventArgs e)
        {
            string value = Convert.ToString(lblcalculation.Content);
            var ConvertedValue = calculate.ConvertToFraction(value);
            lblcalculation.Content = ConvertedValue;
            btnFraction.Visibility = Visibility.Hidden;
            btnDezimal.Visibility = Visibility.Visible;
        }

        private void dezimal_Click(object sender, RoutedEventArgs e)
        {
            lblcalculation.Content = PreviousValue.ToString();
            btnDezimal.Visibility = Visibility.Hidden;
            btnFraction.Visibility = Visibility.Visible;
        }
    }
}
