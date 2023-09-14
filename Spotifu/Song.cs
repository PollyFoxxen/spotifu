using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spotifu
{
    class Song
    {
        public string Title { get; }
        public string Artist { get; }
        public int DurationSeconds { get; }

        public Song(string title, string artist, int durationSeconds)
        {
            Title = title;
            Artist = artist;
            DurationSeconds = durationSeconds;
        }

        public override string ToString()
        {
            return $"{Title} by {Artist} ({DurationSeconds} seconds)";
        }
    }

}
