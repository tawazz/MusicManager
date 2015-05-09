using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.Windows.Forms;

namespace MusicManager
{
    class Album
    {

        private const int MAX = 500;
        Songs[] track;
        private string name;
        private int allSongs = 0;
        //constructors
        public Album()
        {
            name = "Album1";
            track = new Songs[MAX];
            allSongs = 0;
        }
        public Album(string nam)
        {
            name = nam;
            for (int i = 0; i < MAX; i++)
            {
                track[i] = new Songs();
            }
        }
        // set method
        public void setAlbumName(string nam)
        {
            name = nam;
        }
        // get method
        public string getName()
        {
            return name;
        }
        // method to add song to Album
        public void AddSong(string title, string art, string gen, double len)
        {
                int index = -1;
                for (int i = 0; i < MAX; ++i)
                    if (track[i] == null)
                    {
                        index = i; break;
                    }
                if (index != -1)
                {
                    track[allSongs] = new Songs(title, art, gen, len);
                    allSongs++;

                }

        }
        // method to list all songs
        public void ListSongs(IList list)
        {
            list.Add("TRACK       " + "ARTIST      " + "GENRE       " + "LENGTH   ");
            for (int i = 0; i < allSongs; ++i)
            {
                try
                {
                    list.Add(track[i].getSongTittle() + "   " + track[i].getSongArtist() + "       " + track[i].getSongGenre() + "       " + track[i].getSongLength());
                }
                catch (Exception ) {
                    MessageBox.Show("NO SONGS IN ALBUM");
                }
            }
        }
        public void searchSongsByArtist(IList list, string artist)
        {
            for (int i = 0; i < allSongs; ++i)
            {
                if (artist.Equals(track[i].getSongArtist()))
                {
                   list.Add(track[i].getSongTittle());
                }
            }
        }
        // method to search songs by genre
        public void searchSongsByGenre( IList list,string gen)
        {
            for (int i = 0; i < allSongs; ++i)
            {
                if (gen.Equals(track[i].getSongGenre()))
                {
                    list.Add(track[i].getSongTittle());
                }
            }
        }
        public void listSongsByArtist(IList list, string art)
        {
            list.Clear();
                for (int n = 0; n < allSongs; n++)
                {
                    if (art.Equals(track[n].getSongArtist()))
                    {
                        list.Add("Songs by " + track[n].getSongArtist());
                        list.Add(track[n].getSongTittle());
                    }
                }
        }
        public void listSongsByGenre(IList list, string gen)
        {
            list.Clear();
            for (int n = 0; n < allSongs; n++)
            {
                if (gen.Equals(track[n].getSongArtist()))
                {
                    list.Add("Songs in " + track[n].getSongGenre());
                    list.Add(track[n].getSongTittle());
                }
            }
        }
        public void delSong(string tit)
        {
            for (int i = 0; i < allSongs; ++i)
            {
                if (track[i] != null)
                {
                    if (track[i].getSongTittle().Equals(tit))
                    {
                        track[i].delSong();
                        allSongs--;
                        MessageBox.Show("Song deleted");
                    }
                }
            }
        }
        public string[] getArtist()
        {
            string[] art = new String[allSongs];
            for (int i = 0; i < allSongs; i++)
            {
                art[i] = track[i].getSongArtist();
            }
            return art;
        }
        public string[] getGenres()
        {
            string[] gen = new String[allSongs];
            for (int i = 0; i < allSongs; i++)
            {
                try
                {
                    gen[i] = track[i].getSongGenre();
                }
                catch (Exception exp) { MessageBox.Show("something went wrong"+ exp); };
            }
            return gen;
        }
        public void renameSong(string entry,string tit, string art, string gen, double len)
        {
            for (int i = 0; i < allSongs; ++i)
            {
                if (track[i] != null)
                {
                    if (track[i].getSongTittle().Equals(entry))
                    {
                        MessageBox.Show("Song Renamed");
                        track[i].renameSongs(tit, art, gen, len);
                    }
                }
            }
        }
    }
}
