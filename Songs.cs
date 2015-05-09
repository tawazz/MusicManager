using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MusicManager
{
    class Songs
    {

        private string title;
        private string artist;
        private string genre;
        private double length;
        /** constructors
         * */
        public Songs()
        {
            title = "track";
            artist = "artist";
            genre = "rap";
            length = 4.05;

        }
        public Songs(string tt, string art, string gen, double len)
        {
            title = tt;
            artist = art;
            genre = gen;
            length = len;

        }
        //getters
        public string getSongTittle()
        {
            return title;
        }
        public string getSongArtist()
        {
            return artist;
        }
        public string getSongGenre()
        {
            return genre;
        }
        public double getSongLength()
        {
            return length;
        }
        //setters
        public void setSongTittle(string tt)
        {
            title = tt;
        }
        public void setSongArtist(string art)
        {
            artist = art;
        }
        public void setSongGenre(string gen)
        {
            genre = gen;
        }
        public void setSongLength(double len)
        {
            length = len;
        }
        //method to delete a song
        public void delSong()
        {
            title = string.Empty;
            artist = string.Empty; 
            genre = string.Empty;
            length = 0;

        }
        //method to rename song info
        public void renameSongs(string tt, string art, string gen, double len)
        {
            // adds song info to a track
            title = tt;
            artist = art;
            genre = gen;
            length = len;

        }
    }
}
