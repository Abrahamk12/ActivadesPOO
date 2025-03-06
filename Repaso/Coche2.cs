using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repaso
{
    class Coche2 : IVehiculo
    {
        public int VelocidadMaxima { get; private set; } = 200;

        public void Arrancar()
        {
            Console.WriteLine("El coche está arrancando.");
        }

        public void Frenar()
        {
            Console.WriteLine("El coche está frenando.");
        }
        public void setVelocidadMaxima(int velocidad)
        {
            this.VelocidadMaxima = velocidad;
        }
    }
}
