using System.Windows;

namespace _001_Euclid
{
    /// Euclid 호제법 - 최대공약수
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            int x = int.Parse(textBox1.Text);
            int y = int.Parse(textBox2.Text);
            int gcd = Euclid(x, y);
            txtResult.Text = "GCD = " + gcd.ToString();
        }

        private int Euclid(int x, int y)
        {
            if (y == 0)
                return x;
            else
                return Euclid(y, x % y);
        }
    }
}
