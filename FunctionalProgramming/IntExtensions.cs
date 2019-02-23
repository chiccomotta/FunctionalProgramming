using FunctionalLibrary.Maybe;

namespace FunctionalProgramming
{
    public static class IntExtensions
    {
        public static Maybe<int> MaybeParseInt(this string s)
        {
            return int.TryParse(s, out var result)
                ? (Maybe<int>)new Some<int>(result)
                : new None<int>();
        }
    }
}