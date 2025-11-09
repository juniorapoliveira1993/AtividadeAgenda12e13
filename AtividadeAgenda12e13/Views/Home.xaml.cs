namespace AtividadeAgenda12e13.Views;

public partial class Home : ContentPage
{
	public Home()
	{
		InitializeComponent();
	}

    private async void OpenHiringPage(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new Views.ContratacaoHospedagem());
    }

    private async void OpenAboutPage(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new Views.Sobre());
    }

    private async void OpenHostingHistory(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new Views.HostingHistory());
    }
}