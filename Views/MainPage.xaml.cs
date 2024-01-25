using SviteriTS5.Libs;
using SviteriTS5.Models;

namespace SviteriTS5.Views;

public partial class MainPage : ContentPage
{
    private readonly EstudianteDatabase _studentDataService = new EstudianteDatabase();

    public MainPage()
	{
        InitializeComponent();
        LoadStudents();
    }

   

    private async void LoadStudents()
    {
        StudentsListView.ItemsSource = await _studentDataService.GetStudentsAsync();
    }

    private void OnAddStudentClicked(object sender, EventArgs e)
    {
        App.Current.MainPage = new NavigationPage(new AddStudentPage());
    }

    private void OnDeleteStudentClicked(object sender, EventArgs e)
    {
        App.Current.MainPage = new NavigationPage(new DeleteStudentPage());
    }
}