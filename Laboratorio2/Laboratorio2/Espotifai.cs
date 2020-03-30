using System;
using System.Collections.Generic;
using System.Linq;

namespace Laboratorio2
{
    public class Espotifai
    {
        private List<Cancion> Canciones;

        public Espotifai()
        {
            List<Cancion> list = new List<Cancion>();
            Canciones = list;

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
    }
}
