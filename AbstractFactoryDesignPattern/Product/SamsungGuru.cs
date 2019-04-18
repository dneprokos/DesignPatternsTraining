namespace DesignPatternsTraining.AbstractFactoryDesignPattern.Product
{
    public class SamsungGuru : INormalPhone
    {
        public string GetModelDetails()
        {
            return "Model: Samsung Guru\nRAM: NA\nCamera: NA\n";
        }
    }
}
