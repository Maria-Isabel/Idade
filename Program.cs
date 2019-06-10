using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bel
{
    class Program
    {
        static void Main(string[] args)
        {
            int data;
            Console.WriteLine("informe sua data de nascimento: ");
            data = int.Parse(Console.ReadLine());
            data = 2019 - data;
            if (data > 18)
            {
                Console.WriteLine("Vc é maior de idade");
            }
            if (data <= 17)
            {


                Console.WriteLine("vc é menor de idade");
            }
            else if (data <=18 ) 
            {
                Console.WriteLine( "Vc é adulto ou fara 18 esse ano" );

            }

            Console.WriteLine( "" );
            Console.ReadKey();
        }

    }
}
