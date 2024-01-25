using SviteriTS5.Views;

namespace SviteriTS5
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new SviteriTS5.Views.MainPage();
        }
    }
}