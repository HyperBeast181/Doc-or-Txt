using Microsoft.Win32;
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
using System.IO;



namespace WpfAppmain
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
        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string text = InputTextBox.Text;

            SaveFileDialog saveFileDialog = new SaveFileDialog();
            if (DocRadioBtn.IsChecked == true)
            {
                saveFileDialog.Filter = "Word Document|*.doc";
            }
            else if (TxtRadioBtn.IsChecked == true)
            {
                saveFileDialog.Filter = "Text file|*.txt";
            }

            if (saveFileDialog.ShowDialog() == true)
            {
                File.WriteAllText(saveFileDialog.FileName, text);
                MessageBox.Show("Файл сохранен в: " + saveFileDialog.FileName);
            }
        }
    }
}