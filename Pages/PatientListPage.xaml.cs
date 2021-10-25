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
using System.Collections.ObjectModel;

namespace PodkopaevApp.Pages
{
    /// <summary>
    /// Логика взаимодействия для PatientListPage.xaml
    /// </summary>
    public partial class PatientListPage : Page
    {
        ObservableCollection<User> list = new ObservableCollection<User>();
        PodkopaevPolyclinicEntities1 DB = new PodkopaevPolyclinicEntities1();

        public PatientListPage()
        {
            InitializeComponent();
            list = new ObservableCollection<User>(DB.User.Where(e => e.RoleId == 3).ToList());
            patientsLV.ItemsSource = list;
        }
    }
}
