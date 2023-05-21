using CalculadoraMAUISeg.Mobile.MVVM.View;

namespace CalculadoraMAUISeg.Mobile
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            //var navPage = new NavigationPage(new ContentPageDemo());//Para decirle al proyecto, por cuál pagina debe de iniciar
            //navPage.BarBackgroundColor = Colors.Chocolate;
            //navPage.BarTextColor = Colors.White;
            //MainPage = navPage;

            MainPage = new NavigationPage(new ViewCalculadora());       

             
        }
    }
}