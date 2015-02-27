using NUnit.Framework;
using System;
using System.Diagnostics;
using System.IO;
using dtcxamarin;

namespace UnitTest
{
    [TestFixture()]
    public class Test
    {
        [Test()]
        public void it_parses_catalog_json()
        {
            Catalog catalog = Catalog.Load();
            Debug.WriteLine(string.Format("Catalog: {0}", catalog.ToString()));
        }
    }
}

