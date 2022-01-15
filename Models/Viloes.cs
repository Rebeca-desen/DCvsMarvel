using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace projectC.Models
{
    public class Viloes {
        public int IdViloes {get; set;}
        public string Name {get; set;}
        public string Company {get; set;}
        public int Weaknesses { get; set;}
        public int Powers {get; set;}
        public int Life {get; set;}

        public Viloes(int idViloes, string name, string company, int weaknesses, int powers, int life){
            IdViloes = idViloes;
            Name = name;
            Company = company;
            Weaknesses = weaknesses;
            Powers = powers;
            Life = life;
        }
    }
}