using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace AudioUpdateLibrary
{
    public class BulkUpdate
    {
        public string FolderName { get; set; }
        public bool IncludeSubFolder { get; set; }

        public string Composer { get; set; }
        public string AlbumAritist { get; set; }
        public string Genre { get; set; }
        public string AlbumName { get; set; }
        public int? Year { get; set; }
        public bool UpdateFolderNameAsAlbumName { get; set; }
        public bool UpdateFSASTitle { get; set; }

        public void ExecuteBulkUpdte() {


            string[] musicFiles = Directory.GetFiles( this.FolderName, "*.mp3",(this.IncludeSubFolder? SearchOption.AllDirectories:SearchOption.TopDirectoryOnly ));

            foreach (string musicFile in musicFiles)
            {
                var mp3 = new Mp3Lib.Mp3File(musicFile);

                if (string.IsNullOrEmpty(this.Composer) == false)
                    mp3.TagHandler.Composer = this.Composer;

                if (string.IsNullOrEmpty(this.AlbumName) == false)
                    mp3.TagHandler.Album = this.AlbumName;

                if (UpdateFolderNameAsAlbumName) {
                    // string Aname = Path.GetDirectoryName(musicFile);
                    mp3.TagHandler.Album = Path.GetFileName(Path.GetDirectoryName(musicFile));

                }

                if(this.Year !=null || this.Year >0)
                    mp3.TagHandler.Year = this.Year.ToString();

                if (string.IsNullOrEmpty(this.Genre) == false)
                    mp3.TagHandler.Genre = this.Genre;

                if(string.IsNullOrEmpty(this.AlbumAritist) == false) {
                    var x = mp3.TagModel.Where(c => c.FrameId == "TPE2").FirstOrDefault();
                    if (x == null) { 
                        Console.WriteLine("Null");
                        var ft = new Id3Lib.Frames.FrameText("TPE2");
                        ft.Text = this.AlbumAritist;
                        mp3.TagModel.Add(ft);
                    }
                    else {
                        Console.WriteLine("Not Null");
                        ((Id3Lib.Frames.FrameText)x).Text = this.AlbumAritist;
                    }
                }


                if (this.UpdateFSASTitle) {
                    string title = System.IO.Path.GetFileNameWithoutExtension(musicFile);
                    mp3.TagHandler.Title = Regex.Replace(title, @"[\d-]", string.Empty).Trim();                  
                }


                //foreach (var item in mp3.TagModel)
                //{
                //    Console.WriteLine(item.GetType().ToString());
                    
                //    Console.WriteLine(item.FrameId);

                //    Console.WriteLine(((Id3Lib.Frames.FrameText)item).Text);
                //}


                /*   mp3.TagHandler.Title = mp3.TagHandler.Title.Replace(txtFind.Text, txtReplace.Text);
                   mp3.TagHandler.Album = mp3.TagHandler.Album.Replace(txtFind.Text, txtReplace.Text);
                   mp3.TagHandler.Artist = mp3.TagHandler.Artist.Replace(txtFind.Text, txtReplace.Text);
                   mp3.TagHandler.Composer = mp3.TagHandler.Composer.Replace(txtFind.Text, txtReplace.Text);

                   mp3.TagHandler.Comment = mp3.TagHandler.Comment.Replace(txtFind.Text, txtReplace.Text);
                   mp3.TagHandler.Genre = mp3.TagHandler.Genre.Replace(txtFind.Text, txtReplace.Text);
                   mp3.TagHandler.Lyrics = mp3.TagHandler.Lyrics.Replace(txtFind.Text, txtReplace.Text);
                   mp3.TagHandler.Song = mp3.TagHandler.Song.Replace(txtFind.Text, txtReplace.Text);
                   foreach (var item in mp3.TagModel)
                   {

                   }*/


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
        }


        


    }
}
