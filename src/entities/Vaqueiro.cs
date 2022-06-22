using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JogoRpg.src.entities
{
    public class Vaqueiro : Hero
    {
        public Vaqueiro(string Name, int Level, string HeroType) {
            this.Name = Name;
            this.Leve = Level;
            this.HeroType = HeroType;

        }
    }
}