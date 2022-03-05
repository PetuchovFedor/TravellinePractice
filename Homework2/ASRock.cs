namespace Homework2
{
    public class ASRock: MotherBoard
    {
        string model = "ASRock H310CM-DVS";
        public override string Model
        {
            get => model;
            set => model = value;
        }
        int numbermemoryslots = 2;
        public override int numberMemorySlots
        {
            get => numbermemoryslots;
            set => numbermemoryslots = value;
        }
        int maximummemorycapacity = 32;
        public override int maximumMemoryCapacity
        {
            get => maximummemorycapacity;
            set => maximummemorycapacity = value;
        }
        public override void GetComponentInfo()
        {
            base.GetComponentInfo();
            Console.WriteLine($"Motherboard: {Model}, number of memory slots {numberMemorySlots}, maximum memory capacity {maximumMemoryCapacity}");
        }
    }
}
