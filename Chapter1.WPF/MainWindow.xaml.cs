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

namespace Chapter1.WPF
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

        public void UpdateTooltip(string text)
        {
            if (string.IsNullOrEmpty(text))
            {
                this.tooltipLabel.Content = "Type your name and press Enter";
            }
            else
            {
                this.tooltipLabel.Content = $"Current input: {text}";
            }
        }

        public void OnInputChanged(object sender, TextChangedEventArgs e)
        {
            var textBox = sender as TextBox;
            if (textBox != null)
            {
                UpdateTooltip(textBox.Text);
            }
        }

        public void OnInputKeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                var textBox = sender as TextBox;
                if (textBox != null)
                {
                    var inputText = textBox.Text;
                    if (string.IsNullOrWhiteSpace(inputText))
                    {
                        this.tooltipLabel.Content = "Input is empty! Enter your name again!";
                        return;
                    }

                    MessageBox.Show(
                        HelloMessageFormatter.
                        Formatter.
                        FormatHelloMessage(inputText));
                }
            }
        }
    }
}