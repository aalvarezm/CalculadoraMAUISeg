

using CalculadoraMAUISeg.Mobile.MVVM.ViewModels;

namespace CalculadoraMAUISeg.Mobile.MVVM.View;

public partial class ViewCalculadora : ContentPage
{
	public ViewCalculadora()
	{
		InitializeComponent();
		BindingContext = new CalculatorViewModel();
	}
}