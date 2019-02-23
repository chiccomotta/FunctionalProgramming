using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace FunctionalProgramming
{
    public class Person
    {
        public string Name { get; set; }
        public decimal CostoAnnuo { get; set; }

        public static decimal operator +(Person p1, Person p2) =>
            p1.CostoAnnuo + p2.CostoAnnuo;
    }
}
