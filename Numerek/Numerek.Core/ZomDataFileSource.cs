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
    public partial class ZomDataFileSource : IDataSource
    {
        /// <summary>
        /// Take data from File
        /// </summary>
        public Kolejki GetData()
        {
            XmlSerializer serializer = new XmlSerializer(typeof(Kolejki));

            using (FileStream fileStream = File.Open(@"C:\WORK SPACE\Code Me workspace\numerek_repository\Numerek\Numerek.Tests\qmatic-zom4.xml", FileMode.Open))
            {
                var data = (Kolejki)serializer.Deserialize(fileStream);
                return data; //!!!!!!!!!!!!!!!!!!!!!!!!!!
            }


        }
        /// <summary>
        /// Takes data from file
        /// </summary>
        /// <param name="zomNumber">Numer zespolu obłsugi klienta</param>
        /// <returns>Kolejki type</returns>
        public Kolejki GetData(int zomNumber)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(Kolejki));

            using (FileStream fileStream = File.Open($@"C:\WORK SPACE\Code Me workspace\numerek_repository\Numerek\Numerek.Tests\qmatic-zom{zomNumber}.xml", FileMode.Open))
            {
                var data = (Kolejki)serializer.Deserialize(fileStream);
                return data; //!!!!!!!!!!!!!!!!!!!!!!!!!!
            }


        }


    }
}
