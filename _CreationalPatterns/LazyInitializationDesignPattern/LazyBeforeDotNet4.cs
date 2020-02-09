namespace DesignPatternsTraining.LazyInitializationDesignPattern
{
    public class LazyBeforeDotNet4
    {
        static LazyBeforeDotNet4 dmInstance = null;

        public static LazyBeforeDotNet4 GetInstance()
        {
            if (dmInstance == null)
            {
                dmInstance = new LazyBeforeDotNet4();
            }

            return dmInstance;
        }
    }
}
