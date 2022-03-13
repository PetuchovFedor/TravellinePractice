namespace Homework2.Motherboard
{
    public class MotherBoard : IGetInfo
    {
        private readonly string _model;
        public string Model => _model;
        public MotherBoard(string model)
        {
            _model = model ?? throw new ArgumentException(nameof(model));
        }
        public virtual string GetComponentInfo()
        {
            return $"Motherboard: {_model}";
        }
    }
}