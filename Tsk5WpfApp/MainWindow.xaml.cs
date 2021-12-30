using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
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

namespace Tsk5WpfApp
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
        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            string fontName = ((sender as ComboBox).SelectedItem as TextBlock).Text;
            if (textBox != null)
            {
                textBox.FontFamily = new FontFamily(fontName);
            }

        }

        private void ComboBox_SelectionChanged_1(object sender, SelectionChangedEventArgs e)
        {
            string fontSize = ((sender as ComboBox).SelectedItem as TextBlock).Text;
            if (textBox != null)
            {
                textBox.FontSize = Convert.ToDouble(fontSize);
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string but1 = Convert.ToString(textBox.FontWeight);
            if (textBox != null)
            {
                if (but1 != "Bold")
                {
                    textBox.FontWeight = FontWeights.Bold;
                }
                else if (but1 == "Bold")
                {
                    textBox.FontWeight = FontWeights.Normal;
                }
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            string but2 = Convert.ToString(textBox.FontStyle);
            if (textBox != null)
            {
                if (but2 != "Italic")
                {
                    textBox.FontStyle = FontStyles.Italic;
                }
                else if (but2 == "Italic")
                {
                    textBox.FontStyle = FontStyles.Normal;
                }
            }
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            string but3 = Convert.ToString(textBox.TextDecorations);
            if (textBox != null)
            {
                if (textBox.TextDecorations != TextDecorations.Underline)
                {
                    textBox.TextDecorations = TextDecorations.Underline;
                }
                else if (textBox.TextDecorations == TextDecorations.Underline)
                {
                    textBox.TextDecorations = null;
                }
            }
        }

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            //RadioButton radioButton = RadioButton as sender;
            if (textBox != null)
            {
                textBox.Foreground = Brushes.Black;
            }
        }

        private void RadioButton_Checked_1(object sender, RoutedEventArgs e)
        {
            if (textBox != null)
            {
                textBox.Foreground = Brushes.Red;
            }
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Тектовые файлы (*.txt)|*.txt|Все файлы (*.*)|(*.*)";
            if (openFileDialog.ShowDialog()==true)
            {
                textBox.Text = File.ReadAllText(openFileDialog.FileName);
            }
        }

        private void MenuItem_Click_1(object sender, RoutedEventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Тектовые файлы (*.txt)|*.txt|Все файлы (*.*)|(*.*)";
            if (saveFileDialog.ShowDialog()==true)
            {
                File.WriteAllText(saveFileDialog.FileName, textBox.Text);
            }
        }

        private void MenuItem_Click_2(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
    }
}
