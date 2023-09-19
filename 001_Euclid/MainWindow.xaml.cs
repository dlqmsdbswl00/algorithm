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
            // y가 0이라면 x가 최대공약수이므로 x 리턴
            if (y == 0)     
                return x;
            // x와 y의 나머지를 새로운 x로 설정하고 y 그대로 유지
            else
                return Euclid(y, x % y);  
        }
    }
}
