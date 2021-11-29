using System;
using System.Collections.Generic;
using System.Text;

namespace AluguelCarros
{
    class TaxaServicoBR : ITaxaServico
    {
        //Cria a variável Taxa
        public double Taxa(double quantidade)
        {
            //Se acaso a quantidade(valor do dinheiro) for menor ou igual a 100 entre aqui.
            //Se o valor for menor ou igual que 100...
            if (quantidade <= 100)
            {
                //Cobrar taxa de de 0.20.
                return quantidade * 0.20;
            }
            //Se não for maior que 100...
            else
            {
                //Cobrar taxa de 0.15.
                return quantidade * 0.15;
            }
        }
    }
}
