using ST10079389_Kaushil_Dajee_PROG6212_Part_1.Constructors;
using System;
using System.Collections.ObjectModel;
namespace ST10079389_Kaushil_Dajee_PROG6212_Part_1.View_Model
{
    public class SemesterDateViewModel
    {
        public ObservableCollection<SemesterDate> Semester { get; set; }//allows me to save the semesters dates
        public int numberOfWeeks { get; set; } //this gives me access later to get the number of weeks when calculating the self study hours per week
        public SemesterDateViewModel() 
        { 
            Semester = new ObservableCollection<SemesterDate>();
            numberOfWeeks = 0;
        }
        public void saveDates(DateTime semesterStart, DateTime semesterEnd, int numberOfWeeks)
        {
            //allows me to save the dates without too much effort
            SemesterDate newSemester = new SemesterDate(semesterStart, semesterEnd, numberOfWeeks);
            Semester.Add(newSemester);
            this.numberOfWeeks = numberOfWeeks;
        }
    }
}
