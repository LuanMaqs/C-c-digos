using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bootcamp.Models
{
    public class Pessoa
    {
        public string Nome {get; set;}
        public int Idade { get; set; }

        public int Ação {get; set;}

        public string Nome1 {get; set;}

        public int Idade2 { get; set; }

        public string Ação2 {get; set;}

        public void Apresentar()
        {
            Console.WriteLine($"Olá, me chamo {Nome}," +
            $"tenho {Idade} anos, e corro em média {Ação}Km por dia!" +
            $"E voçê, qual seu nome? Quantos anos voçê tem? E" +
            $" Qual esporte pratica? Eu me chamo {Nome1}, tenho {Idade2} anos," +
             $"e pratico {Ação2} nas horas vagas");
        }
    }
}