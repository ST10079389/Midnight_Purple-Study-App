using ClassLibrary;
using ST10079389_Kaushil_Dajee_PROG6212_Part_1.View_Model;
using System;
using System.Windows;
using System.Windows.Controls;
namespace ST10079389_Kaushil_Dajee_PROG6212_Part_1.Views
{
    public partial class Dates : Page
    {
        private SemesterDateViewModel SemesterDateViewModel;//takes these as constructors when navigating through the pages
        private ModuleInformationViewModel ModuleInformationViewModel;
        public Dates(SemesterDateViewModel semesterDateViewModel)
        {
            InitializeComponent();
            this.SemesterDateViewModel = semesterDateViewModel;
            ModuleInformationViewModel = new ModuleInformationViewModel();
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Class1 classLibrary = new Class1();
          try
            { //error handling to prevent the application from crashing             
                    DateTime semesterStart;
                    DateTime semesterEnd;
                    int numberOfWeeks;
                    if (int.TryParse(weeksBox.Text, out numberOfWeeks) && datePicker.SelectedDate.HasValue)
                    {
                    semesterStart = datePicker.SelectedDate.Value;//saves starting date
                    semesterEnd = classLibrary.EndSemester(semesterStart, numberOfWeeks);//calculates the ending date based on the number of weeks *7
                    ModuleInformationViewModel.numberOfWeeks = numberOfWeeks;
                    SemesterDateViewModel.saveDates(semesterStart, semesterEnd, numberOfWeeks);//saves it with just this method
                    var startValue = semesterStart.ToLongDateString();
                    var endValue = semesterEnd.ToLongDateString();
                    string message = $"Dates have been saved successfully, your semester begins " +
                        $"\non the {startValue} " +
                            $"and it will end on the {endValue}. \nGood luck for the Semester ;)";//notifies the user that the date has been saved
                    dateBox.Items.Add(message);
                    }
                    else
                    {
                        MessageBox.Show("Invalid format. Please try again!", "Error", MessageBoxButton.OK, MessageBoxImage.Error);//if the user has made any mistakes
                    }
            }
            catch (FormatException)
            {
                MessageBox.Show("Sorry, there was an error, Please enter the correct values", "Error 312", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            catch (System.NullReferenceException)
            {
                MessageBox.Show("Sorry, you did not input any values", "Error 313", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Sorry, there was an error, please try again", "Error 303" , MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
        private void weeksBox_GotFocus(object sender, RoutedEventArgs e)
        {
            weeksBox.Text = "";//when the user clicks the text box it will go blank
        }
    }
}
