namespace Spotifu
{
         class Program
        {
        static void Main(string[] args)
        {
            Song song1 = new Song("Song 1", "Artist 1", 180);
            Song song2 = new Song("Song 2", "Artist 2", 210);
            Song song3 = new Song("Song 3", "Artist 3", 160);

            Playlist myPlaylist = new Playlist("My Favorites\n");

            myPlaylist.AddSong(song1);
            myPlaylist.AddSong(song2);
            myPlaylist.AddSong(song3);

            myPlaylist.ListSongs();

            myPlaylist.Play();

            myPlaylist.Skip();

            myPlaylist.MuteToggle();
        }
    }
}
