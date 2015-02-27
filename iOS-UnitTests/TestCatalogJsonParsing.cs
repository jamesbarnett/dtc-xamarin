using System;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using NUnit.Framework;
using dtcxamarin;

namespace iOSUnitTests
{
    [TestFixture]
    public class TestCatalogJsonParsing
    {
        [Test]
        public void it_parses_catalog_json()
        {
            Catalog catalog = Catalog.Load();
            Debug.WriteLine(string.Format("Catalog: {0}", catalog));
        }
    }
}
