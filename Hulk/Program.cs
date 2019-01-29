using System;

namespace Hulk
{
    class Program
    {
        static void Main(string[] args)
        {
            Batiment[] tabBatimentRue1 = new Batiment[3];
            Batiment[] tabBatimentRue2 = new Batiment[2];

            Batiment tourStark = new Batiment();
            Batiment maisonPeterParker = new Batiment();
            Batiment labPym = new Batiment();
            Batiment stationPolice = new Batiment();
            Batiment museeMarvel = new Batiment();

            tourStark.Initialiser("tour Stark", 1000, 999999999, 50, 80, Batiment.TypeBatiment.INDUSTRIEL);
            tabBatimentRue1[0] = tourStark;
            maisonPeterParker.Initialiser("Maison Peter Parker", 6, 250000, 12,15, Batiment.TypeBatiment.RESIDENTIEL);
            tabBatimentRue1[1] = maisonPeterParker;
            labPym.Initialiser ("Labo Pym", 200, 777777, 30, 80, Batiment.TypeBatiment.INDUSTRIEL);
            tabBatimentRue1[2] = labPym;
            stationPolice.Initialiser("Station de Police", 15, 400000, 20, 40, Batiment.TypeBatiment.INDUSTRIEL);
            tabBatimentRue2[0] = stationPolice;
            museeMarvel.Initialiser("Musée Marvel", 20, 543210, 40, 60, Batiment.TypeBatiment.COMMERCIAL);
            tabBatimentRue2[1] = museeMarvel;
            AfficherRue1(tabBatimentRue1);
            Console.WriteLine("");
            AfficherRue2(tabBatimentRue2);

            Console.ReadKey();
        }
        
        static void AfficherRue1(Batiment[] rue)
        {            
            Console.WriteLine("Afficher rue methode #1");
            foreach (Batiment batiment in rue)
            {
                batiment.Afficher();
            }
        }

        static void AfficherRue2(Batiment[] rue)
        {
            Console.WriteLine("Afficher rue methode #1");
            foreach (Batiment batiment in rue)
            {
                Console.WriteLine(batiment.GetNom() + " (" + batiment.GetType() + ")");
            }
        }

    }
}
