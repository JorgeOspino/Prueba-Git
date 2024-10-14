namespace MauiApp1;

public partial class Maestro : ContentPage
{
	public Maestro()
	{
		InitializeComponent();
	}
    private void GoToStackLayoutPage(object sender, EventArgs e)
    {
        NavigationToPage(new StackLayoutPage()); // Asegúrate de que StackLayoutPage exista
    }

    private void GoToGridLayoutPage(object sender, EventArgs e)
    {
        NavigationToPage(new GridLayoutPage()); // Asegúrate de que GridLayoutPage exista
    }

    private void GoToFlexLayoutPage(object sender, EventArgs e)
    {
        NavigationToPage(new FlexLayoutPage()); // Asegúrate de que FlexLayoutPage exista
    }
    private void NavigationToPage(ContentPage page)
    {

        App.flyoutPage.Detail.Navigation.PushAsync(page);
        App.flyoutPage.IsPresented = false;
    }
}