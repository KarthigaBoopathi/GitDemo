using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace handson_12_09
{
    

        [Developer("New Album", SongName = "Halabithi Habhiho")]
        public class Song
        {
            [Developer("Name of the song", SongName = "Megam Karukaatha Penne")]
            public string SongName { get; set; }

            [Developer("Language of the song", Language = "Tamil")]
            public string Language { get; set; }

            [Developer("Lyrics", Lyrics = "Saaral Adikaatha Penne Penne")]

            [Developer("Language of the song", Language = "Tamil")]
            public string Lyrics { get; set; }


            public Song(string sname, string language, string lyrics)
            {
                SongName = sname;
                Language = language;
                Lyrics = lyrics;
            }
        }
    
}





