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
using PodkopaevApp.Pages.Admin;

namespace PodkopaevApp.Pages
{
    /// <summary>
    /// Логика взаимодействия для PatientListPage.xaml
    /// </summary>
    public partial class PatientListPage : Page
    {
        ObservableCollection<PatientView> list = new ObservableCollection<PatientView>();
        PodkopaevPolyclinicEntities1 DB = new PodkopaevPolyclinicEntities1();

        public PatientListPage()
        {
            InitializeComponent();
            list = new ObservableCollection<PatientView>(DB.PatientViews.ToList());
            patientsLV.ItemsSource = list;
        }

		private void btnEditPatient_Click(object sender, RoutedEventArgs e)
		{
            if (patientsLV.SelectedValue != null)
            {
                var patient = (Patient)patientsLV.SelectedItem;
                AddEditPatientWindow patientWindow = new AddEditPatientWindow(patient.Id);
                patientWindow.ShowDialog();
            }
            else
            {
                MessageBox.Show("Выберите пациента");
            }
		}

		private void btnAddPatient_Click(object sender, RoutedEventArgs e)
		{
            AddEditPatientWindow patientWindow = new AddEditPatientWindow();
            patientWindow.ShowDialog();
        }
	}
}
