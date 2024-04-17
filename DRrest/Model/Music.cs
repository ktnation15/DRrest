﻿namespace DRrest.Model
{
    public class Music
    {
        public string Title { get; set; }
        public string Artist { get; set; }
        public int Duration { get; set; }
        public int PublicationYear { get; set; }

        public override string ToString()
        {
            return $"{Title}, {Artist}, {Duration}, {PublicationYear}";
        }
    }
}
