using SviteriTS5.Libs;
using SviteriTS5.Models;

namespace SviteriTS5.Views;

public partial class AddStudentPage : ContentPage
{
    private readonly EstudianteDatabase _studentDataService = new EstudianteDatabase();
    public AddStudentPage()
	{
		InitializeComponent();
	}

    private async void OnSaveClicked(object sender, EventArgs e)
    {
        var lsStudents = await _studentDataService.GetStudentsAsync();
        var last  = lsStudents.LastOrDefault();
        var student = new Estudiante
        {
            Id= last!= null ? last.Id+1 : 1,
            Codigo = CodigoEntry.Text,
            Nombres = NombresEntry.Text,
            Carrera = CarreraEntry.Text
        };

        await _studentDataService.AddStudentAsync(student);
        App.Current.MainPage = new NavigationPage(new MainPage());
    }
}