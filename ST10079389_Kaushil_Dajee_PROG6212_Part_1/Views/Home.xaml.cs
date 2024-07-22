using ClassLibrary;
using ST10079389_Kaushil_Dajee_PROG6212_Part_1.Constructors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Controls;
namespace ST10079389_Kaushil_Dajee_PROG6212_Part_1.Views
{
    public partial class Home : Page
    {
        //accepts a list as a parameter
        public Home(List<ModuleInformation> modules)
        {
            InitializeComponent();
            DisplayModules(modules);
        }
        public void DisplayModules(List<ModuleInformation> Module)
        {
            Class1 classLibrary = new Class1();
            try
            {
                moduleListBox.Items.Clear();
                if (Module.Count == 0)
                {
                    //displays message when the user first logs in
                    moduleListBox.Items.Add(classLibrary.DisplayMessage());
                }
                var sortModule = Module.OrderBy(x => x.Name).ToList();//using LINQ to sort the list out alphabetically
                foreach (var module in sortModule)
                {
                    string message = $"{module.Name} {module.Code} requires {module.numberOfCredits} credits with {module.classHours} hours of class per week" +
                                $" which requires you to study {module.selfStudyHoursWeek} hours every week.";
                    moduleListBox.Items.Add(message);//dispalys each module in a list box
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
    }
}
