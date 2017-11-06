using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CapitalHumanoPHC.Entities
{
    public class Empleado
    {
        private string apellido { get; set; }
        private string nombre { get; set; }
        private string legajo { get; set; }
        private DateTime fechaIngreso { get; set; }
        private int dni { get; set; }
        private string cuil { get; set; }
        private DateTime fechaNacimiento { get; set; }
        private int esActivo { get; set; }
        private string telefono { get; set; }
        private string email { get; set; }
        private string domicilio { get; set; }
        private char sexo { get; set; }
    }
}