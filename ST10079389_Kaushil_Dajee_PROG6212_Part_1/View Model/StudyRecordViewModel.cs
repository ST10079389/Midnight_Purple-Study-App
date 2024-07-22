using ST10079389_Kaushil_Dajee_PROG6212_Part_1.Constructors;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
namespace ST10079389_Kaushil_Dajee_PROG6212_Part_1.View_Model
{
    public class StudyRecordViewModel
    {
        public ObservableCollection<StudyRecord> Records { get; set; }//allows me to set the collection and call it when neccesary
        public StudyRecordViewModel() 
        { 
            Records = new ObservableCollection<StudyRecord>();
        }
        public void AddRecord(List<DateTime> studyDates, int hoursStudied, string moduleName, int numberOfCredits, int selfStudyHoursWeek)
        {
            //a method which saves the module without me having to do so much
            StudyRecord newRecord = new StudyRecord(studyDates, hoursStudied, moduleName, numberOfCredits, selfStudyHoursWeek);
            Records.Add(newRecord); 
        }
    }
}
