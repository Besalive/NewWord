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

namespace NewWord.View.Pages.ExcelPages.inPage
{
    /// <summary>
    /// Логика взаимодействия для AddPayment.xaml
    /// </summary>
    public partial class AddPayment : Page
    {
        public AddPayment()
        {
            InitializeComponent();
        }

        private void AddButtonClick(object sender, RoutedEventArgs e)
        {
            int count = Convert.ToInt32(CounterAdd.TBValue.Text);
        }
    }
}
