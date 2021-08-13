using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            int multiplicando;
            Console.Write("Informe o multiplicando:");
            multiplicando = Convert.ToInt32(Console.ReadLine());
            for (int multiplicador = 0; multiplicador <= 10; multiplicador++)
            {
                Console.WriteLine(string.Format("\t\t\t\t{0}\t*\t{1}\t=\t{2}",
                     multiplicando, multiplicador, multiplicando * multiplicador));
            }
            Console.Write("\nPressione alguma tecla para sair!");
            Console.ReadKey();
        }
    }
}
