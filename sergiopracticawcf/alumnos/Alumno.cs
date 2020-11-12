using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace sergiopracticawcf.alumnos
{
    public class Alumno
    {
        int numeroControl;
        String nombreAlumno;
        String carreraAlumno;
        private List<Alumno> listaAlumnos;

        public Alumno()
        {
        }

        public Alumno(List<Alumno> listaAlumnos)
        {
            this.listaAlumnos = listaAlumnos;
        }

        public int NumeroControl {
            get { return numeroControl; }
            set { numeroControl = value; }
        }

        public String NombreAlumno {
            get { return nombreAlumno; }
            set { nombreAlumno = value; }
        }

        public String CarreraAlumno {
            get { return carreraAlumno; }
            set { carreraAlumno = value; }
        }

    }
}