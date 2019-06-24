using System;

namespace DesignPatternsTraining.PoolObjectDesignPattern
{
    public class PooledObject
    {
        DateTime _createdAt = DateTime.Now;

        public DateTime CreatedAt
        {
            get { return _createdAt; }
        }

        public string TempData { get; set; }
    }
}
