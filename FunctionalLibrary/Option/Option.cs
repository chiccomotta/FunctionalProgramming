﻿using System;
using System.Collections.Generic;
using Unit = System.ValueTuple;

namespace FunctionalLibrary
{
    public struct Option<T>
    {
        private readonly T value;
        private readonly bool isSome;

        private bool isNone => !isSome;

        private Option(T value)
        {
            if (value == null)
                throw new ArgumentNullException();

            this.isSome = true;
            this.value = value;
        }

        public static Option<T> Some<T>(T value) => new Some<T>(value); // wrap the given value into a Some

        public static None None => None.Default; // the None value

        public static implicit operator Option<T>(None _) => new Option<T>();

        public static implicit operator Option<T>(Some<T> some) => new Option<T>(some.Value);

        public static implicit operator Option<T>(T value)
            => value == null ? None : Some(value);

        public R Match<R>(Func<R> None, Func<T, R> Some)
            => isSome ? Some(value) : None();

        public IEnumerable<T> AsEnumerable()
        {
            if (isSome) yield return value;
        }

        //public bool Equals(Option<T> other)
        //    => this.isSome == other.isSome
        //       && (this.isNone || this.value.Equals(other.value));

        //public bool Equals(None _) => isNone;

        //public static bool operator ==(Option<T> @this, Option<T> other) =>
        //    @this.Equals(other);

        //public static bool operator !=(Option<T> @this, Option<T> other) =>
        //    !(@this == other);

        public override string ToString() => isSome ? $"Some({value})" : "None";
    }

    public struct None
    {
        internal static readonly None Default = new None();
    }

    public struct Some<T>
    {
        internal T Value { get; }

        internal Some(T value)
        {
            if (value == null)
                throw new ArgumentNullException(nameof(value)
                    , "Cannot wrap a null value in a 'Some'; use 'None' instead");
            Value = value;
        }
    }
}