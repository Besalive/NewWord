using NewWord.Model;
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

namespace NewWord.View.Pages.ExcelPages
{
    /// <summary>
    /// Логика взаимодействия для ExcelPage.xaml
    /// </summary>
    public partial class ExcelPage : Page
    {
        Core cb = new Core();
        public ExcelPage()
        {
            InitializeComponent();
            DGExcel.ItemsSource = cb.context.Payment.ToList();
        }

        private void AddClick(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new inPage.AddPayment());
        }

        private void DelClick(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new inPage.DelPayment());
        }
    }
}
