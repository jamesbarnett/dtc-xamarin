using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;

namespace dtcxamarin
{
    public class Catalog
    {
        [JsonProperty("designer")]
        public string Designer { get; set; }

        public List<Collection> Collections { get; set; }
        public Catalog()
        {
        }

        public static Catalog Load()
        {
            var assembly = typeof(Catalog).GetTypeInfo().Assembly;
            Stream stream = assembly.GetManifestResourceStream("dtcxamarin.catalog.json");

            using (TextReader reader = new StreamReader(stream))
            {
                string json = reader.ReadToEnd();
                return FromJson(json);
            }
        }

        private static Catalog FromJson(string json)
        {
            /*JObject obj = JObject.Parse(json);
            Catalog catalog = new Catalog();

            var designer = obj.Property("designer");

            catalog.Designer = (string)designer.Value[1];
            Debug.WriteLine(string.Format("Designer: {0}", designer));

            return catalog;
            */
            var catalog = JsonConvert.DeserializeObject<Catalog>(json);
            Debug.WriteLine(string.Format("Catalog: {0}", catalog));
            Debug.WriteLine(string.Format("Designer: {0}", catalog.Designer));

            return catalog;
        }

        public override string ToString()
        {
            StringBuilder buffer = new StringBuilder("");

            if (Collections != null && Collections.Count > 0)
            {
                foreach (var collection in Collections)
                {
                    buffer.AppendFormat(" {0} ", collection.ToString());
                }
            }

            return string.Format("[Catalog: Designer={0}, Collections=[{1}]]", Designer, 
                buffer.ToString());
        }
    }
}
