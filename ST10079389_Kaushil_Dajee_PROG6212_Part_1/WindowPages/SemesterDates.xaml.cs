using ST10079389_Kaushil_Dajee_PROG6212_Part_1.View_Model;
using ST10079389_Kaushil_Dajee_PROG6212_Part_1.Views;
using System;
using System.Linq;
using System.Windows;
using System.Windows.Input;

namespace ST10079389_Kaushil_Dajee_PROG6212_Part_1.WindowPages
{
    /// <summary>
    /// Interaction logic for SemesterDates.xaml
    /// </summary>
    public partial class SemesterDates : Window
    {
        //gives access to the information that is stored in memory
        private ModuleInformationViewModel moduleInformationViewModel;
        private SemesterDateViewModel semesterDateViewModel;
        private StudyRecordViewModel studyRecordViewModel;
        public SemesterDates()
        {
            InitializeComponent();
            moduleInformationViewModel = new ModuleInformationViewModel();
            semesterDateViewModel = new SemesterDateViewModel();
            studyRecordViewModel = new StudyRecordViewModel();
            Preload();//already loads information based on where the user is in the application
        }
        private void NavigateToAddModule()
        {
            //allows you to go to add module but only if yu have entered a the beginning of the Semesters Date
             if (semesterDateViewModel.Semester.Count > 0)
            {
                ModuleInput addModule = new ModuleInput(moduleInformationViewModel, semesterDateViewModel);
                Container.Navigate(addModule);//naviagtes to that page
            }
            else
            {
                MessageBox.Show("Invalid, please enter the Semesters Date before the Module", "Error 304", MessageBoxButton.OK ,MessageBoxImage.Warning);
            }
        }
        private void NavigateToDates()
        {
            //allows you to add the semesters dates but only once because it works based on each semester
            if (semesterDateViewModel.Semester.Count.Equals(1))
            {
                MessageBox.Show("Sorry you have already saved the Semesters Date. Please Restart the Application if you want to change the Semesters Date.", "Error 305", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
            else
            {
                Dates saveDate = new Dates(semesterDateViewModel);//naviagates them to save the dates for the semester
                Container.Navigate(saveDate);
            }
        }
        private void NavigateToStudy()
        {
            //takes you to the study page
           Study study = new Study(studyRecordViewModel, moduleInformationViewModel.ModuleInformation.ToList());//accepts the two variables as parameters which will be used to manipulate the data
           Container.Navigate(study);
        }
        private void NavigateToHome()
        {     
            //takes you to the home page 
            Home home = new Home(moduleInformationViewModel.ModuleInformation.ToList());//accepts the observable collection but as a list as a parameter so i can manipulate the data
            Container.NavigationService.Navigate(home);
        }
        private void NavigateToProgress()
        {
            //takes you to the progress page
            Progress progress = new Progress(studyRecordViewModel.Records.ToList(), moduleInformationViewModel.ModuleInformation.ToList());//accepts the observable collection as a list to the progress page but only as a parameter
            Container.Navigate(progress);
        }

        private void Border_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
            {
                this.DragMove();
            }
        }
        private void Log_Click(object sender, RoutedEventArgs e)
        {
            //if the user wants to close the application
            MessageBoxResult result = MessageBox.Show("Are you sure you want to close The App?", "Log Out", MessageBoxButton.YesNo,
                    MessageBoxImage.Question);//uses a question logo in message box
            if (result == MessageBoxResult.Yes)
            {
                try
                {
                    this.Close();
                }
                catch (Exception)
                {
                    MessageBox.Show("Sorry, could not close the app.", "Result");
                }
            }
            else
            {
                MessageBox.Show("Logging out cancelled.", "Log Out");
            }
        }
        private void Home_Click_1(object sender, RoutedEventArgs e)
        {
            NavigateToHome();  //alows me to navigate by calling that method     
        }

        private void moduleClick(object sender, RoutedEventArgs e)
        {
            NavigateToAddModule();  //alows me to navigate by calling that method     
        }

        private void Study_Click(object sender, RoutedEventArgs e)
        {
            NavigateToStudy();  //alows me to navigate by calling that method     
        }

        private void Progress_Click(object sender, RoutedEventArgs e)
        {
            NavigateToProgress();  //alows me to navigate by calling that method     
        }
        private void Preload()
        {
            NavigateToHome();  //already takes you to the home page when the application starts  
        }

        private void date_Click(object sender, RoutedEventArgs e)
        {
            NavigateToDates();  //alows me to navigate by calling that method     
        }
    }
}
/*Code Attribution:
https://youtu.be/gSfMNjWNoX0?si=7Pevxroht_t5HYdB from YouTube Tim Correy,
https://youtube.com/@IAmTimCorey?si=ZaKs0NjDFPScpkCu

https://youtu.be/C6LV_xMGdKc?si=fyx1rUue46c7dk3O from YouTube Tim Correy,
https://youtube.com/@IAmTimCorey?si=ZaKs0NjDFPScpkCu

https://youtu.be/yClSNQdVD7g?si=-z-YVKsfWG1zYQaN from YouTube Tim Correy,
https://youtube.com/@IAmTimCorey?si=ZaKs0NjDFPScpkCu

https://youtu.be/PsqcLpDq9Vk?si=WxVm6G0vorol_gZf from YouTube C# WPF UI Academy,
https://youtube.com/@WpfUI?si=6WJekHnqsb3IITeW

https://learn.microsoft.com/en-us/dotnet/desktop/wpf/windows/how-to-open-message-box?view=netdesktop-7.0 from Microsoft,
https://www.microsoft.com/en-za/

https://learn.microsoft.com/en-us/dotnet/core/tutorials/library-with-visual-studio?pivots=dotnet-7-0 from Microsoft,
https://www.microsoft.com/en-za/

https://youtu.be/U2ZvZwDZmJU?si=HGHUgUdIetxC5WI9 from YouTube AngelSix,
https://youtube.com/@AngelSix?si=Mml76Gbg_EON6xge

https://stackoverflow.com/questions/4279185/what-is-the-use-of-observablecollection-in-net from Stack OverFlow, Craig Suchanec,
https://stackoverflow.com/users/341209/craig-suchanec

https://www.geeksforgeeks.org/linq-how-to-find-the-sum-of-the-given-sequence/ from GeeksForGeeks, ankita_saini
https://auth.geeksforgeeks.org/user/ankita_saini/articles?utm_source=geeksforgeeks&utm_medium=article_author&utm_campaign=auth_user

 */
