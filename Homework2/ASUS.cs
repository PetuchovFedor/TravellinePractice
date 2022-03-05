namespace Homework2
{
    public class ASUS: VideoCard
    {
        string model = "ASUS GeForce GT 710 Silent LP";
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
        double maximummemorybandwidth = 21;
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
