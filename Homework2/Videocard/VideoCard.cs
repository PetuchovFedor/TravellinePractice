namespace Homework2.VideoCard
{
    public class VideoCard : IGetInfo
    {
        private readonly string _model;
        public string Model => _model;
        public VideoCard( string model )
        {
            _model = model ?? throw new ArgumentException( nameof( model ) );
        }
        public virtual string GetComponentInfo()
        {
            return $"Videocard: {_model}";
        }
    }
}
