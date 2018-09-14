using System;
using System.Net.Http;
using System.Xml.Serialization;
namespace Numerek.Core
{
    /// <summary>
    /// Downloading data from website
    /// </summary>
    public class ZomWebFileSource : IDataSource
    {
        /// <summary>
        /// Geting data from website
        /// </summary>
        /// <param name="zomNumber">Numer zespołu obsługi klienta</param>
        /// <returns>Kolejki</returns>
        public Kolejki GetData(int zomNumber)
        {
            if (zomNumber < 0 || zomNumber > 4)
            {
                throw new Exception("Zly numer ZOM");
            }
            var client = new HttpClient();
            XmlSerializer serializer = new XmlSerializer(typeof(Kolejki));
            var xmlStream = client.GetStreamAsync($"http://www.gdansk.pl/files/xml/qmatic-zom{zomNumber}.xml").Result;
            Kolejki result = (Kolejki)serializer.Deserialize(xmlStream);

            return result;
        }
    }
}
