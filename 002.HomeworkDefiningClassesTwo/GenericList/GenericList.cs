using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericList
{
    class GenericList<T> where T : IComparable<T>

    {
        private const int defaultSize = 10;
        private T[] list;
        private int position;
        public int Size { get; private set; }

        public GenericList()
            : this(defaultSize)
        {
        }

        public GenericList(int size)
        {
            this.list = new T[size];
        }

        public T this[int index]
        {
            get
            {
                return this.list[index];
            }
            set
            {
                this.list[index] = value;
            }
        }

        public void AddElement(dynamic element) //5. adding element
        {
            if (this.position < this.list.Length)
            {
                this.list[this.position] = element;
                this.position++;
            }
            else
            {
                T[] newList = new T[this.list.Length * 2];
                for (int index = 0; index < this.list.Length; index++)
                {
                    newList[index] = this.list[index];
                }

                this.position++;
                newList[this.list.Length] = element;
                this.list = newList;
            }
        }

        public void InsertElementByIndex(int index, dynamic element) //5. accessing element by index
        {
            if (this.list.Length > index)
            {
                int currentLength = this.list.Length + 1;
                T[] newList = new T[currentLength];
                bool beforeREm = true;

                for (int i = 0; i < currentLength; i++) 
                {
                   

                    if (index == i )
                    {
                        beforeREm = false;
                        newList[i] = element;
                        continue;
                    }

                    if (beforeREm)
                    {
                        newList[i] = this.list[i];
                    }
                    else
                    {
                        newList[i] = this.list[i - 1];
                    }
                }

                this.list = newList;
            }
            else
            {
                Console.WriteLine("Error, out of array");
            }
        }

        public void RemoveElementByIndex(int index) //5. removing element by index
        {
            if (this.list.Length > index)
            {
                int currentLength = this.list.Length - 1;
                T[] newList = new T[currentLength];
                bool beforeREm = false;
                for (int i = 0; i < currentLength; i++)
                {
                    

                    if (index == i)
                    {
                        beforeREm = false;

                    }
                    if (beforeREm)
                    {
                        newList[i] = this.list[i];
                    }
                    else
                    {
                        newList[i] = this.list[i + 1];
                    }
                }
                this.list = newList;
            }
            else
            {
                Console.WriteLine("Error, out of array");
            }
        }

        

        public void CleanList() //5. clearing the list
        {
            this.list = new T[1];

        }

        public int FindElemByValue(dynamic value) //5. finding element by its value
        {
            int index = -1;

            for (int i = 0; i < this.list.Length; i++)
            {
                if (this.list[i]==value)
                {
                    index = i;
                   
                    break;
                   
                }
                
            }
            if (index == -1)
            {
                Console.WriteLine("No match");
            }
            else
            {
                Console.WriteLine("The index is : {0}", index);
            }
            return index;
        }

        public override string ToString() //5. Method ToString
    {
        StringBuilder text = new StringBuilder();
        int currentLength = this.list.Length;
        for (int i = 0; i < currentLength; i++)
        {
            text.AppendFormat("{0} ", list[i]);
            if (i < currentLength - 1)
            {
                text.Append(", ");
            }
        }

        return text.ToString().Trim();
    }

        private void IncreaseCapacity() //6. Implement auto-grow functionality
        {

            if (defaultSize >= this.Size)
            {
                this.Size *= 2;

                T[] newArray = (T[])list.Clone();
                this.list = new T[Size];

                for (int i = 0; i < newArray.Length; i++)
                {
                    this.list[i] = newArray[i];
                }
            }
        }

        public T Maximum() // 7.Create generic methods Max<T>() 
        {
            dynamic maximumElement = int.MinValue;
            for (int index = 0; index < this.list.Length; index++)
            {
                if (maximumElement<this.list[index])
                {
                    maximumElement = this.list[index];
                }
            }

            return maximumElement;
        }
        public T Minimum() //7. Create generic methods Min<T>() 
        {
            dynamic miniumElement = int.MaxValue;
            for (int index = 0; index < this.list.Length; index++)
            {
                if (miniumElement > this.list[index])
                {
                    miniumElement = this.list[index];
                }
            }

            return miniumElement;
        }
    }
}
