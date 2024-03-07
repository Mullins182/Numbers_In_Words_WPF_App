using Numbers_In_Words_WPF_App.Classes;
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

namespace Numbers_In_Words_WPF_App
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        TranslateLogic numbers_to_words = new TranslateLogic();

        public static string input;

        public MainWindow()
        {
            InitializeComponent();            
        }


        private void Number_input_GotFocus(object sender, RoutedEventArgs e)
        {

        }

        private void Number_input_GotKeyboardFocus(object sender, KeyboardFocusChangedEventArgs e)
        {
            Number_input.CaretBrush = Brushes.Red;
        }

        private void Number_input_TextChanged(object sender, TextChangedEventArgs e)
        {
            input += Number_input.Text;

            NumberInWords.Content = numbers_to_words.input;

            numbers_to_words.CheckInput(input);
        }
    }
}
