using System;
using System.Collections.Generic;
using System.Text;

namespace classes_simples
{
    class De
    {
        private int valeur;
        private int nbFaces;
        private Random rdm;

        public void Initialiser(int _nbFaces)
        {
            nbFaces = _nbFaces;
            rdm = new Random();
            LancerDe();
        }

        public void LancerDe()
        {
            valeur = ((int)rdm.Next(nbFaces))+ 1;
        }
        public int GetValeur()
        {
            return valeur;
        }
    }
}
