using System;
using Newtonsoft.Json;

namespace dtcxamarin
{
    public class Piece
    {
        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("image")]
        public string Image { get; set; }

        public Piece()
        {
        }

        public override string ToString()
        {
            return string.Format("[Piece: Title={0}, Description={1}, Image={2}]", Title, Description, Image);
        }
    }
}

