using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bootcamp.Models
{
    public class Pessoa
    {
        public string? Nome {get; set;}
        public int Idade { get; set; }

        public int Ação {get; set;}

        public void Apresentar()
        {
            Console.WriteLine($"Olá, me chamo {Nome}," +
            $"tenho {Idade} anos, e corro em média {Ação}Km por dia");
        }
    }
}