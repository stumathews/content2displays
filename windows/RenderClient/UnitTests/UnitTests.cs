using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace UnitTests
{

    [TestFixture]
    public class UnitTests
    {
      [TestFixtureSetUp]
      public void InitBeforeAnyTestsStart()
      { /* ... */ }

      [TestFixtureTearDown]
      public void DisposeAfterAllTestsCompleted()
      { /* ... */ }
      [SetUp]
      public void InitBeforeEachTest()
      { /* ... */ }

      [TearDown]
      public void DisposeAfterEachTest()
      { /* ... */ }

      [Test]
      [ExpectedException( typeof( InvalidOperationException ) )]
      public void ExpectAnException()
      { /* ... */ }

      [Test]
      public void Test1()
      { /* ... */ }

    }
}
