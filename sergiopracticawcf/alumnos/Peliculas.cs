using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace sergiopracticawcf.alumnos
{
    public class Peliculas
    {
        
        int id;
        string Nombre;
        string Duracion;
        string Genero;
        
        public int id_peliculas
        {
            get { return id; }
            set { id = value; }
        }

        public string nombre_pelicula {
            get { return Nombre; }
            set { Nombre = value; }

        }
        public string duracion_peliculas {
            get { return Duracion; }
            set { Duracion = value; }
        }

        public string genero_pelicula {
            get { return Duracion; }
            set { Genero = value; }
        
        }

    }
}