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

namespace Exam22
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

        private void textBox1_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (textBox1.Text.Length < 4 || textBox1.Text.Length > 50) 
            {
                textBox1.Background = Brushes.Red;
                string text = "Минимальное количество символов 4, максимальное 50";
                textBloc1.Text = text;

            }
            else
            {
                textBox1.Background = Brushes.Yellow;
                string text1 = "Всё верно";
                textBloc1.Text = text1;
            }

        }

        private void textBox2_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (textBox2.Text.Length < 10 || textBox2.Text.Length > 35) 
            {
                textBox2.Background = Brushes.Red;
                string text = "Минимальное количество символов 10, максимальное 35";
                textBloc2.Text = text;

            }
            else
            {
                textBox2.Background = Brushes.Yellow;
                string text1 = "Всё верно";
                textBloc2.Text = text1;
            }

        }

        private void textBoxminus_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            if (!char.IsDigit(e.Text, e.Text.Length - 1) || (textBoxminus.Text == "" && e.Text == "-"))
            {
                e.Handled = true;
            }
        }
    }
}
