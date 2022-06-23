using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1.Personas
{
    class Alumno : Persona
    {
     
        public short Nota { get; set; }

        public Alumno(int cedula, string primerNombre, string segundoNombre, string primerApellido, string segundoApellido, int fechaNacimiento, string calle, int numero,
            string interseccion, string[] telefono, short nota) : base(cedula, primerNombre, segundoNombre,primerApellido,segundoApellido,fechaNacimiento,calle,numero,interseccion,telefono) {


            Nota = nota;

        } 




    }
}
