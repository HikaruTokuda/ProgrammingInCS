using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

// it does not run well....
/*
namespace ProgrammingInCSharp.Chapter2
{

    class EnumeratorThing : IEnumerator<int>, IEnumerable
    {
        int count;
        int limit;

        public int Current
        {
            get
            {
                return count;
            }
        }

        object IEnumerator<int>.Current
        {
            get
            {
                return count;
            }
        }

        object IEnumerator.Current => throw new NotImplementedException();

        public void Dispose()
        {
        }

        public bool MoveNext()
        {
            if (++count == limit) return false;
            else return true;
        }

        public void Reset()
        {
            count = 0;
        }

        public IEnumerator<int> GetEnumerator()
        {
            return this;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }

        public EnumeratorThing(int limit)
        {
            count = 0;
            this.limit = limit;
        }

    }

    class Listening2_43
    {
    }
}
*/
