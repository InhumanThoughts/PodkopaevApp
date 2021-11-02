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
using System.Windows.Shapes;
using PodkopaevApp.Helper;

namespace PodkopaevApp.Pages.Admin
{
	/// <summary>
	/// Interaction logic for AddEditPatientWindow.xaml
	/// </summary>
	public partial class AddEditPatientWindow : Window
	{
		PodkopaevPolyclinicEntities1 DB = new PodkopaevPolyclinicEntities1();
		bool isEditing = false;

		public AddEditPatientWindow()
		{
			InitializeComponent();
			var genders = DB.Genders.ToList();
			List<string> genderList = new List<string>();
			foreach (var g in genders)
				genderList.Add(g.Gender1);
			cmbGender.ItemsSource = genderList;
			cmbGender.SelectedIndex = 0;
		}

		public AddEditPatientWindow(int id) : this()
		{
			isEditing = true;
			Patient patient = DB.Patients.Where(e => e.Id == id).First();
			//cmbGender.SelectedIndex = patient.GenderId - 1;
			txbLastName.Text = patient.LastName;
			txbFirstName.Text = patient.FirstName;
			txbPatronymic.Text = patient.Patronimic;
			dpBirthday.SelectedDate = patient.BirthDay;
		}

		private void btnClose_Click(object sender, RoutedEventArgs e)
		{
			Close();
		}

		private void btnSave_Click(object sender, RoutedEventArgs e)
		{
			var res = MessageBox.Show("Вы хотите добавить пациента?", "Подтверждение", MessageBoxButton.YesNo);

			if (res != MessageBoxResult.Yes)
				return;

			Patient product = new Patient();
			if (!isEditing)
				product.Id = DB.Users.Count() + 1;
			product.LastName = txbLastName.Text;
			product.FirstName = txbFirstName.Text;
			product.Patronimic = txbPatronymic.Text;
			product.GenderId = cmbGender.SelectedIndex + 1;
			product.BirthDay = dpBirthday.SelectedDate;

			if (!isEditing)
			{
				DB.Patients.Add(product);
				DB.SaveChanges();
			}

			Close();
		}
	}
}
