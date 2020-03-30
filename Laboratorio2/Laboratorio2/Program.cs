using System;

namespace Laboratorio2
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            //Console.ReadLine();
            //Console.ReadKey();

            Cancion c1 = new Cancion("Seek & Destroy", "Metallica", "Kill 'Em All", "Thrash Metal");
            Cancion c2 = new Cancion("The Four Horsemen", "Metallica", "Kill 'Em All", "Thrash Metal");

            //Console.WriteLine(c1.Informacion());

            Espotifai spot = new Espotifai();

            spot.AgregarCancion(c1);
            spot.VerCanciones();
            Console.WriteLine("-------------");

            spot.AgregarCancion(c2);
            spot.AgregarCancion(c1);
            spot.VerCanciones();

        }
    }
}
