using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using sergiopracticawcf.alumnos;

namespace sergiopracticawcf.AltaAlumno
{
    public class AltaAlumnos
    {
        List<Alumno> listaAlumnos = new List<Alumno>();
        Alumno obj_alumno;
        Alumno buscar;

        public List<Alumno> obteneralumno(int NoControl, String nomAlumno, String carrAlumno) {
           
            obj_alumno = new Alumno();
            obj_alumno = new Alumno { NumeroControl=NoControl,NombreAlumno=nomAlumno,CarreraAlumno=carrAlumno};
            listaAlumnos.Add(obj_alumno);
            return listaAlumnos;
        }

        public String BuscarAlumno(int NoControl) {
            Alumno encontrado = new Alumno();

            foreach (Alumno element in listaAlumnos)
            {
                buscar = new Alumno(listaAlumnos);
                if (buscar.NumeroControl == NoControl) {
                    encontrado = new Alumno(listaAlumnos);   
                }
            }
            return encontrado.NombreAlumno;
        }
    }
}