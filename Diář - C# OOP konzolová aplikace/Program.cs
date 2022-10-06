using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace Diar
{
    class Program
    {
        static void Main(string[] args)
        {
            UvitaciZprava();
            var funkce = new Funkce();
            funkce.FunkceDiare();

        }

        public static void UvitaciZprava()
        {
            Console.WriteLine("Vítejte v diáři");
            Console.WriteLine($"Dnes je {DateTimeOffset.UtcNow:G}");
            Console.WriteLine();
        }




    }
}
