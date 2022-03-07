namespace Homework2
{
    public class AMD: Procesor
    {
        string model = "AMD Ryzen 3 1200";
        public override string Model
        {
            get => model;
            set => model = value;
        }
        int numbercores = 4;
        public override int numberCores
        {
            get => numbercores;
            set => numbercores = value;
        }
        double frequency = 3.1;
        public override double Frequency
        {
            get => frequency;
            set => frequency = value;
        }
        public override void GetComponentInfo()
        {
            base.GetComponentInfo();
            Console.WriteLine($"Processor: model {Model}, number of cores {numberCores}, frequency {Frequency}");
        }
    }
}
