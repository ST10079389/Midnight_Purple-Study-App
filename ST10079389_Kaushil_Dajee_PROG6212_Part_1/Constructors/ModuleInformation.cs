using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ST10079389_Kaushil_Dajee_PROG6212_Part_1.Constructors
{
    public class ModuleInformation
    {
        //saves the information about the module when the user decided to add a module
        public string Code { get; set; }
        public string Name { get; set; }
        public int numberOfCredits { get; set; }
        public int classHours { get; set; }
        public int selfStudyHoursWeek { get; set; }

        public ModuleInformation(string name, string code, int numberOfCredits, int classHours, int selfStudyHoursWeek)
        {
            Code = code;
            Name = name;
            this.numberOfCredits = numberOfCredits;
            this.classHours = classHours;
            this.selfStudyHoursWeek = selfStudyHoursWeek;
        }
    }
}
