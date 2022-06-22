using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JogoRpg.src.entities
{
    public class Hero
    {

        public Hero(string Name, int Level, string HeroType) {
            this.Name = Name;
            this.Leve = Level;
            this.HeroType = HeroType;

        }

        public string Name;
        public int Level;
        public String HeroType;

        public override string ToString(){
            return this.Name = this.Level + this.HeroType;

        public string Attack(){

            return this.Name + "Atacou com sua faca!";
        }

        }
    }
}