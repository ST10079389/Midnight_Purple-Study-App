using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class SemesterDate
    {
        //constructor i use to save the dates and number of weeks for the semester
        public SemesterDate(DateTime semesterStart, DateTime semesterEnd, int numberOfWeeks)
        {
            this.semesterStart = semesterStart;
            this.semesterEnd = semesterEnd;
            this.numberOfWeeks = numberOfWeeks;
        }

        public DateTime semesterStart { get; set; }
        public DateTime semesterEnd { get; set; }
        public int numberOfWeeks { get; set; }
    }
}
