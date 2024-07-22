using ClassLibrary;
using ST10079389_Kaushil_Dajee_PROG6212_Part_1.Constructors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
namespace ST10079389_Kaushil_Dajee_PROG6212_Part_1.Views
{
    public partial class Progress : Page
    {
        private List<ModuleInformation> modules = new List<ModuleInformation>();//this takes access of the modules information passing information when callling this page

        private List<StudyRecord> studyRecords = new List<StudyRecord>();//need the study record to be passed through to access the data 
        public Progress(List<StudyRecord> studyRecords, List<ModuleInformation> modules)
        {
            InitializeComponent();
            this.studyRecords = studyRecords;  
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
        private void searchButton_Click(object sender, RoutedEventArgs e)
        {
            Class1 class1 = new Class1();
            try
            {//making good use of error handling
                moduleListBox.Items.Clear();
                DateTime startDate = startDatePicker.SelectedDate.Value;
                DateTime endDate = startDate.AddDays(7);
                TimeSpan dateRange = endDate - startDate;
                if (dateRange.TotalDays > 7)
                {
                    MessageBox.Show("Invalid option please select a range between 7 days not greater then 7 days.");
                }
                else
                {
                    string moduleName = moduleNameBox.SelectedItem?.ToString();
                    int totalHoursStudied = CalculateHoursWithinDateRange(moduleName, startDate, endDate);//a method that calculates the total hours studied
                    //Using LINQ to manipulate the data to calculate how many hours are left to study
                    int hoursRemaining = studyRecords
                        .Where(studyRecords => studyRecords.ModuleName.Equals(moduleName))
                        .Select(studyRecords => studyRecords.selfStudyHoursWeek - totalHoursStudied)
                        .FirstOrDefault();

                    //if statements used depending on the situation
                    if (totalHoursStudied > 0)
                    {//displays information and how many hours is left
                        string message = $"Total hours studied for {moduleName} between {startDate.ToLongDateString()} and {endDate.ToLongDateString()} was {totalHoursStudied} hours, you currently have {hoursRemaining} hours left to study.";
                        moduleListBox.Items.Add(message);
                    }
                    else
                    {
                        //if module study session was not found
                        moduleListBox.Items.Add(class1.DisplayProgress(moduleName, startDate, endDate));
                    }
                }
            }
            catch (NullReferenceException)
            {
                //if there is an error a message will show in the list box
                string error = "Sorry there was an Error.";
                moduleListBox.Items.Add(error);
            }
            catch (Exception ex)
            {//if there is an error a message will show in the list box
                string error = "Sorry there was an Error.";
                moduleListBox.Items.Add(error);
            }
        }
        public int CalculateHoursWithinDateRange(string moduleName, DateTime startDate, DateTime endDate)
        {//method calculates total hours using LINQ to manipulate the list 
            var totalHoursStudied = studyRecords
                .Where(record => record.ModuleName.Equals(moduleName, StringComparison.OrdinalIgnoreCase))
                .Where(record => record.StudyDates.Any(date => date >= startDate && date <= endDate))
                .Sum(record => (int)record.hoursStudied); 
            //then returns the total hours studied
            return totalHoursStudied;
        }
    }
}
