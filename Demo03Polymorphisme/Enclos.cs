using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo03Polymorphisme
{
    internal class Enclos
    {
        private List<Dinausaur> DinausorList = new List<Dinausaur>(); 

        public string? nom { get; set; }   
        public  int taille { get; set; }
        public int NbDinoMax { get; set; }
        
        //Constructors
        public Enclos(List<Dinausaur> dinausorList, string? nom, int taille, int nbDinoMax)
        {
            DinausorList = dinausorList;
            this.nom = nom;
            this.taille = taille;
            NbDinoMax = nbDinoMax;
        }

        //Methods

    }
}
