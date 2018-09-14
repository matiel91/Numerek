using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Numerek.Core
{
    /// <summary>
    /// Human readable results
    /// </summary>
    public class ZomHumanReadableOutputStrategy
    {
        /*
        public string Execute(Kolejki data)
        {
            StringBuilder result = new StringBuilder();
            foreach (var item in data.Okienka)
            {
                //Correction Required - Need to equalize column => .PadRight() and correct unit tests
                result.AppendLine($"{item.NazwaGrupy.Trim()}: Liczba osób w kolejce: {item.LiczbaOsobWKolejce}, Czas Oczekiwania: {item.CzasOczekiwania}min");
            }

            return result.ToString();
        }
        */
        public string Execute(Kolejki data)
        {
            StringBuilder result = new StringBuilder();
            foreach (var item in data.Okienka)
            {
                //Correction Required - Need to equalize column => .PadRight() and correct unit tests
                result.AppendLine($"{item.NazwaGrupy.Trim()}: Liczba osób w kolejce: {item.LiczbaOsobWKolejce}, Czas Oczekiwania: {item.CzasOczekiwania}min");
            }

            return result.ToString();
        }
    }
   
}
