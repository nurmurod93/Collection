using System.Collections;

namespace Collections
{
    public class TalabalarEnum : IEnumerator
    {
        public Inson[] _talabalar;

        int position = -1;

        public TalabalarEnum(Inson[] insonlar)
        {
            _talabalar = insonlar;
        }

        public bool MoveNext()
        {
            position++;
            return (position < _talabalar.Length);
        }

        public void Reset()
        {
            position = -1;
        }

        object IEnumerator.Current
        {
            get
            {
                return Current;
            }
        }

        public Inson Current
        {
            get
            {
                try
                {
                    return _talabalar[position];
                }
                catch (System.IndexOutOfRangeException)
                {
                    throw new System.InvalidOperationException();
                }
            }
        }

    }
}
