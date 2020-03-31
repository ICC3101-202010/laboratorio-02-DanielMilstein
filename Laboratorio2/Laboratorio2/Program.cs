using System;

namespace Laboratorio2
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int x = 0;
            Console.WriteLine("Bienvenido a Espotifai");
            Espotifai spot = new Espotifai();
            Cancion c = new Cancion("a", "b", "c", "d");
            while (x == 0)
            {
                Console.WriteLine("Menu:");
                Console.WriteLine("Presiona 1 para agregar una cancion.");
                Console.WriteLine("Presiona 2 para ver tus canciones.");
                Console.WriteLine("Presiona 3 para ver canciones por criterio.");
                Console.WriteLine("Presiona 4 para crear un playlist.");
                Console.WriteLine("Presiona 5 para ver tus playlists.");
                Console.WriteLine("Presiona 0 para salir del programa.");
                string input = Console.ReadLine();
                if (input == "0") { x = 1; }

                else if (input == "1")
                {
                    Console.WriteLine("Ok, vamos a agregar una cancion\nIngresa el nombre de la cancion:");
                    string nombre = Console.ReadLine();
                    Console.WriteLine("Ahora ingresa el artista:");
                    string artista = Console.ReadLine();
                    Console.WriteLine("El nombre del Album:");
                    string album = Console.ReadLine();
                    Console.WriteLine("Y por ultimo el genero:");
                    string genero = Console.ReadLine();

                    Cancion c1 = new Cancion(nombre, artista, album, genero);
                    bool add = spot.AgregarCancion(c1);
                    if (add == true) { Console.WriteLine("Cancion agregada con exito!"); }
                    else { Console.WriteLine("Esta cancion ya existe."); }
                }

                else if (input == "2")
                {
                    spot.VerCanciones();
                }

                else if (input == "3")
                {
                    string criterio = null;
                    string val = null;

                    foreach (var item in spot.CancionesPorCriterio(criterio, val))
                    {
                        Console.WriteLine(item.Informacion());
                    }
                    
                }
                else if (input == "4")
                {
                    string criterio = null;
                    string valor = null;
                    string nombrePlay = null;

                    spot.GenerarPlaylist(criterio, valor, nombrePlay);
                }

                else { Console.WriteLine("Comando invalido."); }





            }


        }
    }
}


//Console.ReadLine();
//Console.ReadKey();

//Cancion c1 = new Cancion("Seek & Destroy", "Metallica", "Kill 'Em All", "Thrash Metal");
//Cancion c2 = new Cancion("The Four Horsemen", "Metallica", "Kill 'Em All", "Thrash Metal");

//Console.WriteLine(c1.Informacion());

//

//spot.AgregarCancion(c1);
//            spot.VerCanciones();
//            Console.WriteLine("-------------");
//
//            spot.AgregarCancion(c2);
//            spot.AgregarCancion(c1);
//            spot.VerCanciones();
