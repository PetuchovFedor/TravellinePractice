namespace Homework2
{
    public abstract class VideoCard: IGetComponentInfo, IComponentCheck
    {
        public abstract string Model { get; set; }
        public abstract int videoMemoryCapacity { get; set; }
        public abstract double maximumMemoryBandwidth { get; set; }
        public virtual void GetComponentInfo()
        {

        }
        public void ComponentCkeck()
        {
            if (Model == null || videoMemoryCapacity <= 0 || maximumMemoryBandwidth <= 0)
            {
                throw new ArgumentException("Data entered incorrectly");
            }
        }
    }
}
