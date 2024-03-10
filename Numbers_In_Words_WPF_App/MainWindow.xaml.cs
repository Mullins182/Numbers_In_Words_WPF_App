
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

        public string input;

        public bool taskActive = false;

        public int inputDelayStdValue   = 165;
        public int inputDelay           = 165;

        public MainWindow()
        {
            InitializeComponent();

            Number_input.Focus();
        }

        private void Number_input_GotFocus(object sender, RoutedEventArgs e)
        {

        }

        private void Number_input_GotKeyboardFocus(object sender, KeyboardFocusChangedEventArgs e)
        {
            Number_input.CaretBrush = Brushes.Red;
        }

        private async void Number_input_TextChanged(object sender, TextChangedEventArgs e)
        {

            if(Number_input.Text.Length > 18)                              // Integer length of 18 digits is Trillion
            {
                Number_input.Text = Number_input.Text.Remove(18, 1);     // removes the last char typed into textbox
                Number_input.Select(Number_input.Text.Length, 0);       // Sets the Cursor to end of text after remove method was executed
            }
            else
            {
                if (taskActive)
                {
                    inputDelay = inputDelayStdValue;
                }
                else
                {
                    bool validValue = false;
                    taskActive      = true;

                    Number_input.Foreground = Brushes.DarkGoldenrod;

                    while (inputDelay > 0)
                    {
                        await Task.Delay(1);
                        inputDelay--;
                    }

                    inputDelay = inputDelayStdValue;

                    if (Number_input.Text == "exit")
                    {
                        NumberInWords.Content = "CIAO BELLA :D";
                        await Task.Delay(3111);
                        this.Close();
                    }

                    foreach (var item in Number_input.Text)
                    {
                        if ((int)item < 48 || (int)item > 57)
                            validValue = false;
                        else
                            validValue = true;
                    }

                    if (!validValue)
                    {
                        NumberInWords.Content = "ERROR ! TYPE IN NUMBERS PLS :P";
                        Number_input.SelectAll();
                        Number_input.Foreground = Brushes.Red;
                    }
                    else
                    {
                        Number_input.SelectAll();
                        Number_input.Foreground = Brushes.Red;

                        if (Number_input.Text == "")
                        {
                            NumberInWords.Content = "Type Smth ! :)";
                        }
                        else
                        {
                            input = Number_input.Text;

                            NumberInWords.Content = numbers_to_words.CheckInput(input);
                        }
                    }

                    Number_input.Focusable = false;

                    await Task.Delay(2222);

                    Number_input.Focusable = true;
                    taskActive = false;
                    Number_input.Focus();
                }
            }

        }
        private void Quit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
