using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pz10var
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SistemaOtr sitema = new SistemaOtr();

            sitema.SetDots(5,8,7);
            sitema.LengthOtrezok();
            Console.ReadLine();
        }
    }
}

