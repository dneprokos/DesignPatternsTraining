using System;
using System.Collections.Generic;

namespace DesignPatternsTraining.CompositePattern.SecondApproach
{
    public class SongGroup: SongComponent
    {
        public List<SongComponent> songComponents = new List<SongComponent>();

        public string groupName { get; }
        public string groupDescription { get; }

        public SongGroup(string newGroupName, string newgroupDescription)
        {
            groupName = newGroupName;
            groupDescription = newgroupDescription;
        }

        public override void Add(SongComponent newSongComponent)
        {
            songComponents.Add(newSongComponent);
        }

        public override void Remove(SongComponent newSongComponent)
        {
            songComponents.Remove(newSongComponent);
        }

        public override SongComponent GetComponent(int index)
        {
            return (SongComponent)songComponents[index];
        }

        public override void DisplaySongInfo()
        {
            Console.WriteLine(groupName + "" + groupDescription + "\n");

            foreach (var song in songComponents)
            {
                song.DisplaySongInfo();
            }
        }

    }
}
