namespace CalculadoraMAUISeg.Mobile;

public partial class AnotherPage : ContentPage
{
	public AnotherPage()
	{
		InitializeComponent();
	}

    private void Button_Clicked(object sender, EventArgs e)
    {
		Navigation.PopAsync();//Cuando el psuh envío, cuando es pop retorno (y no tengo que adicionarle parametro de a cual pagina)
    }
}