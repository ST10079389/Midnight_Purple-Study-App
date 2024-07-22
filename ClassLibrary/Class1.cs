using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Class1
    {
        public DateTime EndSemester(DateTime semesterStart, int numberOfWeeks)
        {
            DateTime semesterEnd = semesterStart.AddDays(7 * numberOfWeeks);
            return semesterEnd;
        }
        public int CalculateSelfStudy(int numberOfCredits, int numberOfWeeks, int classHours)
        {
            int selfStudyHoursWeek = ((numberOfCredits * 10) / numberOfWeeks) - classHours;
            return selfStudyHoursWeek;
        }
        public string DisplayMessage()
        {
            string message = "Welcome To Midnight Purple. Please enter the Date and Modules.";
            return message;
        }
        public string DisplayProgress(string moduleName, DateTime startDate, DateTime endDate)
        {
            string message = $"No study records found for {moduleName} between {startDate.ToLongDateString()} and {endDate.ToLongDateString()}";
            return message;
        }
    }
}
