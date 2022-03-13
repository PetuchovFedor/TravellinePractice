namespace Homework2.RAM
{
    public class Kingston : RAM
    {
        public double MemoryModuleCapacity { get; set; }
        public int ModuleCount { get; set; }
        public Kingston( string model, double memorymodulecapacity, int modulecount ) : base( model )
        {
            if ( memorymodulecapacity <= 0 || modulecount <= 0 )
            {
                throw new ArgumentException( "Data entered incorrectly" );
            }
            MemoryModuleCapacity = memorymodulecapacity;
            ModuleCount = modulecount;
        }
        public override string GetComponentInfo()
        {
            return $"{base.GetComponentInfo()},  memory module capacity {MemoryModuleCapacity}, number of modules {ModuleCount}";
        }
    }
}
