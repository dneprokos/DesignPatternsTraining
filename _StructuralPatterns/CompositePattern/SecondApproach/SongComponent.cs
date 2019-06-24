using System;

namespace DesignPatternsTraining.CompositePattern.SecondApproach
{
    public abstract class SongComponent
    {
        public virtual void Add(SongComponent songComponent)
        {
            throw new NotSupportedException();
        }

        public virtual void Remove(SongComponent songComponent)
        {
            throw new NotSupportedException();
        }

        public virtual SongComponent GetComponent(int index)
        {
            throw new NotSupportedException();
        }

        public virtual string GetSongName()
        {
            throw new NotSupportedException();
        }

        public virtual string GetBandName()
        {
            throw new NotSupportedException();
        }

        public virtual int GetReleaseYear()
        {
            throw new NotSupportedException();
        }

        public virtual void DisplaySongInfo()
        {
            throw new NotSupportedException();
        }
    }
}
