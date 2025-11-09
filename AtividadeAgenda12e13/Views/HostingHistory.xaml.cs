using AtividadeAgenda12e13.Models;

namespace AtividadeAgenda12e13.Views;

public partial class HostingHistory : ContentPage
{
   public List<HostingData> History { get; }
    public HostingHistory()
	{
		InitializeComponent();
        History = new SaveData().HostingHistory;
        History.Reverse();
        BindingContext = this;


    }

    private async void OpenContractedHostingPage(object sender, TappedEventArgs e)
    {
        HostingData hostingDetails = (HostingData)((Frame)sender).BindingContext;
        await Navigation.PushAsync(new Views.HospedagemContratada(hostingDetails));
    }

   
}