using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Controls;
using System.Windows.Media;

namespace Lab7_8
{
    public partial class ColorUserControl : UserControl
    {

        public ColorUserControl()
        {
            InitializeComponent();
        }

        private void Txt_TextChanged(object sender, TextChangedEventArgs e)
        {
            string str = txt.Text;
            try
            {
                var color = (Color)ColorConverter.ConvertFromString(str);
                var prevcolor = txt.Background;
                Border.Background = new SolidColorBrush(color);
                txt.Background = new SolidColorBrush(color);
                if(prevcolor.ToString() != color.ToString())
                {
                    txt.Foreground = prevcolor;
                }
            }
            catch
            {

            }
        }
    }
}
