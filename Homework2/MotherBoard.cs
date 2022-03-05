namespace Homework2
{
    public abstract class MotherBoard:IGetComponentInfo, IComponentCheck
    {
        public abstract string Model { get; set; }
        public abstract int numberMemorySlots { get; set; }
        public abstract int maximumMemoryCapacity { get; set; }
        public virtual void GetComponentInfo()
        {

        }
        public void ComponentCkeck()
        {
            if (Model == null || numberMemorySlots <= 0 || maximumMemoryCapacity <= 0)
            {
                throw new ArgumentException("Data entered incorrectly");
            }
        }
    }
}
