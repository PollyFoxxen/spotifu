using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spotifu
{
    class Playlist
    {
        public string Name { get; }
        private List<Song> songs;
        private int currentSongIndex;
        private bool isMuted;

        public Playlist(string name)
        {
            Name = name;
            songs = new List<Song>();
            currentSongIndex = 0;
            isMuted = false;
        }

        public void AddSong(Song song)
        {
            songs.Add(song);
        }

        public void RemoveSong(Song song)
        {
            songs.Remove(song);
        }

        public void ListSongs()
        {
            Console.Write($"Playlist: \n\u001b[1;34m{Name}\u001b[0m");
            for (int i = 0; i < songs.Count; i++)
            {
                string songText = i == currentSongIndex ? $"▶ {songs[i]}" : songs[i].ToString();
                Console.WriteLine($"\u001b[1;32m{songText}\u001b[0m");
            }
        }

        public void Play()
        {
            if (currentSongIndex >= 0 && currentSongIndex < songs.Count)
            {
                Console.WriteLine($"Playing: \n \u001b[1;32m{songs[currentSongIndex]}\u001b[0m");
            }
            else
            {
                Console.WriteLine("No song to play.");
            }
        }

        public void Skip()
        {
            if (currentSongIndex < songs.Count - 1)
            {
                currentSongIndex++;
                Play();
            }
            else
            {
                Console.WriteLine("End of playlist reached.");
            }
        }

        public void MuteToggle()
        {
            isMuted = !isMuted;
            Console.WriteLine(isMuted ? "Muted." : "Unmuted.");
        }
    }
}

