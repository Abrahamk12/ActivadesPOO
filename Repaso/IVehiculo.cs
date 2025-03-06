using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repaso
{
    // Definición de la interfaz
    public interface IVehiculo
    {
        void Arrancar(); // Método sin implementación
        void Frenar();
        int VelocidadMaxima { get; } // Propiedad solo de lectura
    }

}
