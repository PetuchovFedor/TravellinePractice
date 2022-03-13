namespace Homework2.Procesor
{
    public class Procesor : IGetInfo
    {
        private readonly string _model;
        public string Model => _model;
        public Procesor( string model )
        {
            _model = model ?? throw new ArgumentException( nameof( model ) );
        }
        public virtual string GetComponentInfo()
        {
            return $"Processor: {_model}";
        }
    }
}
