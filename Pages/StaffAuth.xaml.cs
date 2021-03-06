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
using PodkopaevApp.Helper;

namespace PodkopaevApp.Pages
{
    /// <summary>
    /// Логика взаимодействия для StaffAuth.xaml
    /// </summary>
    public partial class StaffAuth : Page
    {
        /// <summary>
        /// AAAAAAAA
        /// </summary>

        PodkopaevPolyclinicEntities1 DB = new PodkopaevPolyclinicEntities1();
        
        public StaffAuth()
        {
            InitializeComponent();
        }

        private void enterBtn_Click(object sender, RoutedEventArgs e)
        {
            User user = DB.Users.Where(u => u.login == loginTB.Text && u.password == passTB.Text).FirstOrDefault();
            if (user == null)
                return;

            switch(user.RoleId)
            {
                case 1:
                    NavigationService.Navigate(new AdminPage(user));
                    break;
                default:
                    MessageBox.Show("Эта роль не поддерживается");
                    break;
            }

        }

        private void backBtn_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new MainPage());
        }

        private void loginTB_GotFocus(object sender, RoutedEventArgs e)
        {
            if (loginTB.Text == "логин")
                loginTB.Text = "";
        }
        
        private void passTB_GotFocus(object sender, RoutedEventArgs e)
        {
            if (passTB.Text == "пароль")
                passTB.Text = "";
        }

        private void loginTB_LostFocus(object sender, RoutedEventArgs e)
        {
            if(loginTB.Text == "")
                loginTB.Text = "логин";
        }

        private void passTB_LostFocus(object sender, RoutedEventArgs e)
        {
            if (passTB.Text == "")
                passTB.Text = "пароль";
        }
    }
}
