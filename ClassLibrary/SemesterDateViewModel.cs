using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
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
