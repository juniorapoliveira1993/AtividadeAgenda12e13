using AtividadeAgenda12e13.Models;

namespace AtividadeAgenda12e13.Views;

public partial class HospedagemContratada : ContentPage
{
	public HospedagemContratada(Double numberAdults, double numberChildren, Quarto selectedRoom, DateTime checkInDate, DateTime checkOutDate)
	{
		InitializeComponent();
        lb_quarto.Text = selectedRoom.Descricao;
        quantidade_adultos.Text = numberAdults + "";
        quantidade_criancas.Text = numberChildren + "";
        lb_checkin.Text = checkInDate.ToShortDateString();
        lb_checkout.Text = checkOutDate.ToShortDateString();

        int diarias = (checkOutDate - checkInDate).Days;
        lb_estadia.Text = diarias + "";
        lb_valortotal.Text = selectedRoom.CalcularValorTotal(numberAdults, numberChildren, diarias).ToString("C");

    }

    private async void Back(object sender, EventArgs e)
    {
        await Navigation.PopAsync();
    }
}