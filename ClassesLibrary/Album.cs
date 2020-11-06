using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesLibrary
{
    public class Album
    {
        //fields

        //props
        public Song[] Tracks { get; set; }
        public string Title { get; set; }
        public string Genre { get; set; }

        //ctors
        public Album(Song[] tracks, string title, string genre)
        {
            Tracks = tracks;
            Title = title;
            Genre = genre;
        }

        //methods

        public override string ToString()
        {
            return string.Format("Artist: {0} Genre: {1}", Title, Genre);
        }
    }
}
