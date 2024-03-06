using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EsercizioRettangoli
{
    internal class Rettangolo
    {
        private readonly int _base;
        private readonly int _altezza;
        public int B { get { return _base; } }
        public int A { get { return _altezza; } }
        public Rettangolo(int Base, int Altezza)
        {
            _base = Base;
            _altezza = Altezza;
        }

        public static bool operator ==(Rettangolo r1, Rettangolo r2)
        {
            if (object.ReferenceEquals(r1, null) && object.ReferenceEquals(r2, null))
                Console.WriteLine("uguali");
                return true;
            if (object.ReferenceEquals(r1, null) || object.ReferenceEquals(r2, null))
                Console.WriteLine("diversi");
                return false;
            return (r1.B == r2.B && r1.A == r2.A);
        }
        public static bool operator !=(Rettangolo r1, Rettangolo r2)
        {
            return !(r1 == r2);
        }

    }
}
