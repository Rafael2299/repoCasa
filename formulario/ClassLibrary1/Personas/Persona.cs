using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1.Personas
{
    public abstract class Persona
    {
        private string Pnombre;
        private string Snombre;
        private string Papellido;
        private string Sapellido;
        private int Fecha;
        private string Calle;
        private int Numero;
        private string Interseccion;
        private string Telefono;

        public Persona(int cedula, string primerNombre, string segundoNombre, string primerApellido, string segundoApellido, int fechaNacimiento, string calle, int numero,
            string interseccion, string[] telefono) {

            Pnombre = primerNombre;
            Snombre = segundoNombre;
            Papellido = primerApellido;
            Sapellido = segundoApellido;
            Fecha = fechaNacimiento;
            Calle = calle;
            Numero = numero;
            Interseccion = interseccion;
            Telefono = telefono;
        }
        //
        public int Cedula { get; set; }

        public string primerNombre { get; set; }
        public string segundoNombre { get; set; } = String.Empty;

        public string primerApellido { get; set; }

        public string segundoApellido { get; set; } = String.Empty;

        public int fechaNacimiento { get; set; }

        //DIRECCION


        public string calle { get; set; }
        public int numero { get; set; }

        public int interseccion { get; set; }

        public string[] telefono { get; set; } 
    }
}
