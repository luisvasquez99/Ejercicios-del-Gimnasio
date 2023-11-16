using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejecicios_del_Gym
{
    internal class Ejercicios
    {
        public string Lunes { get; set; }
        public string Martes { get; set; }
        public string Miércoles { get; set; }
        public string Jueves{ get; set; }
        public string Viernes { get; set; }
        public string Sábado { get; set; }
        public string Domingo { get; set; }

        public Ejercicios (string lunes, string martes, string miercoles,  string jueves, string viernes, string sábado, string domingo)
        {
            this.Lunes = lunes;
            this.Martes = martes;
            this. Miércoles = miercoles;
            this. Jueves = jueves;
            this .Viernes = viernes;
            this. Sábado = sábado;
            this .Domingo = domingo;
        }


    }
}
