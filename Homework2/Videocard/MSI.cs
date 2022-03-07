namespace Homework2
{
    public class MSI: VideoCard
    {
        string model = "MSI GeForce 210";
        public override string Model
        {
            get => model;
            set => model = value;
        }
        int videomemorycapacity = 1;
        public override int videoMemoryCapacity
        {
            get => videomemorycapacity;
            set => videomemorycapacity = value;
        }
        double maximummemorybandwidth = 6.4;
        public override double maximumMemoryBandwidth
        {
            get => maximummemorybandwidth;
            set => maximummemorybandwidth = value;
        }
        public override void GetComponentInfo()
        {
            base.GetComponentInfo();
            Console.WriteLine($"Videocard: model {Model}, video memory capacity {videoMemoryCapacity}, maximum memory bandwigth {maximumMemoryBandwidth}");
        }
    }
}
