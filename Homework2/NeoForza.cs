namespace Homework2
{
    public class NeoForza: RAM
    {
        string model = "Neo Forza ENCKE";
        public override string Model
        {
            get => model;
            set => model = value;
        }
        int memorymodulecapacity = 8;
        public override int memoryModuleCapacity
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
