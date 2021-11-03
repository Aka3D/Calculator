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

        float endresult;
        float op;

        enum State
        {
            Normal,
            Addition,
            Subtraction,
            Multiplication,
            Division
        }

        State state = State.Normal;

        private void loadState(float number1, float number2, float endresult)
        {
            switch (state)
            {
                case State.Normal:
                    

                    break;
                case State.Addition:

                    endresult = number1 + number2;


                    break;
                case State.Subtraction:
                    



                    break;
                case State.Multiplication:
                    



                    break;
                case State.Division:


                    break;
            }
        }

        private void textBox_zahl1_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void textBox_zahl2_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void comboBox_operation_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void calculate_Click(object sender, RoutedEventArgs e)
        {
            float number1 = float.Parse(textBox_number1.Text);
            float number2 = float.Parse(textBox_number2.Text);
            calculation.Content = $"{number1} {op} {number2} = {endresult}";
        }
    }
}
