using ST10079389_Kaushil_Dajee_PROG6212_Part_1.Constructors;
using System.Collections.ObjectModel;
namespace ST10079389_Kaushil_Dajee_PROG6212_Part_1.View_Model
{
    public class ModuleInformationViewModel
    {
        public ObservableCollection<ModuleInformation> ModuleInformation { get; set; }//allows me to easily access the data when i navigate through pages
        public int numberOfWeeks { get; set; }
        public string ModuleName { get; set; }
        public int numberOfCredits { get; set; }
        public int selfStudyHoursWeek { get; set; }
        public ModuleInformationViewModel()
        { 
            ModuleInformation = new ObservableCollection<ModuleInformation>();
            numberOfWeeks = 0;
            ModuleName = "";
            numberOfCredits = 0;
            selfStudyHoursWeek = 0;

        }
        public void AddModule(string name, string code, int numberOfCredits, int classHours, int selfStudyHoursWeek)
        {
            //saves the module with minimal effort 
            ModuleInformation newModule = new ModuleInformation(name, code, numberOfCredits, classHours, selfStudyHoursWeek);
            ModuleInformation.Add(newModule);
            this.ModuleName = name;
            this.numberOfCredits = numberOfCredits;
            this.selfStudyHoursWeek = selfStudyHoursWeek;
        }
    }
}
