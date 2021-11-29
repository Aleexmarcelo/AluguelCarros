using System;
using System.Collections.Generic;
using System.Text;

namespace AluguelCarros
{
    class AluguelCarro
    {
        //Encapsulamento de variável
        public DateTime Comeco { get; set; }
        //Encapsulamento de variável com DateTime
        public DateTime Final { get; set; }
        //Encapsulamento de variável
        public Veiculo Veiculo { get; private set; }
        //Encapsulamento de variável
        public Fatura Fatura { get; set; }

        //Construtores
        public AluguelCarro(DateTime comeco, DateTime final, Veiculo veiculo)
        {
            //Guardando variáveis para mostrar no console
            Comeco = comeco;
            //Guardando variáveis para mostrar no console
            Final = final;
            //Guardando variáveis para mostrar no console
            Veiculo = veiculo;
            //Em caso de erro, fatura está fazia
            Fatura = null;
        }
    }
}
