using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using sergiopracticawcf.alumnos;

namespace sergiopracticawcf
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IService1" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IService1
    {

        [OperationContract]
        public List<Alumno> obteneralumno(int NoControl, String nomAlumno, String carrAlumno);
        [OperationContract]
        public String buscarAlumno(int NoControl);

        [OperationContract]
        public Peliculas agregar_pelicula();

        [OperationContract]
        public Peliculas consultar_pelicula(Peliculas peli);



    }


    
}
