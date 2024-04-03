using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SUT23_Generics_Labb1
{
    internal class boxCollection : ICollection<Box>
    {
        List<Box> boxList;

        public boxCollection() 
        {
            boxList = new List<Box>();
        }

        public int Count
        {
            get
            {
                return boxList.Count;
            }
        }

        public bool IsReadOnly
        {
            get
            {
                return false;
            }
        }

        public Box this[int index]
        {
            get { return (Box)boxList[index]; }
            set { boxList[index] = value; }
        }

        public void Add(Box item)
        {
            if (!Contains(item))
            {
                boxList.Add(item);
            }
            else
            {
                Console.WriteLine("Box with these values: H={0}  W={1}  L={2}  V={3} already exists in BoxCollection. \nDuplicate has been removed.",
                    item.Height, item.Width, item.Length, item.Volume);
            }
        }

        public void Clear()
        {
            throw new NotImplementedException();
        }

        public bool Contains(Box item)
        {
            bool found = false;
            foreach (Box b in boxList)
            {
                if (b.Equals(item)) { found = true; }
            }
            return found;
        }

        public bool Contains(Box item, EqualityComparer<Box> comp)
        {
            bool found = false;
            foreach(Box b in boxList)
            {
                if(comp.Equals(b, item))
                { 
                    found = true;
                }
            }
            return found;
        }

        public void CopyTo(Box[] array, int arrayIndex)
        {
            
        }

        public IEnumerator<Box> GetEnumerator()
        {
            return new boxEnumerator(this);
        }

        public bool Remove(Box item)
        {
            bool result = false; 
            for (int i = 0; i < boxList.Count; i++)
            {
                boxList.RemoveAt(i);
                result = true;
                break;
            }
            return result;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return new boxEnumerator(this);
        }
    }
}
