using Numerek.Core;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Numerek.Tests
{

    [TestFixture]
    class ZomHumanReadableOutputStrategyTests
    {
        [Test]
        public void ProducesExcpectedOutputForSampleData()
        {
            //Arrange
            //ROOT sampleData = new ZomDataFileSource().GetData();
            Kolejki sampleData = new Kolejki();
            sampleData.Okienka = new List<Okienko>();
            sampleData.Okienka.Add(new Okienko
            {
                NazwaGrupy = "Prawa Jazdy",
                LiczbaOsobWKolejce = "0",
                CzasOczekiwania = "0"
            });
            sampleData.Okienka.Add(new Okienko
            {
                NazwaGrupy = "Działalność gospodarcza i Potwierdzenie profilu Epuap",
                LiczbaOsobWKolejce = "2",
                CzasOczekiwania = "7"
            });

            var cut = new ZomHumanReadableOutputStrategy();
            string testResult = cut.Execute(sampleData);
            var expectedResult = $"Prawa Jazdy: Liczba osób w kolejce: 0, Czas Oczekiwania: 0min"//nowa linia rerturn
                + Environment.NewLine + $"Działalność gospodarcza i Potwierdzenie profilu Epuap: Liczba osób w kolejce: 2, Czas Oczekiwania: 7min" + Environment.NewLine;  // NAZWAGRUPY, LICZBAWKOLEJCE, CZASOSLUGI
            Assert.AreEqual(expectedResult, testResult);
        }
        [Test]
        public void ProducesExcpectedOutputForSampleData2()
        {
            //Arrange
            //ROOT sampleData = new ZomDataFileSource().GetData();
            Kolejki sampleData = new Kolejki(); 
            sampleData.Okienka = new List<Okienko>();
            sampleData.Okienka.Add(new Okienko
            {
                NazwaGrupy = "Prawa Jazdy",   //!!This data is send to Execute method NOT a file from ZoomDataFileSource class
                LiczbaOsobWKolejce = "0",
                CzasOczekiwania = "0"
            });

            var cut = new ZomHumanReadableOutputStrategy();
            string testResult = cut.Execute(sampleData);
            var expectedResult = $"Prawa Jazdy: Liczba osób w kolejce: 0, Czas Oczekiwania: 0" + Environment.NewLine;                 // NAZWAGRUPY, LICZBAWKOLEJCE, CZASOSLUGI
            Assert.AreEqual(expectedResult, testResult);
        }
    }
}
