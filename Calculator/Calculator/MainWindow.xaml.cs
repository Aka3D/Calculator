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
        string Storage1;
        string Storage2;
        string Storage3;
        int StoNr1 = 1;
        int StoNr2 = 1;
        int StoNr3 = 1;
        public MainWindow()
        {
            InitializeComponent();
            btnDezimal.Visibility = Visibility.Hidden;
        }

        public void calculate_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(textBox_rechnung.Text))
            {
                Alert alert = new Alert();
                alert.Show();
            }

            var resultDouble = calculate.CalculationMethod(textBox_rechnung.Text);
            lblcalculation.Content = resultDouble;
            PreviousValue = resultDouble;
            livHistoryList.Items.Insert(0, textBox_rechnung.Text + " = " + resultDouble);
        }

        public void fraction_Click(object sender, RoutedEventArgs e)
        {
            double value;
            value = (PreviousValue);
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

        public void btnSto1_Click(object sender, RoutedEventArgs e)
        {
            if (StoNr1 == 1)
            {
                Storage1 = lblcalculation.Content.ToString();
                StoNr1++;
                return;
            }
            else if (StoNr1 == 2)
            {
                textBox_rechnung.Text += Storage1;
                StoNr1--;
                return;
            }
        }

        public void btnSto2_Click(object sender, RoutedEventArgs e)
        {
            if (StoNr2 == 1)
            {
                Storage2 = lblcalculation.Content.ToString();
                StoNr2++;
                return;
            }
            else if (StoNr2 == 2)
            {
                textBox_rechnung.Text += Storage2;
                StoNr2--;
                return;
            }
        }

        public void btnSto3_Click(object sender, RoutedEventArgs e)
        {
            if (StoNr3 == 1)
            {
                Storage3 = lblcalculation.Content.ToString();
                StoNr3++;
                return;
            }
            else if (StoNr3 == 2)
            {
                textBox_rechnung.Text += Storage3;
                StoNr3--;
                return;
            }
        }
    }
}
