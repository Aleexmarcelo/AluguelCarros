using System;
using System.Collections.Generic;
using System.Text;

namespace AluguelCarros
{   
    //Interface da taxa de serviço.
    interface ITaxaServico
    {
        //Cria a variável Taxa
        double Taxa(double quantidade);
    }
}
