using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppLivres
{
    internal class Revue:Livre
    {
        public int Numero { get; set; }
        public int Annee { get; set; }

        public Revue(int numero, int annee, string titre, string auteur, int nbrsPages) : base(titre, auteur,nbrsPages)
        { 
          Numero=numero; 
          Annee=annee;   
        }
        public override void afficherDetails()
        {
            Console.WriteLine($"le Titre du livre est: {Titre}, l'Auteur est : {Auteur}, NbrsPages est de : {NbrsPages},le numero est:{Numero},l'annee est :{Annee}");
        }


    }
}
