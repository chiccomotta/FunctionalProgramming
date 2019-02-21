namespace FunctionalLibrary.Maybe
{
    public abstract class Maybe<T> : IMaybe<T>
    {
        public abstract bool HasValue();
        public abstract T Value { get; }        
    }
}