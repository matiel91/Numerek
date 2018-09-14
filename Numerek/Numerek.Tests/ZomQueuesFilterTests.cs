using Numerek.Core;
using NUnit.Framework;
using System;
using System.Collections.Generic;

namespace Numerek.Tests
{
    [TestFixture]
    class ZomQueuesFilterTests
    {
        [Test]
        public void ShowWhereIsMinTwoPersInQueue()
        {
            Kolejki sampleData = new Kolejki();
            sampleData.Okienka = new List<Okienko>();
            sampleData.Okienka.Add(new Okienko
            {
                NazwaGrupy = "Prawa Jazdy",
                LiczbaOsobWKolejce = "2",
                CzasOczekiwania = "5",
            });
            sampleData.Okienka.Add(new Okienko
            {
                NazwaGrupy = "Prawa Jazdy - Zatrzymania",
                LiczbaOsobWKolejce = "1",
                CzasOczekiwania = "3",
            });
            sampleData.Okienka.Add(new Okienko
            {
                NazwaGrupy = "Potwierdzenie opłaty po egzaminie",
                LiczbaOsobWKolejce = "0",
                CzasOczekiwania = "0",
            });
               sampleData.Okienka.Add(new Okienko
            {
                NazwaGrupy = "Działalność gospodarcza i Potwierdzenie profilu Epuap",
                LiczbaOsobWKolejce = "2",
                CzasOczekiwania = "7",
            });

            var cut = new ZomHumanReadableOutputStrategy();
            ZomQueuesFilter zqf = new ZomQueuesFilter();
            string testResult = cut.Execute(zqf.Filter(sampleData));
            var expectedResult = $"Prawa Jazdy: Liczba osób w kolejce: 2, Czas Oczekiwania: 5min"//nowa linia rerturn
                + Environment.NewLine + $"Działalność gospodarcza i Potwierdzenie profilu Epuap: Liczba osób w kolejce: 2, Czas Oczekiwania: 7min"
                + Environment.NewLine;  // NAZWAGRUPY, LICZBAWKOLEJCE, CZASOSLUGI
            Assert.AreEqual(expectedResult, testResult);

        }

    }
}
