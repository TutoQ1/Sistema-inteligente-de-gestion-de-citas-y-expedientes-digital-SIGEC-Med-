using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Cita
    {
        public int IdCita { get; set; }
        public string TipoDeCita { get; set; }
        public Paciente Paciente { get; set; }
        public Profesional Profesional { get; set; }
        public DateTime FechaHoraDeCita { get; set; }
        public DateTime FechaHoraFinalDeCita { get; private set; }
        public string Estado { get; private set; }
        public string PrioridadValidada { get; private set; }


        //con timeSpan podemos ver la diferencia de tiempo
        public TimeSpan SetFechaHoraFinalDeCita (DateTime fechaInicial)
        {
            if(fechaInicial == null)
            {
                throw new Exception("ERROR NO HAY FECHA CONTENIDA");
            }
            TimeSpan final  = FechaHoraFinalDeCita - DateTime.Now;
            return final; //recibe la fecha del form y la resta con la instancia de tiempo actual
        }

        public string SetPrioridadValida(bool verificador) //recibe un bool directo del form de un check
        {
            if(verificador)
            {
                
                return PrioridadValidada = "ES ALTA";
            }
            else
            {
                return PrioridadValidada = "ES BAJA";
            }
        }

        public override string ToString()
        {
            return $"{IdCita};{TipoDeCita};{Paciente};{Profesional};{FechaHoraDeCita};{FechaHoraFinalDeCita};{Estado};{PrioridadValidada}";
        }
    }
}
