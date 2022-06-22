using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JogoRpg.src.entities
{
    public class Cangaceiro : Hero
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
            return this.Name = " " + " " this.Level + this.HeroTypedotnet run;

        public string Attack(){

            return this.Name + "Atacou com sua magia!";
        }

         public string Attack(int Bonus){

            if(Bonus > 30) {

                 return this.Name + "Lançou uma magia super efeitva com  bônus de " + Bonus;
            } else
            {
                 return this.Name + "Lançou uma magia com força fraca com bônus de " + Bonus;
            }

           
        }

    }
  }
}