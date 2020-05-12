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

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public bool Click = false;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            buttonClick(sender, e);
        }
        private void button2_Click(object sender, RoutedEventArgs e)
        {
            buttonClick(sender, e);
        }

        private void button3_Click(object sender, RoutedEventArgs e)
        {
            buttonClick(sender, e);
        }

        private void button4_Click(object sender, RoutedEventArgs e)
        {
            buttonClick(sender, e);
        }

        private void button5_Click(object sender, RoutedEventArgs e)
        {
            buttonClick(sender, e);
        }

        private void button6_Click(object sender, RoutedEventArgs e)
        {
            buttonClick(sender, e);
        }

        private void button7_Click(object sender, RoutedEventArgs e)
        {
            buttonClick(sender, e);
        }

        private void button8_Click(object sender, RoutedEventArgs e)
        {
            buttonClick(sender, e);
        }

        public void buttonClick(object sender, RoutedEventArgs e)
        {
            if (Click == false)
            {
                button1.Background = new SolidColorBrush(Colors.Firebrick);
                button2.Background = new SolidColorBrush(Colors.Magenta);
                button3.Background = new SolidColorBrush(Colors.Lavender);
                button4.Background = new SolidColorBrush(Colors.Yellow);
                button5.Background = new SolidColorBrush(Colors.Cyan);
                button6.Background = new SolidColorBrush(Colors.Green);
                button7.Background = new SolidColorBrush(Colors.Blue);
                button8.Background = new SolidColorBrush(Colors.Red);
                Click = true;
            }
            else
            {
                button1.Background = new SolidColorBrush(Colors.Red);
                button2.Background = new SolidColorBrush(Colors.Blue);
                button3.Background = new SolidColorBrush(Colors.Green);
                button4.Background = new SolidColorBrush(Colors.Cyan);
                button5.Background = new SolidColorBrush(Colors.Yellow);
                button6.Background = new SolidColorBrush(Colors.Lavender);
                button7.Background = new SolidColorBrush(Colors.Magenta);
                button8.Background = new SolidColorBrush(Colors.Firebrick);
                Click = false;
            }
        }
    }
}
