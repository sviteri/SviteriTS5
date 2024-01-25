using SviteriTS5.Libs;

namespace SviteriTS5.Views;

public partial class DeleteStudentPage : ContentPage
{
    private readonly EstudianteDatabase _studentDataService = new EstudianteDatabase();
    public DeleteStudentPage()
	{
		InitializeComponent();
	}

    private async void OnDeleteClicked(object sender, EventArgs e)
    {
        if (int.TryParse(IdEntry.Text, out int studentId))
        {
            await _studentDataService.DeleteStudentAsync(studentId);
            App.Current.MainPage = new NavigationPage(new MainPage());
        }
        else
        {
            DisplayAlert("No Existe", "El ID Proporcionado no existe", "OK");
        }
    }
}