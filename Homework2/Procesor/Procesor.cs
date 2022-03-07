namespace Homework2
{
    public abstract class Procesor: IGetAndCheckComponentInfo
    {
        public abstract string Model { get; set; }
        public abstract int numberCores { get; set; }
        public abstract double Frequency { get; set; }
        public virtual void GetComponentInfo()
        {

        }
        public void ComponentCkeck()
        {
            if (Model == null || numberCores <= 0 || Frequency <= 0)
            {
                throw new ArgumentException("Data entered incorrectly");
            }
        }
    }
}
