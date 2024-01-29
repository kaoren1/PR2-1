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

namespace PR12
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Button> b;

        public MainWindow()
        {
            InitializeComponent();
            b = new List<Button> { _1, _2, _3, _4, _5, _6, _7, _8, _9 };
        }
        private bool Check()
        {
            int i = 0;
            foreach (Button button in b)
            {
                if (button.IsEnabled == false)
                {
                    i++;
                }
            }
            if (i == 9)
                return true;
            else
                return false;
        }

        private void Random()
        {
            Random r = new Random();
            int i = 0;
            int nomer = r.Next(0, 9);
            if (Check() == true)
            {
                Result();
            }
            else
            {
                while (b[nomer].IsEnabled == false)
                {
                    nomer = r.Next(0, 9);
                }
                b[nomer].Content = "O";
                b[nomer].IsEnabled = false;
            }
        }

        private void Block()
        {
            _1.IsEnabled = false;
            _2.IsEnabled = false;
            _3.IsEnabled = false;
            _4.IsEnabled = false;
            _5.IsEnabled = false;
            _6.IsEnabled = false;
            _7.IsEnabled = false;
            _8.IsEnabled = false;
            _9.IsEnabled = false;
        }

        private void Result()
        {
            if (_1.Content == "X" && _2.Content == "X" && _3.Content == "X" || _3.Content == "X" && _6.Content == "X" && _9.Content == "X" 
                || _7.Content == "X" && _8.Content == "X" && _9.Content == "X" || _1.Content == "X" && _4.Content == "X" && _7.Content == "X"
                || _2.Content == "X" && _5.Content == "X" && _8.Content == "X" || _4.Content == "X" && _5.Content == "X" && _6.Content == "X"
                || _1.Content == "X" && _5.Content == "X" && _9.Content == "X" || _7.Content == "X" && _5.Content == "X" && _3.Content == "X")
            {
                MessageBox.Show("Вы выиграли");
                Block();
            }
            else if (_1.Content == "O" && _2.Content == "O" && _3.Content == "O" || _3.Content == "O" && _6.Content == "O" && _9.Content == "O"
                    || _7.Content == "O" && _8.Content == "O" && _9.Content == "O" || _1.Content == "O" && _4.Content == "O" && _7.Content == "O"
                    || _2.Content == "O" && _5.Content == "O" && _8.Content == "O" || _4.Content == "O" && _5.Content == "O" && _6.Content == "O"
                    || _1.Content == "O" && _5.Content == "O" && _9.Content == "O" || _7.Content == "O" && _5.Content == "O" && _3.Content == "O")
            {
                MessageBox.Show("Робот выиграл");
                Block();
            }
            else
            {
                MessageBox.Show("Ничья");
                Block();
            }
        }

        private void _1_Click(object sender, RoutedEventArgs e)
        {
            (sender as Button).Content = "X";
            (sender as Button).IsEnabled = false;
            Random();
        }

        private void _2_Click(object sender, RoutedEventArgs e)
        {
            (sender as Button).Content = "X";
            (sender as Button).IsEnabled = false;
            Random();
        }

        private void _3_Click(object sender, RoutedEventArgs e)
        {
            (sender as Button).Content = "X";
            (sender as Button).IsEnabled = false;
            Random();
        }

        private void _4_Click(object sender, RoutedEventArgs e)
        {
            (sender as Button).Content = "X";
            (sender as Button).IsEnabled = false;
            Random();
        }

        private void _5_Click(object sender, RoutedEventArgs e)
        {
            (sender as Button).Content = "X";
            (sender as Button).IsEnabled = false;
            Random();
        }

        private void _6_Click(object sender, RoutedEventArgs e)
        {
            (sender as Button).Content = "X";
            (sender as Button).IsEnabled = false;
            Random();
        }

        private void _7_Click(object sender, RoutedEventArgs e)
        {
            (sender as Button).Content = "X";
            (sender as Button).IsEnabled = false;
            Random();
        }

        private void _8_Click(object sender, RoutedEventArgs e)
        {
            (sender as Button).Content = "X";
            (sender as Button).IsEnabled = false;
            Random();
        }

        private void _9_Click(object sender, RoutedEventArgs e)
        {
            (sender as Button).Content = "X";
            (sender as Button).IsEnabled = false;
            Random();
        }

        private void NewGame_Click(object sender, RoutedEventArgs e)
        {
            _1.Content = " ";
            _2.Content = " ";
            _3.Content = " ";
            _4.Content = " ";
            _5.Content = " ";
            _6.Content = " ";
            _7.Content = " ";
            _8.Content = " ";
            _9.Content = " ";

            _1.IsEnabled = true;
            _2.IsEnabled = true;
            _3.IsEnabled = true;
            _4.IsEnabled = true;
            _5.IsEnabled = true;
            _6.IsEnabled = true;
            _7.IsEnabled = true;
            _8.IsEnabled = true;
            _9.IsEnabled = true;
        }
    }
}