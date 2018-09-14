/* 
   Licensed under the Apache License, Version 2.0

   http://www.apache.org/licenses/LICENSE-2.0
   */
using System.Xml.Serialization;
using System.Collections.Generic;
namespace Numerek.Core
{
    [XmlRoot(ElementName = "ROOT")]
    public class Kolejki
    {
        [XmlElement(ElementName = "GRUPY")]
        public List<Okienko> Okienka { get; set; }
        [XmlAttribute(AttributeName = "time")]
        public string Time { get; set; }
        [XmlAttribute(AttributeName = "date")]
        public string Date { get; set; }
    }

}
