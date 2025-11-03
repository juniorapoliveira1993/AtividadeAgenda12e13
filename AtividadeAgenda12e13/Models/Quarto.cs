using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtividadeAgenda12e13.Models
{
    public class Quarto(string descricao, double precoAdulto, double precoCrianca)


    {
        public string Descricao { get; set; } = descricao;

        public double PrecoAdulto { get; set; } = precoAdulto;

        public double PrecoCrianca { get; set; } = precoCrianca;

        public double CalcularValorTotal(double quantidadeAdultos, double quantidadeCriancas, int diarias)
        {
            return diarias * PrecoAdulto * quantidadeAdultos + diarias * PrecoCrianca * quantidadeCriancas;
        }

        
    }
}
