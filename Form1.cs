using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MusicManager
{
    public partial class Form1 : Form
    {
        const int MAX = 500;
        static Album[] albums;
        static int count = 0;// variable to count the num of albums

        public Form1()
        {
            InitializeComponent();

            albums = new Album[MAX];
            for (int i = 0; i < MAX; i++)
            {
                albums[i] = new Album();
            }

        }
        // method saves the form
        private void save_Click(object sender, EventArgs e)
        {
            if (albName.TextLength != 0 && songArt.TextLength != 0 && songGen.TextLength != 0 && songTitle.TextLength !=0 && songLen.TextLength != 0)// checks if form is filled
            {
                if (count < 0)
                {
                    count = 0;
                }
                albums[count].setAlbumName(albName.Text);// set album name
                albName.Enabled = false;//disables album input
                double len = getLen();//converts the text box data to double
                albums[count].AddSong(songTitle.Text, songArt.Text, songGen.Text, len);// adds song to album

                // empty the text boxes
                songTitle.Text = string.Empty;
                songArt.Text = string.Empty;
                songGen.Text = string.Empty;
                songLen.Text = string.Empty;
                progressBar1.Increment(count);
            }
            else 
            {
                MessageBox.Show("Please fill in all details");
            }
            
      
        }
        // method creates new album
        private void newAlb_Click(object sender, EventArgs e)
        {
            count = count + 1;
            albName.Enabled = true;// enables the albums text box to allow text input

            //emptys the text boxes
            albName.Text = string.Empty;
            songTitle.Text = string.Empty;
            songArt.Text = string.Empty;
            songGen.Text = string.Empty;
            songLen.Text = string.Empty;
        }
        private double getLen()
        {
            double len = 0;
            try
            {
                while (len == 0)
                {
                    len = Convert.ToDouble(songLen.Text);
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("enter lenth in numbers only, Length has been set to 0");
                len = 0;
            }
            return len;
        }

        private void listAlb_Click(object sender, EventArgs e)
        {
            listBox.Items.Clear();
            for (int i = 0; i <= count; i++)
            {
                try
                {
                    listBox.Items.Add(albums[i].getName().ToUpper());
                    albums[i].ListSongs(listBox.Items);
                }
                catch (Exception) { MessageBox.Show("out of bounds error"); }
            }
        }

        private void listSong_Click(object sender, EventArgs e)
        {
            listBox.Items.Clear();
            for (int i = 0; i <= count; i++)
            {
                albums[i].ListSongs(listBox.Items);
            }
        }

        private void listByGen_Click(object sender, EventArgs e)
        {
            string[] gen = new String[500];
            listBox.Items.Clear();
            for (int i = 0; i <= count; i++)
            {
                gen = albums[i].getGenres();

                for (int x = 0; x < gen.Length; x++)
                {
                    if (gen[x] != null)
                    {
                        listBox.Items.Add(gen[x].ToUpper() + "\n\n");
                        albums[i].searchSongsByGenre(listBox.Items, gen[x]);
                    }
                }
            }
        }

        private void listByArt_Click(object sender, EventArgs e)
        {
            string[] art = new String[500]; 
            listBox.Items.Clear();
            for (int i = 0; i <= count; i++)
            {
                art = albums[i].getArtist();

                for (int x = 0; x < art.Length; x++)
                {
                    listBox.Items.Add(art[x].ToUpper() + "\n\n");
                    albums[i].searchSongsByArtist(listBox.Items,art[x]);
                }
            }
        }

        private void del_Click(object sender, EventArgs e)
        {
            string entry= oldAlb.Text;
            for (int i = 0; i <= count; i++)
            {
                
                if (entry.Equals(albums[i].getName()))
                {
                    albums[i] = null;
                    albums[i] = new Album();
                    count = count - 1;
                    MessageBox.Show("Album Deleted");
                    albName.Enabled = true;
                }
            }
        }

        private void rename_Click(object sender, EventArgs e)
        {
            string entry = oldAlb.Text;

            for (int i = 0; i <= count; i++)
            {
                 if (entry.Equals(albums[i].getName()))
                 {
                     if (oldAlb.TextLength != 0 && newAlbInput.TextLength !=0)
                     {
                         albums[i].setAlbumName(newAlbInput.Text);
                     }
                     else {
                         MessageBox.Show("REMEMBER TO FILL IN FORM FIRST");
                     }
                 }
            }
        }

        private void artSearch_Click(object sender, EventArgs e)
        {
            for (int i = 0; i <= count; i++)
            {
                albums[i].listSongsByArtist(listBox.Items, artSearchInput.Text);
            }
        }

        private void songDel_Click(object sender, EventArgs e)
        {
            string entry = modSong.Text;
            for (int i = 0; i <= count;i++ )
            {
                albums[i].delSong(entry);
            }
        }

        private void songRename_Click(object sender, EventArgs e)
        {
            string entry = modSong.Text;
            double len = 0;
            try
            {
                len = Convert.ToDouble(newLen.Text);//converts the text box data to double
            }
            catch (FormatException) { MessageBox.Show("enter numbers only"); }
               for (int i = 0; i <= count; i++)
               {
                   if (newTit.TextLength != 0 && newArt.TextLength != 0 && newGen.TextLength != 0 && newLen.TextLength != 0)
                   {
                       albums[i].renameSong(entry, newTit.Text, newArt.Text, newGen.Text, len);
                   }
                   else
                   {
                       MessageBox.Show("REMEMBER TO FILL IN FORM FIRST");
                   }
               }
        }

        private void searchAlb_Click(object sender, EventArgs e)
        {
            if (albSearch.TextLength != 0)
            {
                string entry = albSearch.Text;
                for (int i = 0; i <= count; i++)
                {
                    if (entry.Equals(albums[i].getName()))
                    {
                        albums[i].ListSongs(listBox.Items);
                        progressBar1.Increment(10*i);
                    }
                    else { MessageBox.Show("Album "+ entry+" Not Found"); }
                }
            }
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }


    }
}
