namespace Homework2.RAM
{
    public class RAM : IGetInfo
    {
        private readonly string _model;
        public string Model => _model;
        public RAM( string model )
        {
            _model = model ?? throw new ArgumentException( nameof( model ) );
        }
        public virtual string GetComponentInfo()
        {
            return $"RAM: {_model}";
        }
    }
}
