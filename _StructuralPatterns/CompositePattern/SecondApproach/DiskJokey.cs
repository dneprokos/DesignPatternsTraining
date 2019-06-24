namespace DesignPatternsTraining.CompositePattern.SecondApproach
{
    //Client
    public class DiskJokey
    {
        SongComponent songList { get; }

        public DiskJokey(SongComponent newSongList)
        {
            songList = newSongList;
        }

        public void GetSongList()
        {
            songList.DisplaySongInfo();
        }
    }
}
