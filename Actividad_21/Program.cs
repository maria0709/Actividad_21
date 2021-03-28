using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad_21
{ class Program
    {     
    //Presente al usuario la fecha actual.
    static void Main(string[] args)
        {
        DateTime datenow = DateTime.Now;

        Console.WriteLine("La fecha de hoy es: " + datenow);
        Console.ReadKey();
        }
    }
}
