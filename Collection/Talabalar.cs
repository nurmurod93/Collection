using System;
using System.Collections;

namespace Collections
{
    public class Talabalar : IEnumerable
    {
        private Inson[] _talabalar;

        public Talabalar(Inson[] insonlar)
        {
            _talabalar = insonlar;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return (IEnumerator)GetEnumerator();
        }

        public TalabalarEnum GetEnumerator()
        {
            return new TalabalarEnum(_talabalar);
        }
    }
}
