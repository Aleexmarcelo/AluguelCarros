using System;
using System.Globalization;
using System.IO;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;
using System.Text;

namespace AluguelCarros
{
    class Program
    {
        static void Main(string[] args)
        {
            //Primeira linha do console
            Console.WriteLine("Entre com os dados da locação: ");
            //Pedindo para digitar modelo do carro
            Console.WriteLine("Modelo: ");
            //Lê os dados digitados e salva em uma string
            string modelo = Console.ReadLine();
            //Pedindo para digitar a data de dentrada
            Console.WriteLine("Entrada (DD/MM/AAAA HH:MM): ");
            //Lê e salva os dados digitados.
            DateTime comeco = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);
            //Pedindo a data de saída.
            Console.WriteLine("Saída (DD/MM/AAAA HH:MM): ");
            //Lê a data de saída e salva em variável.
            DateTime saida = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);
            //Pedindo o valor por hora.
            Console.WriteLine("Entre com o preço por hora: ");
            //Lê e salva o preço por hora.
            double hora = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            //Pedindo o valor por dia.
            Console.WriteLine("Entre com o preço por dia: ");
            //Lê e salva o preço por dia.
            double dia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);          
            //Cria uma variável com informações de aluguel digitadas em uma pasta.
            AluguelCarro aluguelCarro = new AluguelCarro(comeco, saida, new Veiculo(modelo));
            //Cria uma variável com informações de serviços em uma pasta.
            ServicoLocacao servicoLocacao = new ServicoLocacao(hora, dia, new TaxaServicoBR());          
            //Calcula o método de fatura, usando os dados digitados anteriormente.
            servicoLocacao.ProcessamentoFatura(aluguelCarro);
            //Mostra a fatura
            Console.WriteLine("Fatura: ");
        }
    }
}
