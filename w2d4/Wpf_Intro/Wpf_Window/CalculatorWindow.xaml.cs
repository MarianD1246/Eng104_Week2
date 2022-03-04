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
using Calculator_App;

namespace Wpf_Window
{
    /// <summary>
    /// Interaction logic for CalculatorWindow.xaml
    /// </summary>
    public partial class CalculatorWindow : Window
    {
        private double result;
        public Calculator _calculator;
        public CalculatorWindow()
        {
            _calculator = new Calculator();
            InitializeComponent();
        }

        private void makeResN1(object sender, RoutedEventArgs e)
        {
            tbxNum1.Text = result.ToString();
        }

        private void makeResN2(object sender, RoutedEventArgs e)
        {
            tbxNum2.Text = result.ToString();
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            MathOp(0);
        }
        private void btnSub_Click(object sender, RoutedEventArgs e)
        {
            MathOp(1);
        }
        private void btnMult_Click(object sender, RoutedEventArgs e)
        {
            MathOp(2);
        }
        private void btnDiv_Click(object sender, RoutedEventArgs e)
        {
            MathOp(3);
        }

        private void MathOp(int op)
        {
            var success1 = double.TryParse(tbxNum2.Text, out double num2);
            var success2 = double.TryParse(tbxNum1.Text, out double num1);

            if (success1 && success2)
            {
                _calculator.Num1 = num1;
                _calculator.Num2 = num2;

                result = _calculator.Multiply();
                lblResult.Content = _calculator.Multiply();
                switch (op)
                {
                    case 0:
                        result = _calculator.Add();
                        lblResult.Content = _calculator.Add();
                        break;
                    case 1:
                        result = _calculator.Subtract();
                        lblResult.Content = _calculator.Subtract();
                        break;
                    case 2:
                        result = _calculator.Multiply();
                        lblResult.Content = _calculator.Multiply();
                        break;
                    case 3:
                        result = _calculator.Divide();
                        lblResult.Content = _calculator.Divide();
                        break;
                }
            }
            else
            {
                lblResult.Content = "Invalid input";
            }
        }

        private void tbxNum1_TextChanged(object sender, TextChangedEventArgs e)
        {
            //var success = double.TryParse(tbxNum1.Text, out double num1);
            //if (success) {
            //    _calculator.Num1 = num1;
            //}
            //else {
            //    lblResult.Content = "Invalid input";
            //}   
        }

        private void tbxNum2_TextChanged(object sender, TextChangedEventArgs e)
        {
            //var success = double.TryParse(tbxNum2.Text, out double num2);
            //if (success)
            //{
            //    _calculator.Num2 = num2;
            //}
            //else
            //{
            //    lblResult.Content = "Invalid input";
            //}
        }
    }
}
