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

    public partial class AdminPage : Page
    {
        public AdminPage(User user)
        {
            InitializeComponent();
            staffName.Text = user.FirstName;
        }

        private void backBtn_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new MainPage());
        }

        private void doctorsBtn_Click(object sender, RoutedEventArgs e)
        {
            staffFrame.Navigate(new DoctorListPage());
        }

        private void patientsBtn_Click(object sender, RoutedEventArgs e)
        {
            staffFrame.Navigate(new PatientListPage());
        }
    }
}
