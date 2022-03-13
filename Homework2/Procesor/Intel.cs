namespace Homework2.Procesor
{
    public class Intel : Procesor
    {
        public int CoresCount { get; set; }
        private double Frequancy { get; set; }
        public Intel( string model, int corescount, double frequancy ) : base( model )
        {
            if ( corescount <= 0 || frequancy <= 0 )
            {
                throw new ArgumentException( "Data entered incorrectly" );
            }
            CoresCount = corescount;
            Frequancy = frequancy;

        }
        public override string GetComponentInfo()
        {
            return $"{base.GetComponentInfo()}, number of cores {CoresCount}, frequency {Frequancy}";
        }
    }
}
