using Numerek.Core;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Numerek.Tests
{
    [TestFixture]
    class ZomDataFileSourceTests
    {
        [Test]
        public void LoadsFile()
        {
            //Class under tests
            var cut = new ZomDataFileSource();

            Kolejki data = cut.GetData();
            Assert.NotNull(data);

        }
        [TestCase(1)]
        [TestCase(2)]
        [TestCase(3)]
        [TestCase(4)]
        public void LoadsFromWebsite(int zom)
        {
            //Class under tests
            var cut = new ZomWebFileSource();

            Kolejki data = cut.GetData(zom);
            Assert.NotNull(data);
        }

    }
}
