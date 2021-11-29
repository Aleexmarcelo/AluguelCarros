using System;
using System.Collections.Generic;
using System.Text;

namespace AluguelCarros
{
    class Veiculo
    {
        //Encapsulamento
        public string Modelo { get; set; }
        //Construtor
        public Veiculo(string modelo)
        {
            Modelo = modelo;
        }
    }
}
