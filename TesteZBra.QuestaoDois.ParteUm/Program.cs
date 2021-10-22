using System;
using System.Linq;

namespace TesteZBra.QuestaoDois.ParteUm
{
    class Program
    {
        static void Main(string[] args)
        {
            var listaIDs = ListaID.IDs.Split('-').ToList();
            var quantidadeIdsLetrasDuplas = listaIDs.Count(id => id.GroupBy(g => g).Any(g => g.Count() == 2));
            var quantidadeIdsLetrasTriplas = listaIDs.Count(id => id.GroupBy(g => g).Any(g => g.Count() == 3));
            var somaVerificacao = quantidadeIdsLetrasDuplas * quantidadeIdsLetrasTriplas;

            Console.WriteLine($"A soma de verificação é: {somaVerificacao}");
            Console.ReadLine();
        }
    }
}
