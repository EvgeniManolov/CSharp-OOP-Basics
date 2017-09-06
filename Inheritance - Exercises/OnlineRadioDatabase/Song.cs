using System;

namespace OnlineRadioDatabase
{
    public class Song
    {
        private string artist;
        private string songName;
        private int minutes;
        private int seconds;

        public Song(string artist, string songName, int minutes, int seconds)
        {
            this.Artist = artist;
            this.SongName = songName;
            this.Minutes = minutes;
            this.Seconds = seconds;
        }

        public int Seconds
        {
            get { return this.seconds; }
            protected set
            {
                if (value < 0 || value > 59)
                {
                    throw new ArgumentException("Song seconds should be between 0 and 59.");
                }
                this.seconds = value;
            }
        }

        public int Minutes
        {
            get { return this.minutes; }
            protected set
            {
                if (value < 0 || value > 14)
                {
                    throw new ArgumentException("Song minutes should be between 0 and 14.");
                }
                this.minutes = value;
            }
        }

        public string SongName
        {
            get { return this.songName; }
            protected set
            {
                if (value.Length < 3 || value.Length > 30)
                {
                    throw new ArgumentException("Song name should be between 3 and 30 symbols.");
                }
                this.songName = value;
            }
        }

        public string Artist
        {
            get { return this.artist; }
            protected set
            {
                if (value.Length < 3 || value.Length > 20)
                {
                    throw new ArgumentException("Artist name should be between 3 and 20 symbols.");
                }
                this.artist = value;
            }
        }
    }
}

