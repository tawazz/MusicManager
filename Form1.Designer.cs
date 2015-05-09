namespace MusicManager
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.albName = new System.Windows.Forms.TextBox();
            this.songLen = new System.Windows.Forms.TextBox();
            this.songGen = new System.Windows.Forms.TextBox();
            this.songArt = new System.Windows.Forms.TextBox();
            this.songTitle = new System.Windows.Forms.TextBox();
            this.save = new System.Windows.Forms.Button();
            this.newAlb = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.listBox = new System.Windows.Forms.ListBox();
            this.listAlb = new System.Windows.Forms.Button();
            this.listSong = new System.Windows.Forms.Button();
            this.listByGen = new System.Windows.Forms.Button();
            this.listByArt = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.del = new System.Windows.Forms.Button();
            this.rename = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.oldAlb = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.artSearch = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.newAlbInput = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.artSearchInput = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.modSong = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.newTit = new System.Windows.Forms.TextBox();
            this.newLen = new System.Windows.Forms.TextBox();
            this.newArt = new System.Windows.Forms.TextBox();
            this.newGen = new System.Windows.Forms.TextBox();
            this.songDel = new System.Windows.Forms.Button();
            this.songRename = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.albSearch = new System.Windows.Forms.TextBox();
            this.searchAlb = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // albName
            // 
            this.albName.Location = new System.Drawing.Point(93, 97);
            this.albName.Name = "albName";
            this.albName.Size = new System.Drawing.Size(357, 20);
            this.albName.TabIndex = 0;
            // 
            // songLen
            // 
            this.songLen.Location = new System.Drawing.Point(93, 274);
            this.songLen.Name = "songLen";
            this.songLen.Size = new System.Drawing.Size(357, 20);
            this.songLen.TabIndex = 4;
            // 
            // songGen
            // 
            this.songGen.Location = new System.Drawing.Point(93, 226);
            this.songGen.Name = "songGen";
            this.songGen.Size = new System.Drawing.Size(357, 20);
            this.songGen.TabIndex = 3;
            // 
            // songArt
            // 
            this.songArt.Location = new System.Drawing.Point(93, 185);
            this.songArt.Name = "songArt";
            this.songArt.Size = new System.Drawing.Size(357, 20);
            this.songArt.TabIndex = 2;
            // 
            // songTitle
            // 
            this.songTitle.Location = new System.Drawing.Point(93, 143);
            this.songTitle.Name = "songTitle";
            this.songTitle.Size = new System.Drawing.Size(357, 20);
            this.songTitle.TabIndex = 1;
            // 
            // save
            // 
            this.save.Location = new System.Drawing.Point(184, 315);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(75, 36);
            this.save.TabIndex = 5;
            this.save.Text = "SAVE";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // newAlb
            // 
            this.newAlb.Location = new System.Drawing.Point(277, 315);
            this.newAlb.Name = "newAlb";
            this.newAlb.Size = new System.Drawing.Size(75, 36);
            this.newAlb.TabIndex = 6;
            this.newAlb.Text = "NEW ALBUM";
            this.newAlb.UseVisualStyleBackColor = true;
            this.newAlb.Click += new System.EventHandler(this.newAlb_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "ALBUM";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "TITLE";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 185);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "ARTIST";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 226);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "GENRE";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(31, 281);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "LENGTH";
            // 
            // listBox
            // 
            this.listBox.FormattingEnabled = true;
            this.listBox.Location = new System.Drawing.Point(93, 766);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(357, 173);
            this.listBox.TabIndex = 14;
            // 
            // listAlb
            // 
            this.listAlb.Location = new System.Drawing.Point(93, 955);
            this.listAlb.Name = "listAlb";
            this.listAlb.Size = new System.Drawing.Size(75, 40);
            this.listAlb.TabIndex = 19;
            this.listAlb.Text = "LIST BY ALBUM";
            this.listAlb.UseVisualStyleBackColor = true;
            this.listAlb.Click += new System.EventHandler(this.listAlb_Click);
            // 
            // listSong
            // 
            this.listSong.Location = new System.Drawing.Point(184, 956);
            this.listSong.Name = "listSong";
            this.listSong.Size = new System.Drawing.Size(75, 39);
            this.listSong.TabIndex = 20;
            this.listSong.Text = "LIST SONGS";
            this.listSong.UseVisualStyleBackColor = true;
            this.listSong.Click += new System.EventHandler(this.listSong_Click);
            // 
            // listByGen
            // 
            this.listByGen.Location = new System.Drawing.Point(277, 956);
            this.listByGen.Name = "listByGen";
            this.listByGen.Size = new System.Drawing.Size(75, 39);
            this.listByGen.TabIndex = 21;
            this.listByGen.Text = "LIST BY GENRE";
            this.listByGen.UseVisualStyleBackColor = true;
            this.listByGen.Click += new System.EventHandler(this.listByGen_Click);
            // 
            // listByArt
            // 
            this.listByArt.Location = new System.Drawing.Point(375, 956);
            this.listByArt.Name = "listByArt";
            this.listByArt.Size = new System.Drawing.Size(75, 39);
            this.listByArt.TabIndex = 22;
            this.listByArt.Text = "LIST BY ARTIST";
            this.listByArt.UseVisualStyleBackColor = true;
            this.listByArt.Click += new System.EventHandler(this.listByArt_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Mistral", 48F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(70, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(401, 76);
            this.label6.TabIndex = 19;
            this.label6.Text = "MUSIC MANAGER";
            // 
            // del
            // 
            this.del.Location = new System.Drawing.Point(168, 424);
            this.del.Name = "del";
            this.del.Size = new System.Drawing.Size(75, 24);
            this.del.TabIndex = 10;
            this.del.Text = "DELETE";
            this.del.UseVisualStyleBackColor = true;
            this.del.Click += new System.EventHandler(this.del_Click);
            // 
            // rename
            // 
            this.rename.Location = new System.Drawing.Point(430, 424);
            this.rename.Name = "rename";
            this.rename.Size = new System.Drawing.Size(75, 24);
            this.rename.TabIndex = 9;
            this.rename.Text = "RENAME";
            this.rename.UseVisualStyleBackColor = true;
            this.rename.Click += new System.EventHandler(this.rename_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Mistral", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(201, 354);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(133, 34);
            this.label7.TabIndex = 22;
            this.label7.Text = "MANAGE DB";
            // 
            // oldAlb
            // 
            this.oldAlb.Location = new System.Drawing.Point(111, 391);
            this.oldAlb.Name = "oldAlb";
            this.oldAlb.Size = new System.Drawing.Size(132, 20);
            this.oldAlb.TabIndex = 7;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(24, 394);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(81, 13);
            this.label8.TabIndex = 24;
            this.label8.Text = "Enter old Album";
            // 
            // artSearch
            // 
            this.artSearch.Location = new System.Drawing.Point(375, 669);
            this.artSearch.Name = "artSearch";
            this.artSearch.Size = new System.Drawing.Size(132, 20);
            this.artSearch.TabIndex = 18;
            this.artSearch.Text = "SONGS BY ARTIST";
            this.artSearch.UseVisualStyleBackColor = true;
            this.artSearch.Click += new System.EventHandler(this.artSearch_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(274, 394);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(90, 13);
            this.label10.TabIndex = 27;
            this.label10.Text = "Enter new Album ";
            // 
            // newAlbInput
            // 
            this.newAlbInput.Location = new System.Drawing.Point(371, 391);
            this.newAlbInput.Name = "newAlbInput";
            this.newAlbInput.Size = new System.Drawing.Size(134, 20);
            this.newAlbInput.TabIndex = 8;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 669);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(86, 13);
            this.label9.TabIndex = 29;
            this.label9.Text = "Enter artist name";
            // 
            // artSearchInput
            // 
            this.artSearchInput.Location = new System.Drawing.Point(111, 666);
            this.artSearchInput.Name = "artSearchInput";
            this.artSearchInput.Size = new System.Drawing.Size(241, 20);
            this.artSearchInput.TabIndex = 17;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(2, 475);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(103, 13);
            this.label11.TabIndex = 31;
            this.label11.Text = "Enter song to modify";
            // 
            // modSong
            // 
            this.modSong.Location = new System.Drawing.Point(111, 468);
            this.modSong.Name = "modSong";
            this.modSong.Size = new System.Drawing.Size(297, 20);
            this.modSong.TabIndex = 11;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(59, 507);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(46, 13);
            this.label12.TabIndex = 33;
            this.label12.Text = "new title";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(245, 558);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(59, 13);
            this.label13.TabIndex = 34;
            this.label13.Text = "new length";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(245, 507);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(52, 13);
            this.label14.TabIndex = 35;
            this.label14.Text = "new artist";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(59, 558);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(57, 13);
            this.label15.TabIndex = 36;
            this.label15.Text = "new genre";
            // 
            // newTit
            // 
            this.newTit.Location = new System.Drawing.Point(111, 508);
            this.newTit.Name = "newTit";
            this.newTit.Size = new System.Drawing.Size(123, 20);
            this.newTit.TabIndex = 12;
            // 
            // newLen
            // 
            this.newLen.Location = new System.Drawing.Point(297, 555);
            this.newLen.Name = "newLen";
            this.newLen.Size = new System.Drawing.Size(123, 20);
            this.newLen.TabIndex = 15;
            // 
            // newArt
            // 
            this.newArt.Location = new System.Drawing.Point(297, 504);
            this.newArt.Name = "newArt";
            this.newArt.Size = new System.Drawing.Size(123, 20);
            this.newArt.TabIndex = 13;
            // 
            // newGen
            // 
            this.newGen.Location = new System.Drawing.Point(111, 555);
            this.newGen.Name = "newGen";
            this.newGen.Size = new System.Drawing.Size(123, 20);
            this.newGen.TabIndex = 14;
            // 
            // songDel
            // 
            this.songDel.Location = new System.Drawing.Point(430, 464);
            this.songDel.Name = "songDel";
            this.songDel.Size = new System.Drawing.Size(75, 24);
            this.songDel.TabIndex = 41;
            this.songDel.Text = "DELETE";
            this.songDel.UseVisualStyleBackColor = true;
            this.songDel.Click += new System.EventHandler(this.songDel_Click);
            // 
            // songRename
            // 
            this.songRename.Location = new System.Drawing.Point(222, 607);
            this.songRename.Name = "songRename";
            this.songRename.Size = new System.Drawing.Size(75, 24);
            this.songRename.TabIndex = 16;
            this.songRename.Text = "RENAME";
            this.songRename.UseVisualStyleBackColor = true;
            this.songRename.Click += new System.EventHandler(this.songRename_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(5, 711);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(92, 13);
            this.label16.TabIndex = 42;
            this.label16.Text = "Enter album name";
            // 
            // albSearch
            // 
            this.albSearch.Location = new System.Drawing.Point(111, 711);
            this.albSearch.Name = "albSearch";
            this.albSearch.Size = new System.Drawing.Size(241, 20);
            this.albSearch.TabIndex = 43;
            // 
            // searchAlb
            // 
            this.searchAlb.Location = new System.Drawing.Point(371, 711);
            this.searchAlb.Name = "searchAlb";
            this.searchAlb.Size = new System.Drawing.Size(134, 23);
            this.searchAlb.TabIndex = 44;
            this.searchAlb.Text = "SONGS IN ALBUM";
            this.searchAlb.UseVisualStyleBackColor = true;
            this.searchAlb.Click += new System.EventHandler(this.searchAlb_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(34, 328);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(100, 23);
            this.progressBar1.TabIndex = 45;
            this.progressBar1.Click += new System.EventHandler(this.progressBar1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(557, 463);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.searchAlb);
            this.Controls.Add(this.albSearch);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.songRename);
            this.Controls.Add(this.songDel);
            this.Controls.Add(this.newGen);
            this.Controls.Add(this.newArt);
            this.Controls.Add(this.newLen);
            this.Controls.Add(this.newTit);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.modSong);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.artSearchInput);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.newAlbInput);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.artSearch);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.oldAlb);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.rename);
            this.Controls.Add(this.del);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.listByArt);
            this.Controls.Add(this.listByGen);
            this.Controls.Add(this.listSong);
            this.Controls.Add(this.listAlb);
            this.Controls.Add(this.listBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.newAlb);
            this.Controls.Add(this.save);
            this.Controls.Add(this.songTitle);
            this.Controls.Add(this.songArt);
            this.Controls.Add(this.songGen);
            this.Controls.Add(this.songLen);
            this.Controls.Add(this.albName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "MusicManager";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox albName;
        private System.Windows.Forms.TextBox songLen;
        private System.Windows.Forms.TextBox songGen;
        private System.Windows.Forms.TextBox songArt;
        private System.Windows.Forms.TextBox songTitle;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.Button newAlb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox listBox;
        private System.Windows.Forms.Button listAlb;
        private System.Windows.Forms.Button listSong;
        private System.Windows.Forms.Button listByGen;
        private System.Windows.Forms.Button listByArt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button del;
        private System.Windows.Forms.Button rename;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox oldAlb;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button artSearch;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox newAlbInput;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox artSearchInput;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox modSong;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox newTit;
        private System.Windows.Forms.TextBox newLen;
        private System.Windows.Forms.TextBox newArt;
        private System.Windows.Forms.TextBox newGen;
        private System.Windows.Forms.Button songDel;
        private System.Windows.Forms.Button songRename;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox albSearch;
        private System.Windows.Forms.Button searchAlb;
        private System.Windows.Forms.ProgressBar progressBar1;
    }
}

