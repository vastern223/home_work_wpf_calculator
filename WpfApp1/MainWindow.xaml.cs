using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            textBox1.Text = "";
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            textBox.Text = "";
            textBox1.Text = "";
        }

        private void button3_Click(object sender, RoutedEventArgs e)
        {
            textBox.Text = textBox.Text.Remove(textBox.Text.Length - 1, 1);
        }

        private void button4_Click(object sender, RoutedEventArgs e)
        {
            if (Check_operations())
                textBox.Text += '/';
        }
        private void button5_Click(object sender, RoutedEventArgs e)
        {
            textBox.Text += 7;
        }

        private void button6_Click(object sender, RoutedEventArgs e)
        {

            textBox.Text += 8;
        }

        private void button7_Click(object sender, RoutedEventArgs e)
        {

            textBox.Text += 9;
        }

        private void button8_Click(object sender, RoutedEventArgs e)
        {
            if (Check_operations())
                textBox.Text += '*';
        }

        private void button9_Click(object sender, RoutedEventArgs e)
        {

            textBox.Text += 4;
        }

        private void button10_Click(object sender, RoutedEventArgs e)
        {

            textBox.Text += 5;
        }

        private void button11_Click(object sender, RoutedEventArgs e)
        {

            textBox.Text += 6;
        }

        private void button12_Click(object sender, RoutedEventArgs e)
        {
            if (Check_operations())
                textBox.Text += '-';
        }

        private void button13_Click(object sender, RoutedEventArgs e)
        {

            textBox.Text += 1;
        }

        private void button14_Click(object sender, RoutedEventArgs e)
        {

            textBox.Text += 2;
        }

        private void button15_Click(object sender, RoutedEventArgs e)
        {

            textBox.Text += 3;
        }

        private void button16_Click(object sender, RoutedEventArgs e)
        {
            if (Check_operations())
                textBox.Text += '+';
        }

        private bool Check_operations()
        {
            if (textBox.Text != "")
            {
                if (textBox.Text[textBox.Text.Length - 1] == '+') { return false; }
                else if (textBox.Text[textBox.Text.Length - 1] == '-') { return false; }
                else if (textBox.Text[textBox.Text.Length - 1] == '*') { return false; }
                else if (textBox.Text[textBox.Text.Length - 1] == '/') { return false; }
                else if (textBox.Text[textBox.Text.Length - 1] == ',') { return false; }
                else { return true; }
            }
            else
            {
                return false;
            }

        }
        private void button17_Click_1(object sender, RoutedEventArgs e)
        {
            if (textBox.Text != "" && Check_operations())
                textBox.Text += ',';
        }

        private void button18_Click_1(object sender, RoutedEventArgs e)
        {
            textBox.Text += 0;
        }

        private void button19_Click_1(object sender, RoutedEventArgs e)
        {


            List<float> numbers = new List<float>();
            List<char> cumbols = new List<char>();
            string number = null;
            char sumbol;

            for (int i = 0; i < textBox.Text.Length; i++)
            {
                if (textBox.Text[i] >= 48 && textBox.Text[i] <= 57 || textBox.Text[i] == 44)
                {
                    number += textBox.Text[i];
                }
                else
                {
                    numbers.Add(float.Parse(number));
                    number = "";
                    sumbol = textBox.Text[i];
                    cumbols.Add(sumbol);
                }
            }
            numbers.Add(float.Parse(number));
            float sum = numbers[0];
            for (int i = 1, j = 0; i < numbers.Count; i++)
            {

                if (cumbols[j] == '+') { sum += numbers[i]; }
                else if (cumbols[j] == '-') { sum -= numbers[i]; }
                else if (cumbols[j] == '*') { sum *= numbers[i]; }
                else if (cumbols[j] == '/') { sum /= numbers[i]; }
                j++;
            }

            textBox1.Text = sum.ToString();


        }

    }
}
