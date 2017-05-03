using Id3;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AudioUpdateLibrary
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnFldr_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.ShowDialog();
            txtFolderPath.Text = folderBrowserDialog1.SelectedPath;
        }

        private void btnReplace_Click(object sender, EventArgs e)
        {

            this.UsingCSLib();
        }

        #region Using CsLib

        private void UsingCSLib() {
            string[] musicFiles = Directory.GetFiles(txtFolderPath.Text, "*.mp3");
            foreach (string musicFile in musicFiles)
            {
                var mp3 = new Mp3Lib.Mp3File(musicFile);
                mp3.TagHandler.Title = mp3.TagHandler.Title.Replace(txtFind.Text, txtReplace.Text);
                mp3.TagHandler.Album = mp3.TagHandler.Album.Replace(txtFind.Text, txtReplace.Text);
                mp3.TagHandler.Artist = mp3.TagHandler.Artist.Replace(txtFind.Text, txtReplace.Text);
                mp3.TagHandler.Composer = mp3.TagHandler.Composer.Replace(txtFind.Text, txtReplace.Text);

                mp3.TagHandler.Comment = mp3.TagHandler.Comment.Replace(txtFind.Text, txtReplace.Text);
                mp3.TagHandler.Genre = mp3.TagHandler.Genre.Replace(txtFind.Text, txtReplace.Text);
                mp3.TagHandler.Lyrics = mp3.TagHandler.Lyrics.Replace(txtFind.Text, txtReplace.Text);
                mp3.TagHandler.Song = mp3.TagHandler.Song.Replace(txtFind.Text, txtReplace.Text);
                 foreach (var item in mp3.TagModel)
                {
                    
                }
                mp3.Update();
                //Console.WriteLine(musicFile);
                //Console.WriteLine(mp3.HasTagOfFamily(Id3TagFamily.FileStartTag).ToString());
                //var x = this.GetValidVersion(mp3);
                //var tag = mp3.GetTag(x.Major, x.Minor);
                //Console.WriteLine("Title: {0}", tag.Title.Value);
                //Console.WriteLine("Artist: {0}", tag.Artists.Value);
                //Console.WriteLine("Album: {0}", tag.Album.Value);
                //Mp3Stream xs = new Mp3Stream(new MemoryStream());

                //mp3.WriteTag(tag, x.Major, x.Minor, WriteConflictAction.Replace);

                //foreach (var item in tag.Frames)
                //{
                //    Console.WriteLine(item.ToString());

                //}
                ////Id3Tag tag = mp3.GetTag(Id3TagFamily.FileStartTag);
                ////Console.WriteLine("Title: {0}", tag.Title.Value);
                ////Console.WriteLine("Artist: {0}", tag.Artists.Value);
                ////Console.WriteLine("Album: {0}", tag.Album.Value);
            }

            foreach (var filename in musicFiles)
            {
                //// Find and Replace the file name
                var newname = filename.Replace(txtFind.Text, txtReplace.Text);
                if (filename != newname)
                {
                    File.Move(filename, newname);
                }
            }
        }



        #endregion

        #region using ID3.Net
        private Version GetValidVersion(Mp3File mp3)
        {
            Version _v = null;
            foreach (var item in mp3.GetVersions().OrderBy(c => c.Major))
            {
                try
                {
                    _v = item;
                    var x = mp3.GetTag(_v.Major, _v.Minor);
                    break;
                }
                catch (Exception)
                {
                    _v = null;
                    throw;
                }
            }

            return _v;

        }

        private void WithID3_Net() {
            string[] musicFiles = Directory.GetFiles(txtFolderPath.Text, "*.mp3");
            foreach (string musicFile in musicFiles)
            {
                using (var mp3 = new Mp3File(musicFile, Mp3Permissions.ReadWrite))
                {
                    Console.WriteLine(musicFile);
                    Console.WriteLine(mp3.HasTagOfFamily(Id3TagFamily.FileStartTag).ToString());
                    var x = this.GetValidVersion(mp3);
                    var tag = mp3.GetTag(x.Major, x.Minor);
                    Console.WriteLine("Title: {0}", tag.Title.Value);
                    Console.WriteLine("Artist: {0}", tag.Artists.Value);
                    Console.WriteLine("Album: {0}", tag.Album.Value);
                    Mp3Stream xs = new Mp3Stream(new MemoryStream());

                    mp3.WriteTag(tag, x.Major, x.Minor, WriteConflictAction.Replace);

                    foreach (var item in tag.Frames)
                    {
                        Console.WriteLine(item.ToString());

                    }
                    //Id3Tag tag = mp3.GetTag(Id3TagFamily.FileStartTag);
                    //Console.WriteLine("Title: {0}", tag.Title.Value);
                    //Console.WriteLine("Artist: {0}", tag.Artists.Value);
                    //Console.WriteLine("Album: {0}", tag.Album.Value);
                }
            }

        }
        #endregion
    }
}
    