namespace FunctionalLibrary.Maybe
{
    public interface IMaybe<T>
    {
        bool HasValue();
        T Value { get; }
    }
}