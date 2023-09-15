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

namespace _005_ClosestPair
{
    /// <summary>
    /// MainWindow.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class MainWindow : Window
    {
        const int P = 10000;
        Point[] points = new Point[P];
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnCreate_Click(object sender, RoutedEventArgs e)
        {
            int n = int.Parse(txtNo.Text);
            int noOfPoints;
            MakePointArray();
        }

        private void MakePointArray()
        {
            Random r = new Random();

            for (int i = 0; i < noOfPoints;  i++) 
            {
                points[i] = new Point(r.NextDouble()*can.Width, r.NextDouble()*can.Height);
            }
            foreach (var p in points)
            {
                Ractangle rect = new Ractangle();
                rect.Width = rect.Height = 3;

            }
        }

        private void btnBrute_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnDivde_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
