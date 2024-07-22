using ST10079389_Kaushil_Dajee_PROG6212_Part_1.Constructors;
using ST10079389_Kaushil_Dajee_PROG6212_Part_1.View_Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Windows;
using System.Windows.Controls;
namespace ST10079389_Kaushil_Dajee_PROG6212_Part_1.Views
{
    public partial class Study : Page
    {
        private StudyRecordViewModel StudyRecordViewModel;
        private List<ModuleInformation> modules = new List<ModuleInformation>();//this takes access of the modules information passing information when callling this page
        public Study(StudyRecordViewModel StudyRecordViewModel, List<ModuleInformation> modules)
        {
            InitializeComponent();
            this.StudyRecordViewModel = StudyRecordViewModel;
            this.modules = modules;
            InitializeModuleNameComboBox();
        }

        private void InitializeModuleNameComboBox()
        {
            var sort = modules.OrderBy(m => m.Name);
            foreach (var module in modules)
            {
                moduleNameBox.Items.Add(module.Name);
            }
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            bool foundRecipe = false;//searches if the recipe is found
            try
            {
                List<DateTime> StudyDates = new List<DateTime>();
                string ModuleName;
                int numberOfCredits;
                int selfStudyHoursWeek;
                DateTime dateStudied = datePicker.SelectedDate.Value;
                string search = moduleNameBox.SelectedItem?.ToString();
                int hoursStudied = int.Parse(hoursStudiedBox.Text);
                if(hoursStudied > 24)
                {
                    MessageBox.Show("Error. Your hours studied exceeds one Full Day.", "Error 308", MessageBoxButton.OK, MessageBoxImage.Error);
                    return;
                }

                    var SearchList = modules.Where(x => x.Name.Equals(search)).ToList();//using LINQ to find that specific module
                    foreach (ModuleInformation module in SearchList)
                    {
                    //when it does it matches the information
                        ModuleName = module.Name;
                        numberOfCredits = module.numberOfCredits;
                        selfStudyHoursWeek = module.selfStudyHoursWeek;
                        StudyDates.Add(dateStudied);//saves the date they studied on
                        StudyRecordViewModel.AddRecord(StudyDates, hoursStudied, ModuleName, numberOfCredits, selfStudyHoursWeek);//saves the study session into the data
                        StudyRecord studyRecord = new StudyRecord(StudyDates, hoursStudied, ModuleName, numberOfCredits, selfStudyHoursWeek);
                        string message = $"You studied for {ModuleName} for {hoursStudied} hours.";
                        studyListBox.Items.Add(message);
                        //MessageBox.Show("Congratulations, You are One Step Closer to Passing", "Study Session Saved", MessageBoxButton.OK, MessageBoxImage.Information);
                        foundRecipe = true;
                    }
                
                if (!foundRecipe)
                {
                    MessageBox.Show($"Sorry there is no module with the name {search}. Please try again.", "Module Not Found", MessageBoxButton.OK, MessageBoxImage.Error);//if not found the recipe will show an error
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
            {//catches any errors
                MessageBox.Show($"An error occurred, please try again.", "Error 311", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            finally 
            {
                //eventually clears everything so the user can enter more information if needed
                 hoursStudiedBox.Clear();
                 datePicker.Text = "";
            }
        }

    }
}
