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
        ObservableCollection<Patient> list = new ObservableCollection<Patient>();
        PodkopaevPolyclinicEntities1 DB = new PodkopaevPolyclinicEntities1();

        public PatientListPage()
        {
            InitializeComponent();
            list = new ObservableCollection<Patient>(DB.Patients.ToList());
            patientsLV.ItemsSource = list;
        }
    }
}
