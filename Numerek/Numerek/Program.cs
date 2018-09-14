using Numerek.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Numerek
{
    class Program
    {
        static void Main(string[] args)
        {
            /*var zomDataFileSource = new ZomDataFileSource().GetData(3);
            var output = new ZomHumanReadableOutputStrategy();
            Console.WriteLine(output.Execute(zomDataFileSource));
            */

            var numerek = new NumerekFlow(new ZomWebFileSource());
            var output = new ZomHumanReadableOutputStrategy();
            Console.WriteLine("Podaj numer ZOM 1-4");

            Console.WriteLine(output.Execute(numerek.Execute(int.Parse(Console.ReadLine()))));
            Console.ReadLine();
        }
    }
}
