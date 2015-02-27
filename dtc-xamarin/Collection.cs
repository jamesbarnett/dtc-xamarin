using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace dtcxamarin
{
    public class Collection
    {
        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("image")]
        public string Image { get; set; }

        [JsonProperty("pieces", ItemIsReference = true)]
        public List<Piece> Pieces { get; set; }

        public Collection()
        {
        }

        public override string ToString()
        {
            StringBuilder buffer = new StringBuilder();

            foreach (Piece piece in Pieces)
            {
                buffer.AppendFormat(" {0} ", piece);
            }

            return string.Format("[Collection: Title={0}, Description={1}, Image={2}, Pieces=[{3}]]",
                Title, Description, Image, buffer.ToString());
        }
    }
}

