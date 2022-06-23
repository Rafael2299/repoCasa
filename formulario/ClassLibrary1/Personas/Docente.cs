using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1.Personas
{
    class Docente : Persona, IFuncionarios
    {



        public double Horasmensuales { get; set;}
        public double Preciohora { get; set; }

        public Docente(int cedula, string primerNombre, string segundoNombre, string primerApellido, string segundoApellido, int fechaNacimiento, string calle, int numero,
            string interseccion, string[] telefono, double horasmensuales, double preciohora) : base(cedula, primerNombre, segundoNombre, primerApellido, segundoApellido, fechaNacimiento, calle, numero, interseccion, telefono) {

            Horasmensuales = horasmensuales;
            Preciohora = preciohora;

        }
        public double CalcularSueldo() {
            return Horasmensuales * Preciohora;
        }
    }
}
