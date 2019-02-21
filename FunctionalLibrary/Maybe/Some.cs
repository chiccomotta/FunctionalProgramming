namespace FunctionalLibrary.Maybe
{
    public class Some<T> : Maybe<T>
    {
        private readonly T t;

        public Some(T t)
        {
            this.t = t;
        }

        public override bool HasValue()
        {
            return true;
        }

        public override T Value
        {
            get { return t; }
        }
    }
}