namespace CalculadoraMAUISeg.Mobile;

public partial class ContentPageDemo : ContentPage
{
	public ContentPageDemo()
	{
		InitializeComponent();
	}

    private void Button_Clicked(object sender, EventArgs e) //El metodo que recepciona el evento del botón
    {
		Navigation.PushAsync(new AnotherPage()); //Le decimos que quiero navegar a la pagina "anothe page"
    }
}