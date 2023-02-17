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

namespace NewWord.LocalControls
{
    /// <summary>
    /// Логика взаимодействия для CounterUserControl.xaml
    /// </summary>
    public partial class CounterUserControl : UserControl
    {
        int i = 1;
        public CounterUserControl()
        {
            InitializeComponent();
            this.DataContext = this;
            TBValue.Text = Convert.ToString(i);
            UpButton.Content = char.ConvertFromUtf32(0x2191);
            DownButton.Content = char.ConvertFromUtf32(0x2193);
        }

        private void UpClick(object sender, RoutedEventArgs e)
        {
            i += 1;
            TBValue.Text = Convert.ToString(i);
        }

        private void DownClick(object sender, RoutedEventArgs e)
        {
            i -= 1;
            TBValue.Text = Convert.ToString(i);
        }

    }
}
