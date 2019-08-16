using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructores
{
    class Program
    {
        static void Main(string[] args)
        {
            Contacto contacto1 = new Contacto();
            contacto1.Nombre = "José";
            contacto1.Celular = "6444622662";
            contacto1.Telefono = "1774292";
            contacto1.Correo = "Jtap@gmail.com";

            Console.WriteLine("Contacto 1: ");
            Console.WriteLine("Nombre: " + contacto1.Nombre);
            Console.WriteLine("Direccion: " + contacto1.Direccion);
            Console.WriteLine("Correo: " + contacto1.Correo);
            Console.WriteLine("Celular: " + contacto1.Celular);
            Console.WriteLine("Telefono: " + contacto1.Telefono);

            Contacto contacto2 = new Contacto("Juan", "juan@gmail.com");

            Console.WriteLine(" ");
            Console.WriteLine("Contacto 2: ");
            Console.WriteLine("Nombre: " + contacto2.Nombre);
            Console.WriteLine("Correo: " + contacto2.Correo);
            Console.WriteLine("Dirección: " + contacto2.Direccion);

            Console.ReadLine();

        }
    }
}
