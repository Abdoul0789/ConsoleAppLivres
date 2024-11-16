using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppLivres
{
    internal class Roman:Livre

    {
        public string  Genre { get; set; }

        public Roman(string titre, string auteur, int nbrsPages,string genre) : base(titre, auteur, nbrsPages)
        {
               
            Genre= genre;
            
        }
        public override void afficherDetails()
        {
            Console.WriteLine($"le Titre du livre est: {Titre}, l'Auteur est : {Auteur}, NbrsPages est de : {NbrsPages},le genre est:{Genre}");



        }
    }
}
