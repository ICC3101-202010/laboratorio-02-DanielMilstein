using System;
namespace Laboratorio2
{
    public class Cancion
    {
        private string Nombre;
        private string Artista;
        private string Album;
        private string Genero;

        public string GetNombre() { return Nombre; }
        public string GetArtista() { return Artista; }
        public string GetAlbum() { return Album;  }
        public string GetGenero() { return Genero; }

        public Cancion(string nombre, string artista, string album, string genero)
        {
            Nombre = nombre;
            Artista = artista;
            Album = album;
            Genero = genero;
        }


        public string Informacion()
        {
            string info = string.Format("genero: {0}, artista: {1}, album: {2}, nombre: {3}", Genero, Artista, Album, Nombre);
            return info;
        }
    }
}
