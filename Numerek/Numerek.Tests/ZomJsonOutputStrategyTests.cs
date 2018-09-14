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
    class ZomJsonOutputStrategyTests
    {
        [Test]
        public void ReturnJSon()
        {
            var cut = new ZomDataFileSource();

            ZomJsonOutputStrategy zjos = new ZomJsonOutputStrategy();
            
            var data = zjos.Execute(cut.GetData());
            Assert.IsNotEmpty(data);

        }
        
    }
}
