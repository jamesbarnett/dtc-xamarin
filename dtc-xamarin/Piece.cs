using System;
using Newtonsoft.Json;

namespace dtcxamarin
{
    public class Piece
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }

        public Piece()
        {
        }

        public static Piece FromJson(string json)
        {
            return new Piece();
        }

        public override string ToString()
        {
            return string.Format("[Piece: Title={0}, Description={1}, Image={2}]", Title, Description, Image);
        }
    }
}

