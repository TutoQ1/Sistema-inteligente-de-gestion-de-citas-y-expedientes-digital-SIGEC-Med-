using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Profesional: Persona
    {
        public int IdProfesional { get; set; }
        public string Especialidad { get; set; }
        public string Estado { get; private set; }

        public string SetEstado(string estado) //capta del form el estado y lo devuelve para reflejar el cambio
        {
            Estado = estado;
            return Estado;
        }

        public override string ToString()
        {
            return $"{IdProfesional};{Especialidad};{Estado}";
        }
    }
}
