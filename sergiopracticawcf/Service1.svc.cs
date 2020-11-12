using sergiopracticawcf.AltaAlumno;
using sergiopracticawcf.alumnos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace sergiopracticawcf
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "Service1" en el código, en svc y en el archivo de configuración.
    // NOTE: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione Service1.svc o Service1.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class Service1 : IService1
    {

        AltaAlumnos alta = new AltaAlumnos();
        AltaPeliculas alta_peli = new AltaPeliculas();
        public Peliculas agregar_pelicula()
        {
            return alta_peli.agregar_pelicula();
        }

        public String buscarAlumno(int NoControl)
        {
            return alta.BuscarAlumno(NoControl);
        }

        public Peliculas consultar_pelicula(Peliculas peli)
        {
            return alta_peli.consultar_pelicula(peli);
        }

        List<Alumno> IService1.obteneralumno(int NoControl, string nomAlumno, string carrAlumno)
        {
            return alta.obteneralumno(NoControl, nomAlumno, carrAlumno);
        }
    }
}
