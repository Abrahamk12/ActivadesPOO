// See https://aka.ms/new-console-template for more information
using Repaso;
using System;
using System.Net.Sockets;
/*
*   Tipo estático: Una vez declarado, el tipo de la variable no puede cambiar. 
*   Por ejemplo, una variable de tipo int no puede asignarse a un valor string.
*   Nombres de variables: Usa nombres descriptivos y sigue las convenciones (camelCase para variables locales).
*   Correcto: int edad = 25;
*   Incorrecto: int 123edad; (no puede comenzar con un número).
*   Ámbito de las variables: Las variables declaradas dentro de un bloque ({ }) 
*   solo son accesibles dentro de ese bloque.
*/
class Program
{
    static void Main(string[] args)
    {
        /*
        Console.WriteLine("¡Hola mundo!");
        int numero1;        // Variable de tipo entero
        string texto1;      // Variable de tipo cadena
        double decimal1;    // Variable de tipo decimal
        bool esValido;     // Variable de tipo booleano

        //C# permite usar var para que el tipo sea inferido automáticamente según el valor asignado.
        var numero2 = 42;          // Tipo inferido como int
        var texto2 = "Hola mundo"; // Tipo inferido como string
        var decimal2 = 3.14;       // Tipo inferido como double
        */
        /*
        int num1 =1, num2 = 1;
        if (num1 != 0 && num2 != 2)
        {
            Console.WriteLine("Ambos números son diferentes de cero y dos.");
        }
        if (num1 != 0 || num2 != 2)
        {
            Console.WriteLine("Ambos números son diferentes de cero y dos.");
        }
        */
        /*
        //Casteo
        int entero1 = 42;
        double decimalNumber1 = entero1; // Conversión implícita
        
        int entero2 = 42;
        string texto = entero2.ToString(); // Método ToString()
        string textoInterpolado1 = $"{entero2}"; // Interpolación

        double decimalNumber2 = 42.58;
        int entero3 = (int)decimalNumber2; // Casteo explícito (pierde la parte decimal)

        double decimalNumber3 = 42.58;
        string texto3 = decimalNumber3.ToString(); // Método ToString()
        string textoInterpolado3 = $"{decimalNumber3}"; // Interpolación

        string texto4 = "42.58";
        double decimalNumber4 = double.Parse(texto4); // Convierte un string a double

        // Manejo seguro con TryParse
        if (double.TryParse(texto4, out double result))
        {
            Console.WriteLine($"Conversión exitosa: {result}");
        }
        else
        {
            Console.WriteLine("El string no es válido para convertir a double.");
        }

        string texto5 = "42";
        int entero5 = int.Parse(texto5); // Convierte un string a entero

        // Manejo seguro con TryParse
        if (int.TryParse(texto, out int result2))
        {
            Console.WriteLine($"Conversión exitosa: {result2}");
        }
        else
        {
            Console.WriteLine("El string no es válido para convertir a int.");
        }

        */
        /*
        if (true)
        {

        }
        for (int i = 0; i < 10; i++)
        {

        }
        */

        /*
        // Solicitar al usuario que ingrese su nombre
        Console.Write("Por favor, ingresa tu nombre: ");
        string nombre = Console.ReadLine();

        // Solicitar al usuario que ingrese su edad
        Console.Write("Ingresa tu edad: ");
        int edad = int.Parse(Console.ReadLine()); // Convertir la entrada a entero

        // Mostrar los datos ingresados
        Console.WriteLine($"¡Hola {nombre}! Tienes {edad} años.");
        */

        /*
        // Crear un objeto de la clase Coche
        Coche miCoche = new Coche();

        // Asignar valores a las propiedades
        miCoche.Marca = "Toyota";
        miCoche.Modelo = "Corolla";
        miCoche.Año = 2022;

        // Llamar al método del objeto
        miCoche.Conducir();
        */

        //Coche2 miCoche = new Coche2();
        //miCoche.Arrancar();
        //miCoche.setVelocidadMaxima(300);
        IVehiculo coche = new Coche2();
        coche.Arrancar();
    }
}


/*
Notas importantes:
Seguridad al convertir string: Es recomendable usar TryParse() en lugar de Parse() para evitar excepciones si el formato del string no es válido.

Pérdida de datos: Al convertir de double a int, la parte decimal se descarta.

Interpolación vs ToString(): Ambas son útiles, pero la interpolación es más moderna y legible.
*/