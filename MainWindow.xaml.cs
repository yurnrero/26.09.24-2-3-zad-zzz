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

namespace _26._09._24_2_3_zad_zzz
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            t1.TextChanged += (s, e) =>
            {
                if (double.TryParse(t1.Text, out double value))
                {
                    slider1.Value = value;
                }
            };

            slider1.ValueChanged += (s, e) =>
            {
                t1.Text = slider1.Value.ToString();
            };

            fontSizeInput.TextChanged += (s, e) =>
            {
                if (double.TryParse(fontSizeInput.Text, out double fontSize))
                {
                    textBlock.FontSize = fontSize;
                }
            };

            fontSizeSlider.ValueChanged += (s, e) =>
            {
                textBlock.FontSize = fontSizeSlider.Value;
            };
        }
    }

        

    


}