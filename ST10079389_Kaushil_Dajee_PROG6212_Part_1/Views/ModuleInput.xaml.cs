using ST10079389_Kaushil_Dajee_PROG6212_Part_1.Constructors;
using ST10079389_Kaushil_Dajee_PROG6212_Part_1.View_Model;
using System;
using System.Windows;
using System.Windows.Controls;
using ClassLibrary;
namespace ST10079389_Kaushil_Dajee_PROG6212_Part_1.Views
{
    public partial class ModuleInput : Page
    {
        private ModuleInformationViewModel ModuleInformationViewModel;
        private SemesterDateViewModel SemesterDateViewModel;//uses this to access information when the user navigates to this page
        public ModuleInput(ModuleInformationViewModel moduleInformationViewModel, SemesterDateViewModel semesterDateViewModel)
        {
            InitializeComponent();
            this.ModuleInformationViewModel = moduleInformationViewModel;
            this.SemesterDateViewModel = semesterDateViewModel;
        }
        private void saveButton_Click(object sender, RoutedEventArgs e)
        {
            Class1 classLibrary = new Class1();   
            try
            {
                int numberOfWeeks = SemesterDateViewModel.numberOfWeeks;
                string Code = moduleCodeBox.Text;
                string Name = moduleBox.Text;
                int numberOfCredits = int.Parse(creditsBox.Text);
                int classHours = int.Parse(classHoursPerWeekBox.Text);
                int selfStudyHoursWeek = classLibrary.CalculateSelfStudy(numberOfCredits, numberOfWeeks, classHours);//uses class library to calculate the number of self study hours every week
                ModuleInformationViewModel.AddModule(Name, Code, numberOfCredits, classHours, selfStudyHoursWeek);//saves it
                string information = $"{Name} {Code} has {numberOfCredits} number of credits with {classHours}, the number of hours to study is {selfStudyHoursWeek} hours.";
                ModuleInformation module = new ModuleInformation(Name, Code, numberOfCredits, classHours, selfStudyHoursWeek);
                //MessageBox.Show("Your Module has been Saved!", "Module Saved", MessageBoxButton.OK, MessageBoxImage.Information);//notifies the user that module has been saved
                moduleListBox.Items.Add(information);//shows on a list box
            }
            catch (FormatException)
            {
                MessageBox.Show("Sorry, there was an error, Please enter the correct values", "Error 312", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            catch (System.NullReferenceException)
            {
                MessageBox.Show("Sorry, you did not input any values","Error 313", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            catch (Exception ex)
            {//catches any errors
                MessageBox.Show($"An error occurred, please try again.", "Error 311", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            finally
            {//clears everything from input boxes so the user can input the correct information
                moduleCodeBox.Clear();
                moduleBox.Clear();
                creditsBox.Clear();
                classHoursPerWeekBox.Clear();
            }
        }
    }
}
