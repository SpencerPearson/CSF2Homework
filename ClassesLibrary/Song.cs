using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesLibrary
{
    public class Song
    {
        //fields

        //props
        public string Artist { get; set; }
        public string Title { get; set; }
        public int LengthInSeconds { get; set; }

        //ctors
        public Song() { }
        public Song(string artist, string title, int lengthInSeconds)
        {
            Artist = artist;
            Title = title;
            LengthInSeconds = lengthInSeconds;
        }
        

        //methods
        public override string ToString()
        {
            return string.Format("{0} by {1}\nLength: {2}:{3}", Title, Artist, LengthInSeconds / 60, LengthInSeconds % 60);
        }
    }
}
