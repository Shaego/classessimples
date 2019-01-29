using System;
using System.Collections.Generic;
using System.Text;

namespace Hulk
{
    class Batiment
    {
        private string nom = "";
        private int nbPieces = 0;
        private int prixConstruction = 0;
        private int largeur = 0;
        private int longueur = 0;
        private int surface = 0;
        private TypeBatiment typeBatiment = new TypeBatiment();

        public void Initialiser(string _nom, int _nbPieces, int _prixConst, int _larg, int _long, TypeBatiment _type)
        {
            nom = _nom;
            nbPieces = _nbPieces;
            prixConstruction = _prixConst;
            largeur = _larg;
            longueur = _long;
            typeBatiment = _type;
        }

        public enum TypeBatiment
        {
            RESIDENTIEL,
            COMMERCIAL,
            INDUSTRIEL
        };

        public void Afficher()
        {
            Console.WriteLine(nom +" "+ typeBatiment +" --> "+ prixConstruction +"$ "+ CalculerSurface() +" m2");
        }

        public string GetNom()
        {
            return nom;
        }

        public int GetNbPieces()
        {
            return nbPieces;
        }

        public int GetPrixConstruction()
        {
            return prixConstruction;
        }

        public int GetLongueur()
        {
            return longueur;
        }

        public int GetLargeur()
        {
            return largeur;
        }

        public TypeBatiment GetBatiment()
        {
            return typeBatiment;
        }

        private int CalculerSurface()
        {   
            int surface = largeur * longueur;
            return surface;
        }
    }

}
