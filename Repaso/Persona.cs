using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repaso
{
    class Persona
    {
        public string nombre { get; set; }
        int edad;
        public Persona() { }

        public void setEdad(int edad)
        {
            this.edad = edad;
        }
        public int getEdad()
        {
            return edad;
        }
    }
}
