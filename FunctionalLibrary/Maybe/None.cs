using System;

namespace FunctionalLibrary.Maybe
{
    public class None<T> : Maybe<T>
    {
        public override bool HasValue()
        {
            return false;
        }

        public override T Value
        {
            get { throw new ApplicationException("Object is null"); }
        }
    }
}