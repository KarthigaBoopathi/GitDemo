using System;

namespace handson_12_09
{
    internal class DeveloperAttribute : Attribute
    {
        private string v;
        private string songName;

        public DeveloperAttribute(string v, string SongName)
        {
            this.v = v;
            songName = SongName;
        }

        public bool SongName { get; internal set; }
    }
}