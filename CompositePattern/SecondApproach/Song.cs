using System;

namespace DesignPatternsTraining.CompositePattern.SecondApproach
{
    public class Song: SongComponent
    {
        string songName { get; }
        string bandName { get; }
        int releaseYear { get; }

        public Song(string newSongName, string newBandName, int newYearReleased)
        {
            songName = newSongName;
            bandName = newBandName;
            releaseYear = newYearReleased;
        }

        public override void DisplaySongInfo()
        {
            Console.WriteLine(songName + " was recorded by " +
                bandName + " in " + releaseYear);
        }

    }
}
