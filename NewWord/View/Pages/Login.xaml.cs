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

namespace NewWord.View.Pages
{
    /// <summary>
    /// Логика взаимодействия для Login.xaml
    /// </summary>
    public partial class Login : Page
    {
        Core cb = new Core();
        public Login()
        {
            InitializeComponent();
            CBLogin.ItemsSource = cb.context.Users.ToList();
            CBLogin.SelectedValuePath = "id_user";
            CBLogin.DisplayMemberPath = "last_name";
        }

        private void LoginClick(object sender, RoutedEventArgs e)
        {
            int id = Convert.ToInt32(CBLogin.SelectedValue);
            string passwordInput = TBLogin.Text;
            if (cb.context.Users.Where(x => x.id_user == id && x.password == passwordInput).Count() == 1)
            {
                this.NavigationService.Navigate(new Menu());
            }
        }
    }
}
