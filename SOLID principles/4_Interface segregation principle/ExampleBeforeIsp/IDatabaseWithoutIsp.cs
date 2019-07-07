namespace DesignPatternsTraining.SOLID_principles._4_Interface_segregation_principle
{
    public interface IDatabaseWithoutIsp
    {
        void Add(); // old client are happy with these.
        void Read(); // Added for new clients. 

        //In this case it will disturb a lot of old clients
    }
}
