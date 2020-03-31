using System;
using System.Collections.Generic;

namespace Laboratorio2
{
    public class Playlist
    {
        private string Nombre;
        private List<Cancion> Lista;



        public Playlist(string nombre, List<Cancion> lista)
        {
            Nombre = nombre;
            Lista = lista;
        }

        public string GetNombre() { return Nombre; }
    }
}
