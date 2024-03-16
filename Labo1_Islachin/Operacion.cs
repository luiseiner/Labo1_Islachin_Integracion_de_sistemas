using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labo1_Islachin
{
    internal class Operacion
    {
        public int valorA { get; set; }
        public int valorB { get; set;}
        public int valorC { get; set;}

        public int Sumar ()
        { 
            return valorA + valorB; 
        }

        public int Restar()
        { 
            return valorA - valorB; 
        }
    }
}
