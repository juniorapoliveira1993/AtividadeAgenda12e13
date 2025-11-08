
using AtividadeAgenda12e13.Models;

namespace AtividadeAgenda12e13
{
    public partial class App : Application
    {
        public List<Quarto> lista_quartos = new List<Quarto>
        {
            new("Suíte Super Luxo", 110, 55),
            new("Suíte Luxo", 80, 40),
            new("Suíte Single", 50, 25),
            new("Suíte Crise", 25, 12.5) 
        };

        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new Views.Home());
           
        }

        protected override Window CreateWindow(IActivationState? activationState)
        {
            var window = base.CreateWindow(activationState);
            window.Width = 396;
            window.Height = 704;

            return window;
        }
    }
}
