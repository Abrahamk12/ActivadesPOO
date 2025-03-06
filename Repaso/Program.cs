// See https://aka.ms/new-console-template for more information
using Repaso;

Console.WriteLine("Hello, World!");
/*
*   Tipo estático: Una vez declarado, el tipo de la variable no puede cambiar. 
*   Por ejemplo, una variable de tipo int no puede asignarse a un valor string.
*   Nombres de variables: Usa nombres descriptivos y sigue las convenciones (camelCase para variables locales).
*   Correcto: int edad = 25;
*   Incorrecto: int 123edad; (no puede comenzar con un número).
*   Ámbito de las variables: Las variables declaradas dentro de un bloque ({ }) 
*   solo son accesibles dentro de ese bloque.
*/
/*
using System;

class Program
{
    static void Main(string[] args)
    {
        int numero;        // Variable de tipo entero
        string texto;      // Variable de tipo cadena
        double decimal;    // Variable de tipo decimal
        bool esValido;     // Variable de tipo booleano

        //C# permite usar var para que el tipo sea inferido automáticamente según el valor asignado.
        var numero = 42;          // Tipo inferido como int
        var texto = "Hola mundo"; // Tipo inferido como string
        var decimal = 3.14;       // Tipo inferido como double


        // Solicitar al usuario que ingrese su nombre
        Console.Write("Por favor, ingresa tu nombre: ");
        string nombre = Console.ReadLine();

        // Solicitar al usuario que ingrese su edad
        Console.Write("Ingresa tu edad: ");
        int edad = int.Parse(Console.ReadLine()); // Convertir la entrada a entero

        // Mostrar los datos ingresados
        Console.WriteLine($"¡Hola {nombre}! Tienes {edad} años.");

        // Crear un objeto de la clase Coche
        Coche miCoche = new Coche();

        // Asignar valores a las propiedades
        miCoche.Marca = "Toyota";
        miCoche.Modelo = "Corolla";
        miCoche.Año = 2022;

        // Llamar al método del objeto
        miCoche.Conducir();
        
        //Casteo
        int entero = 42;
        double decimalNumber = entero; // Conversión implícita
        
        int entero = 42;
        string texto = entero.ToString(); // Método ToString()
        string textoInterpolado = $"{entero}"; // Interpolación

        double decimalNumber = 42.58;
        int entero = (int)decimalNumber; // Casteo explícito (pierde la parte decimal)

        double decimalNumber = 42.58;
        string texto = decimalNumber.ToString(); // Método ToString()
        string textoInterpolado = $"{decimalNumber}"; // Interpolación

        string texto = "42.58";
        double decimalNumber = double.Parse(texto); // Convierte un string a double

        // Manejo seguro con TryParse
        if (double.TryParse(texto, out double result))
        {
            Console.WriteLine($"Conversión exitosa: {result}");
        }
        else
        {
            Console.WriteLine("El string no es válido para convertir a double.");
        }

        string texto = "42";
        int entero = int.Parse(texto); // Convierte un string a entero

        // Manejo seguro con TryParse
        if (int.TryParse(texto, out int result))
        {
            Console.WriteLine($"Conversión exitosa: {result}");
        }
        else
        {
            Console.WriteLine("El string no es válido para convertir a int.");
        }

    }
}

Coche2 miCoche = new Coche2();
miCoche.Arrancar();
miCoche.setVelocidadMaxima(300);
IVehiculo coche = new Coche2();
coche.Arrancar();
*/
/*
Notas importantes:
Seguridad al convertir string: Es recomendable usar TryParse() en lugar de Parse() para evitar excepciones si el formato del string no es válido.

Pérdida de datos: Al convertir de double a int, la parte decimal se descarta.

Interpolación vs ToString(): Ambas son útiles, pero la interpolación es más moderna y legible.
*/