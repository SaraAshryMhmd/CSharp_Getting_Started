using Intro_To_WPF.Core;
using System;
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

namespace Intro_To_WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            var person = new Person();
            person.Name = "Test";
            person.SetFirstName("Test2");
            var firstName = person.GetFirstName();
        }

        private void _incrementedValue_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            // Allow only numeric input
            if (!e.Text.IsNumeric())
            {
                e.Handled = true; // Mark the event as handled to prevent the character from being added to the TextBox
            }
        }

        private void _incrementedValue_GotFocus(object sender, RoutedEventArgs e)
        {
            // Clear the initial hint when the TextBox gets focus
            if (_incrementedValue.Text == "Enter only numeric value")
            {
                _incrementedValue.Text = "";
            }
        }

        private void _incrementedValue_LostFocus(object sender, RoutedEventArgs e)
        {
            // Restore the initial hint if the TextBox is left empty
            if (string.IsNullOrWhiteSpace(_incrementedValue.Text))
            {
                _incrementedValue.Text = "Enter only numeric value";
            }
        }

        private void _onIncrement_Click(object sender, RoutedEventArgs e)
        {
            // Clear the initial hint when the TextBox gets focus
            if (_incrementedValue.Text == "Enter only numeric value")
            {
                _incrementedValue.Text = "10";
            }

            //string sara = "Sara Ashry";
            //sara.IsNumeric();

            //var result = Extensions.IsNumeric2(sara);

            Extensions.DISPAY_NUMERIC_VALUE += int.Parse(_incrementedValue.Text);
            _displayNumericValue.Text = Extensions.DISPAY_NUMERIC_VALUE.ToString();
        }
    }
}