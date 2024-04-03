using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SUT23_Generics_Labb1
{
    internal class boxEnumerator : IEnumerator<Box>
    {

        private boxCollection _box;
        private int currentIndex;
        private Box currentBox;

        public boxEnumerator(boxCollection box)
        {
            this._box = box;
            currentIndex = -1;
            currentBox = default(Box);
        }


        public Box Current
        {
            get { return currentBox; }
        }

        object IEnumerator.Current
        {
            get { return Current; }
        }

        public void Dispose()
        {
            
        }

        public int Count
        {
            get
            {
                return _box.Count;
            }
        }


        public bool MoveNext()
        {
            if(++currentIndex >= _box.Count)
            {
                return false;
            }
            else
            {
                currentBox = _box[currentIndex];
            }
            return true;
        }

        void IEnumerator.Reset()
        {
            currentIndex = -1;
        }
    }
}
