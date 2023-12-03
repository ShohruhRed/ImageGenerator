namespace ImageGenerator
{
    public interface IGenerator
    {
        public Task<string> GetUrl(string promt);
    }
}
