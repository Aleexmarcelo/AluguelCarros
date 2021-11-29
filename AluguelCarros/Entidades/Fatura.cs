using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace AluguelCarros
{
    class Fatura
    {
        //Encapsulamento de variável com get set
        public double PagamentoBasico { get; set; }
        //Encapsulamento de variável com get set
        public double Taxa { get; set; }
        //Encapsulamento com variáveis
        public Fatura(double aluguel, double taxa)
        {
            //Alocando dados das variáveis enviadas
            PagamentoBasico = aluguel;
            //Alocando dados das variáveis enviadas
            Taxa = taxa;
        }
        //Método pagamento
        public double PagementoTotal
        {
            //Método pagamendo com taxa inclusa
            get { return PagamentoBasico + Taxa; }
        }
        //Transforma os dados digitados em string
        public override string ToString()
        {
            //Método retornando todos as informações em console
            return "Pagamento Básico: " + PagamentoBasico.ToString("F2", CultureInfo.InvariantCulture) + "\n Taxa: " + Taxa.ToString("F2", CultureInfo.InvariantCulture) + "\n Pagamento Total: " + PagementoTotal.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
