/* 
   Licensed under the Apache License, Version 2.0

   http://www.apache.org/licenses/LICENSE-2.0
   */
using System;
using System.Xml.Serialization;
namespace Numerek.Core
{
    [XmlRoot(ElementName = "GRUPY")]
    public class Okienko 
    {
        [XmlElement(ElementName = "LP")]
        public string LP { get; set; }
        [XmlElement(ElementName = "IDGRUPY")]
        public string IdGrupy { get; set; }
        [XmlElement(ElementName = "LITERAGRUPY")]
        public string LiteraGrupy { get; set; }
        [XmlElement(ElementName = "NAZWAGRUPY")]
        public string NazwaGrupy { get; set; }
        [XmlElement(ElementName = "AKTUALNYNUMER")]
        public string AktualnyNumer { get; set; }
        [XmlElement(ElementName = "LICZBAKLWKOLEJCE")]
        public string LiczbaOsobWKolejce { get; set; }
        [XmlElement(ElementName = "LICZBACZYNNYCHSTAN")]
        public string IloscCzynnychStanowisk { get; set; }
        [XmlElement(ElementName = "CZASOBSLUGI")]
        public string CzasOczekiwania { get; set; }
        [XmlAttribute(AttributeName = "status")]
        public string Status { get; set; }
    }

}
