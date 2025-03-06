namespace Repaso
{
    class Coche
    {
        // Propiedades del coche
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public int Año { get; set; }
        public Coche() { }

        // Método del coche
        public void Conducir()
        {
            Console.WriteLine($"El coche {Marca} {Modelo} del año {Año} está en movimiento.");
        }
    }
}
