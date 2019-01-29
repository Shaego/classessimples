using System;
using System.Collections.Generic;
using System.Text;

namespace Superheros
{
    class Candidat
    {
        private string surnom = "";
        private string nom = "";
        private string pouvoir = "";

        public void Afficher()
        {
            Console.WriteLine("Surnom : " + surnom);
            Console.WriteLine("Nom : " + nom);
            Console.WriteLine("Super-Pouvoir : " + pouvoir);
        }

        public void Initialiser(string _surnom, string _nom, string _pouvoir)
        {
            surnom = _surnom;
            nom = _nom;
            pouvoir = _pouvoir;
        }

        public string GetSurnom()
        {
            return surnom;
        }

        public void Accepter()
        {
            Console.WriteLine("Le candidat est accepté");
        }
        public void Refuser()
        {
            Console.WriteLine("Le candidat est refusé");
        }

        public bool EstSelectionne()
        {            
            Console.WriteLine("> "+surnom);
            return true;
        }
    }
}
