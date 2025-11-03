using AtividadeAgenda12e13.Models;

namespace AtividadeAgenda12e13.Views;

public partial class ContratacaoHospedagem : ContentPage
{

    private App? appProperties;
    public ContratacaoHospedagem()
    {
        InitializeComponent();
        appProperties = (App?)Application.Current;
        pck_suite.ItemsSource = appProperties?.lista_quartos;
        pck_suite.SelectedIndex = 0;
        dtp_checkin.MinimumDate = DateTime.Now;
        dtp_checkin.MaximumDate = new DateTime(DateTime.Now.Year, DateTime.Now.Month + 1, DateTime.Now.Day);

        dtp_checkout.MinimumDate = DateTime.Now.AddDays(1);
        dtp_checkout.MaximumDate = DateTime.Now.AddMonths(6);
    }

    private async void OpenContractedHosting(object sender, EventArgs e)
    {
        double numberAdults = stp_adultos.Value;
        double numberChildren = stp_criancas.Value;
        Quarto selectedRoom = (Quarto)pck_suite.SelectedItem;
        DateTime checkInDate = dtp_checkin.Date;
        DateTime checkOutDate = dtp_checkout.Date;


        await Navigation.PushAsync(new Views.HospedagemContratada(numberAdults, numberChildren, selectedRoom, checkInDate, checkOutDate));
    }

    private void Dtp_checkin_DateSelected(object sender, DateChangedEventArgs e)
    {
        dtp_checkout.MinimumDate = e.NewDate.AddDays(1);
        dtp_checkout.MaximumDate = e.NewDate.AddMonths(6);
    }
}