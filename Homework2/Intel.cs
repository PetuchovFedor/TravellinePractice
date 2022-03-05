namespace Homework2
{
    public class Intel: Procesor
    {
        string model = "Intel Core i3 9100F";
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
        double frequency = 3.6;
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
