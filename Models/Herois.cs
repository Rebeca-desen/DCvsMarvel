using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace projectC.Models
{
    public class HeroisDCMarvel {
        public int IdHeroisDCMarvel {get; set;}
        public string Name {get; set;}
        public string Company {get; set;}
        public int Weaknesses { get; set;}
        public int Powers {get; set;}
        public int Life {get; set;}

        public HeroisDCMarvel(int idHeroisDCMarvel, string name, string company, int weaknesses, int powers, int life){
            IdHeroisDCMarvel = idHeroisDCMarvel;
            Name = name;
            Company = company;
            Weaknesses = weaknesses;
            Powers = powers;
            Life = life;
        }
    }
}