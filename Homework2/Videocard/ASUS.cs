namespace Homework2.VideoCard
{
    public class ASUS : VideoCard
    {
        public int VideoMemoryCapacity { get; set; } 
        public double MaximumMemoryBandwidth { get; set; }
        public ASUS( string model, int videomemorycapacity, double maximummemorybandwidth ) : base( model )
        {
            if (  videomemorycapacity <= 0 || maximummemorybandwidth <= 0 )
            {
                throw new ArgumentException( "Data entered incorrectly" );
            }
            VideoMemoryCapacity = videomemorycapacity;
            MaximumMemoryBandwidth = maximummemorybandwidth;
        }
        public override string GetComponentInfo()
        {
            return $"{base.GetComponentInfo()}, video memory capacity {VideoMemoryCapacity}, maximum memory bandwigth {MaximumMemoryBandwidth}";
        }
    }
}
