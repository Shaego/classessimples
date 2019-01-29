using System;
namespace classes_simples
{
    class Program
    {
        static void Main(string[] args)
        {
            PremierJet();
            SecondJet();
            TroisiemeJet();
            QuatriemeJet();
            CinquiemeJet();
            Console.ReadKey();
        }
        public static void PremierJet()
        {
            int resultat =  0;

            De de1 = new De();
            de1.Initialiser(4);
            de1.LancerDe();
            de1.GetValeur();
            resultat += de1.GetValeur();

            de1.LancerDe();
            de1.GetValeur();
            resultat += de1.GetValeur()+4;
            Console.WriteLine("1. Le lancer 2D4 est de "+resultat);
            
        }
        public static void SecondJet()
        {            
            int nbLancer = 0;
            De de1 = new De();

            de1.Initialiser(6);
            do            {
                int resultat = 0;
                de1.LancerDe();
                resultat += de1.GetValeur();
                de1.LancerDe();
                resultat += de1.GetValeur();
                de1.LancerDe();
                resultat += de1.GetValeur();
                nbLancer++;
                Console.WriteLine("2. Le lancer 3D6, est de " + resultat);
            } while (nbLancer <= 6);

        }
        public static void TroisiemeJet()
        {
            int resultat = 0;
            int forceLancer = 0;
            Random force = new Random();
            forceLancer = force.Next(1, 9);

            De de1 = new De();
            de1.Initialiser(8);
            de1.LancerDe();
            de1.GetValeur();
            resultat += de1.GetValeur() + forceLancer;
            
            Console.WriteLine("3. Le lancer du dé de 1D8 est de " +resultat +" avec " + forceLancer + " de force");
        }
        public static void QuatriemeJet()
        {
            int nb1 = 0;
            Random nbr1 = new Random();
            
            int nb2 = 0;
            Random nbr2 = new Random();
            

            for (int i = 0; i < 2; i++)
            {               

                nb1 = nbr1.Next(0, 1);
                nb2 = nbr2.Next(0, 9);
                Console.WriteLine("4. Le lancer 2D10 est de " + nb1 + nb2);
            }
            De de1 = new De();
            de1.Initialiser(10);
            de1.LancerDe();
            de1.GetValeur();            

            
        }
        public static void CinquiemeJet()
        {
            int resultat = 0;
            int nbLancer = 0;
            De de1 = new De();

            de1.Initialiser(20);
            do
            {                
                de1.LancerDe();
                resultat = de1.GetValeur();
                nbLancer++;                
            } while (resultat != 20);
            Console.WriteLine("5. Le lancer D20 est de " + resultat + " et le dé a été lancé " + nbLancer + " fois");
        }
    }
}
