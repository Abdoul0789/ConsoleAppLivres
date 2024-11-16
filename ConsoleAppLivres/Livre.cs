using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppLivres
{
    internal class Livre
    {
        public string Titre {  get; set; }
        public string Auteur { get; set; }
        public int NbrsPages { get; set; }

        public Livre ( string titre, string auteur,int nbrsPages) {
            
             Titre = titre;

             Auteur = auteur;

             NbrsPages = nbrsPages;
        }

        public virtual void afficherDetails () 
        {
            Console.WriteLine($"Titre : {Titre}, Auteur : {Auteur}, NbrsPages : {NbrsPages}");
        }


    }
}
