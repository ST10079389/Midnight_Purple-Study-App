using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ST10079389_Kaushil_Dajee_PROG6212_Part_1.Constructors
{
    public class StudyRecord
    {
        //constructor i use to help save information about a specific study session
        public StudyRecord(List<DateTime> studyDates, int hoursStudied, string moduleName, int numberOfCredits, int selfStudyHoursWeek)
        {
            StudyDates = studyDates;
            this.hoursStudied = hoursStudied;
            ModuleName = moduleName;
            this.numberOfCredits = numberOfCredits;
            this.selfStudyHoursWeek = selfStudyHoursWeek;
        }

        public List<DateTime> StudyDates { get; set; }
        public int hoursStudied { get; set; }
        public string ModuleName { get; set; }
        public int numberOfCredits { get; set; }
        public int selfStudyHoursWeek { get; set; }
    }
}
