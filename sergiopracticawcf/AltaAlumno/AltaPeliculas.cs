using sergiopracticawcf.alumnos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace sergiopracticawcf.AltaAlumno
{
    public class AltaPeliculas
    {
        public Peliculas agregar_pelicula() {
            Peliculas peli = new Peliculas();
            peli.nombre_pelicula = "prueba 1";
            peli.id_peliculas = 1;
            peli.duracion_peliculas = "30 minutos";
            peli.genero_pelicula = "miedo, suspenso";
            return peli;
        }
        public Peliculas consultar_pelicula(Peliculas pelis) {
            return pelis;
            
        }

    }
}