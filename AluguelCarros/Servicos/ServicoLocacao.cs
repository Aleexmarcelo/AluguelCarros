using System;
using System.Collections.Generic;
using System.Text;

namespace AluguelCarros
{
    class ServicoLocacao
    {
        //Encapsulamento com get set
        public double PrecoPorHora { get; set; }
        //Encapsulamento com get set
        public double PrecoPorDia { get; set; }

        //Usando interface da taxa de serviço.
        ITaxaServico TaxaServico;
        //Construtor
        public ServicoLocacao(double precoPorHora, double precoPorDia, ITaxaServico taxaServico)
        {
            //Guardando variáveis para mostrar no console
            PrecoPorDia = precoPorDia;
            //Guardando variáveis para mostrar no console
            PrecoPorHora = precoPorHora;
            //Guardando variáveis para mostrar no console
            TaxaServico = taxaServico;
        }
        //Método
        public void ProcessamentoFatura(AluguelCarro aluguelCarro)
        {
            //Comparando datas e salvando em duracao
            TimeSpan duracao = aluguelCarro.Final.Subtract(aluguelCarro.Comeco);
            //Zera a variável
            double PagamentoBasico = 0.0;
            //Se duração passar de 12 horas...
            if (duracao.TotalHours <= 12.0)
            {
                //...Cobrar por hora.
                PagamentoBasico = PrecoPorHora * Math.Ceiling(duracao.TotalHours);
            }
            //Se não...
            else
            {
                //...Cobrar por dia.
                PagamentoBasico = PrecoPorDia * Math.Ceiling(duracao.TotalDays);
            }
            //Calculando as taxas de acordo com os dados
            double Taxa = TaxaServico.Taxa(PagamentoBasico);
            //Salva um objeto com valores na pasta
            aluguelCarro.Fatura = new Fatura(PagamentoBasico, Taxa);
        }

    }
}
