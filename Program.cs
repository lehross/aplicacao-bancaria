using System;

namespace AplicacaoBancaria
{
    class Program
    {
        static void Main(string[] args)
        {
            Conta minhaConta = new Conta(TipoConta.PessoaFisica, 0, 0, "Letícia");

            Console.WriteLine(minhaConta.ToString());
        }
    }
}
