﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace Laboratorio2
{
    public class Espotifai
    {
        private List<Cancion> Canciones;
        private List<Playlist> Playlists;


        public Espotifai()
        {
            List<Cancion> list = new List<Cancion>();
            List<Playlist> playlists = new List<Playlist>();
            Canciones = list;
            Playlists = playlists;

        }

        public bool AgregarCancion(Cancion cancion)
        {
            if (Canciones.Count() == 0)
            {
                Canciones.Add(cancion);
                return true;
            }
            else
            {
                foreach (Cancion x in Canciones)
                {
                    if (x.Informacion() == cancion.Informacion())
                    {
                        return false;
                    }
                }
                Canciones.Add(cancion);
                return true;

            }




        }

        public void VerCanciones()
        {
            if (Canciones.Count() == 0)
            {
                Console.WriteLine("No hay canciones.");
            }
            foreach (Cancion item in Canciones)
            {
                Console.WriteLine(item.Informacion());
            }
        }

        public List<Cancion> CancionesPorCriterio(String criterio, String valor)
        {
            List<Cancion> busqueda = new List<Cancion> { };

            Console.WriteLine("Seleccione el criterio de busqueda:");

            Console.WriteLine("1 -> Nombre de la cancion\n2 -> Artista\n3 -> Album\n4 -> Genero");

            criterio = Console.ReadLine();
            int caso = 0;




            if (criterio != "1" && criterio != "2" && criterio != "3" && criterio != "4")
            {
                Console.WriteLine("Criterio invalido.");
            }

            else
            {

                if (criterio == "1") { criterio = "nombre de la cancion"; caso = 1; }
                else if (criterio == "2") { criterio = "artista"; caso = 2; }
                else if (criterio == "3") { criterio = "album"; caso = 3; }
                else if (criterio == "4") { criterio = "genero"; caso = 4; }

                Console.WriteLine("Escriba el {0} que quiere buscar", criterio);
                valor = Console.ReadLine();

                foreach (var item in Canciones)
                {
                    switch (caso)
                    {
                        case 1:
                            if (item.GetNombre() == valor) { busqueda.Add(item); }
                            break;
                        case 2:
                            if (item.GetArtista() == valor) { busqueda.Add(item); }
                            break;
                        case 3:
                            if (item.GetAlbum() == valor) { busqueda.Add(item); }
                            break;
                        case 4:
                            if (item.GetGenero() == valor) { busqueda.Add(item); }
                            break;
                    }
                }
                if (busqueda.Count() == 0) { Console.WriteLine("No se encontraron canciones con el valor solicitado."); }
            }
            return busqueda;
        }


        public bool GenerarPlaylist(string criterio, string valor, string nombrePlaylist)
        {
            Console.WriteLine("Ingrese el nombre de su playlist:");
            nombrePlaylist = Console.ReadLine();
            if (Playlists.Count() != 0)
            {
                foreach (Playlist item in Playlists)
                {
                    if (item.GetNombre() == nombrePlaylist)
                    {
                        Console.WriteLine("Ya existe una lista con ese nombre");
                        return false;
                    }
                }
            }
            List<Cancion> play = CancionesPorCriterio(criterio, valor);

            if (play.Count() == 0) { return false; }

            else
            {
                Playlist lista = new Playlist(nombrePlaylist, play);
                Playlists.Add(lista);
                Console.WriteLine("Playlist \"{0}\" creado exitosamente!", lista.GetNombre());
                foreach (Cancion c in play)
                {
                    Console.WriteLine(c.Informacion());
                }

                return true;
            }

        }

        public String VerMisPlaylists()
        {
            string mostrar = null;

            foreach (Playlist item in Playlists)
            {
                mostrar += item.GetNombre();
                mostrar += "\n\n";
                foreach (Cancion x in item.GetPlaylist())
                {
                    mostrar += x.Informacion();
                    mostrar += "\n\n";
                }
            }



            return mostrar;
        }
    }
}
