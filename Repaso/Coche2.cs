using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repaso
{
    class Coche2 : IVehiculo
    {
        public Coche2()
        {
        }

        int IVehiculo.VelocidadMaxima { get; }

        void IVehiculo.Arrancar()
        {
            Console.WriteLine("El coche arrancó");
        }

        void IVehiculo.Frenar()
        {
        }
    }
}
