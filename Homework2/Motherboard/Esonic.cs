namespace Homework2.Motherboard
{
    public class Esonic : MotherBoard
    {        
        public int MemorySlotsCount { get; set; }
        public int MaximumMemoryCapacity { get; set; }
        public Esonic (string model, int memoryslotscount, int maximummemorycapacity ) : base(model)
        {
            if ( memoryslotscount <= 0 || maximummemorycapacity <= 0 )
            {
                throw new ArgumentException( "Data entered incorrectly" );
            }
            MaximumMemoryCapacity = maximummemorycapacity;
            MemorySlotsCount = memoryslotscount;
        }
        public override string GetComponentInfo()
        {
            return $"{base.GetComponentInfo()}, number of memory slots {MemorySlotsCount}, maximum memory capacity {MaximumMemoryCapacity}";
        }
    }
}
