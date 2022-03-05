namespace Homework2
{
    public abstract class RAM: IGetComponentInfo, IComponentCheck
    {
        public abstract string Model { get; set; }
        public abstract int memoryModuleCapacity { get; set; }
        public abstract int numberModules { get; set; }
        public virtual void GetComponentInfo()
        {

        }
        public void ComponentCkeck()
        {
            if (Model == null || memoryModuleCapacity <= 0 || numberModules <= 0)
            {
                throw new ArgumentException("Data entered incorrectly");
            }
        }
    }
}
