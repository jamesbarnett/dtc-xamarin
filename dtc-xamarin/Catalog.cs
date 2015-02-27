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

        [JsonProperty("collections", ItemIsReference = true)]
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
            return JsonConvert.DeserializeObject<Catalog>(json);
        }

        public override string ToString()
        {
            StringBuilder buffer = new StringBuilder("");

            foreach (var collection in Collections)
            {
                buffer.AppendFormat(" {0} ", collection);
            }

            return string.Format("[Catalog: Designer={0}, Collections=[{1}]]", Designer, 
                buffer.ToString());
        }
    }
}
