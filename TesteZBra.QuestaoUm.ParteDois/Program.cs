using System;
using System.Collections.Generic;

namespace TesteZBra.QuestaoUm.ParteDois
{
    class Program
    {
        static void Main(string[] args)
        {
            var minSenha = 184759;
            var maxSenha = 856920;
            var senhasValidas = new List<Senha>();

            for (int i = minSenha; i <= maxSenha; i++)
            {
                var senha = new Senha(i.ToString());
                if (senha.ValidaRegraAdjacentesIguais && senha.ValidaRegraValoresCrescentes)
                {
                    senhasValidas.Add(senha);
                    Console.WriteLine($"Senha válida: {i}");
                }
            }

            Console.WriteLine($"Combinações possíveis: {senhasValidas.Count}");
        }
    }

    public class Senha
    {
        public Senha(string senha)
        {
            D1 = Convert.ToInt32(senha.Substring(0, 1));
            D2 = Convert.ToInt32(senha.Substring(1, 1));
            D3 = Convert.ToInt32(senha.Substring(2, 1));
            D4 = Convert.ToInt32(senha.Substring(3, 1));
            D5 = Convert.ToInt32(senha.Substring(4, 1));
            D6 = Convert.ToInt32(senha.Substring(5, 1));
        }

        public int D1 { get; set; }
        public int D2 { get; set; }
        public int D3 { get; set; }
        public int D4 { get; set; }
        public int D5 { get; set; }
        public int D6 { get; set; }

        public bool ValidaRegraAdjacentesIguais => 
            (D1 == D2 && D2 != D3 && D3 == D4)
            || (D1 == D2 && D2 != D4 && D4 == D5)
            || (D1 == D2 && D2 != D5 && D5 == D6)
            || (D2 == D3 && D3 != D4 && D4 == D5)
            || (D2 == D3 && D3 != D5 && D5 == D6)
            || (D3 == D4 && D4 != D5 && D5 == D6);

        public bool ValidaRegraValoresCrescentes => (D2 >= D1 && D3 >= D2 && D4 >= D3 && D5 >= D4 && D6 >= D5);
    }
}
