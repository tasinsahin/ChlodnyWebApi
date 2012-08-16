namespace Aspects.Aspects
{
    public interface ICache
    {
        object this[string key] { get; set; }
    }
}