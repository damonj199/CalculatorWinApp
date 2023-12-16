using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace MyFirstWinApp
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

        public double _resultValue = 0;
        private string _operation = "";
        private void ButtonNumber_Click(object sender, RoutedEventArgs e)
        {
            if(TextboxResult.Text == "0")
            {
                TextboxResult.Clear();
            }
            TextboxResult.Text += ((Button)sender).Content;
        }

        private void ButtonOperator_Click(object sender, RoutedEventArgs e)
        {
            _resultValue = Double.Parse(TextboxResult.Text);
            TextboxResult.Text = "";
            TextboxResult.Text += ((Button)sender).Content;

            if (TextboxResult.Text == "+")
            {
                _operation = "+";
            }
            else if (TextboxResult.Text == "-")
            {
                _operation = "-";
            }
            else if(TextboxResult.Text == "*")
            {
                _operation = "*";
            }
            else if (TextboxResult.Text == "/")
            {
                _operation = "/";
            }

            TextboxResult.Text = "";
        }

        private void ButtonEqual_Click(object sender, RoutedEventArgs e)
        {
            double result = 0;
            if (_operation == "+")
            {
                result = Double.Parse(TextboxResult.Text) + _resultValue;
                _operation = "";
            }
            else if (_operation == "-")
            {
                result = _resultValue - Double.Parse(TextboxResult.Text);
                _operation = "";
            }
            else if (_operation == "*")
            {
                result = _resultValue * Double.Parse(TextboxResult.Text);
                _operation = "";
            }
            else if (_operation == "/")
            {
                result = _resultValue / Double.Parse(TextboxResult.Text);
                _operation = "";
            }
            TextboxResult.Text = result.ToString();
        }

        private void ButtonClier_Click(object sender, RoutedEventArgs e)
        {
            TextboxResult.Clear();
            _resultValue = 0;
            _operation = "";
        }
    }
}