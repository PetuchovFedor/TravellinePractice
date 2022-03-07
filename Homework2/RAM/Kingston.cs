namespace Homework2
{
    public class Kingston: RAM
    {
        string model = "Kingston HyperX FURY Black";
        public override string Model
        {
            get => model;
            set => model = value;
        }
        double memorymodulecapacity = 5;
        public override double memoryModuleCapacity
        {
            get => memorymodulecapacity;
            set => memorymodulecapacity = value;
        }
        int numbermodules = 1;
        public override int numberModules
        {
            get => numbermodules;
            set => numbermodules = value;
        }
        public override void GetComponentInfo()
        {
            base.GetComponentInfo();
            Console.WriteLine($"RAM: model {Model}, memory module capacity {memoryModuleCapacity}, number of modules {numberModules}");
        }
    }
}
