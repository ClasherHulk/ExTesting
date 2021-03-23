using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExPlayerTesting
{
    [TestFixture]
    public class OurTesting
    {
        [Test]
        public void PlayerTest()
        {
            foreach(var p in Program.Playerslist())
            {
                Assert.IsNotNull(p.PId);
                Assert.IsNotNull(p.PName);
                Assert.IsNotNull(p.PTeam);
            }

        }

    }
}
