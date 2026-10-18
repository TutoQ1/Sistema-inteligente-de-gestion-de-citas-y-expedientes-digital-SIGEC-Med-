using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Paciente:Persona
    {
        public int IdPaciente { get; set; }
        public int NumeroTelefonico { get; set; }
    }
}
