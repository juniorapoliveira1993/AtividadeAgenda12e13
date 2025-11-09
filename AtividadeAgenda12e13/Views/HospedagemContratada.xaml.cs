using AtividadeAgenda12e13.Models;

namespace AtividadeAgenda12e13.Views;

public partial class HospedagemContratada : ContentPage
{
	public HospedagemContratada(Double numberAdults, double numberChildren, Quarto selectedRoom, DateTime checkInDate, DateTime checkOutDate)
	{
		InitializeComponent();
        lb_quarto.Text = selectedRoom.Descricao;

        string numberAdultsString = numberAdults + "";
        quantidade_adultos.Text = numberAdultsString;

        string numberChildrenString = numberChildren + "";
        quantidade_criancas.Text = numberChildrenString;

        string checkInDateFormated = checkInDate.ToShortDateString();
        lb_checkin.Text = checkInDateFormated;

        string checkOutDateFormated = checkOutDate.ToShortDateString();
        lb_checkout.Text = checkOutDateFormated;

        int stay = (checkOutDate - checkInDate).Days;
        string stayString = stay + "";
        lb_estadia.Text = stayString;

        string price = selectedRoom.CalcularValorTotal(numberAdults, numberChildren, stay).ToString("C");
        lb_valortotal.Text = price;
        new SaveData().Save(new HostingData(selectedRoom.Descricao, numberAdultsString, numberChildrenString, checkInDateFormated, checkOutDateFormated, stayString, price));

    }


    public HospedagemContratada(HostingData hostingDetails)
    {
        InitializeComponent();
        lb_quarto.Text = hostingDetails.Description;
        quantidade_adultos.Text = hostingDetails.Adults;
        quantidade_criancas.Text = hostingDetails.Childrens;
        lb_checkin.Text = hostingDetails.CheckinDate;
        lb_checkout.Text = hostingDetails.CheckoutDate;
        lb_estadia.Text = hostingDetails.Stay;
        lb_valortotal.Text = hostingDetails.Price;
    }

    private async void Confirm(object sender, EventArgs e)
    {
        await Navigation.PopAsync();
    }
}