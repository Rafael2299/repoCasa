using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1.Personas
{
    class Director : Persona, IFuncionarios
    {



        public double Sueldobase { get; set; }
        public int Antiguedad { get; set; }


        public Director(int cedula, string primerNombre, string segundoNombre, string primerApellido, string segundoApellido, int fechaNacimiento, string calle, int numero,
            string interseccion, string[] telefono, double sueldobase, int antiguedad) : base(cedula, primerNombre, segundoNombre, primerApellido, segundoApellido, fechaNacimiento, calle, numero, 
                interseccion, telefono) {

            Sueldobase = sueldobase;
            Antiguedad = antiguedad;
        }
        public double CalcularSueldo() {
            return Sueldobase * Antiguedad;
        }
    }
}
