using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Xml.Serialization;
using Numerek.Core;

namespace Numerek.Core
{
    /// <summary>
    /// Data filters
    /// </summary>
    public class ZomQueuesFilter
    {
        /// <summary>
        /// Data filter
        /// </summary>
        /// <param name="data"></param>
        /// <returns>Filtered data where queue > 1</returns>
        public Kolejki Filter(Kolejki data)
        {
            //How to do with LINQ???
            //var moreThenOne = data.Grupa.Where<Grupa>(x => int.Parse(x.LiczbaOsobWKolejce) > 1);
            Kolejki kolejki = new Kolejki
            {
               Okienka = new List<Okienko>() 
            };
            foreach (var item in data.Okienka)
            {
                if (int.Parse(item.LiczbaOsobWKolejce) > 1)
                {
                    kolejki.Okienka.Add(item);
                }
            }
            return kolejki;
                
        }
    }
}
