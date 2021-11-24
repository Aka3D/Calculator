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
using System.Windows.Navigation;
using System.Windows.Shapes;
using Common;
using Calculate.DataAccess;

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

        private void textBox_zahl1_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void textBox_zahl2_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void comboBox_operation_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ComboBoxItem operation = (ComboBoxItem)comboBox_Operation.SelectedItem;
            if (String.IsNullOrEmpty(operation?.Content?.ToString()))
                return;
            string value = operation.Content.ToString();

            if (operation.Content.ToString() == "+")
            {
                calculate.state = calculate.State.Addition;
            }
            else if (operation.Content.ToString() == "-")
            {
                calculate.state = calculate.State.Subtraction;
            }
            else if (operation.Content.ToString() == "*")
            {
                calculate.state = calculate.State.Multiplication;
            }
            else if (operation.Content.ToString() == "/")
            {
                calculate.state = calculate.State.Division;
            }
        }

        private void calculate_Click(object sender, RoutedEventArgs e)
        {
            string op = comboBox_Operation.Text;
            float number1 = float.Parse(textBox_number1.Text);
            float number2 = float.Parse(textBox_number2.Text);
            string endresult = calculate.LoadState(number1, number2);
            calculation.Content = $"{number1} {op} {number2} = {endresult}";
        }
    }
}
