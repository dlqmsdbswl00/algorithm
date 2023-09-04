using System;
using System.Windows;
using System.Windows.Controls;

namespace _002_Factorial
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int n = int.Parse(TextBox.Text);
            long fact = 1;
            long rfact = 1;

            for(int i = 1; i < n; i++) 
            {
                fact = Factorial(i);
                rfact = rFactorial(i);
                string s = string.Format("Fact({0}) = {1} \nrFact({1}) = {2}", i, fact, rfact);
                listBox.Items.Add(s);
            }
        }

        private long Factorial(int x)       //반복문 이용
        {
            long f = 1;
            for (int i = 2; i<=x; i++)
                f *= i;
            return f;
        }
        private long rFactorial(int x)      //재귀적 알고리즘
        {
            if (x == 1)
                return 1;
            else
                return rFactorial(x - 1) * x;
        }
    }
}
