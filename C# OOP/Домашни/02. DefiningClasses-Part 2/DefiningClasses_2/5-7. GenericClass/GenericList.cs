namespace _5_7.GenericClass
{
    using System;
    using System.Collections.Generic;
    public class GenericList<T> 
        where T : IComparable
    {
        private T[] list;
        private int capacity;
        private int count = 0;
        private List<int> insertIndeces = new List<int>();
        public GenericList(int capacity)
        {
            this.list = new T[capacity];
            this.capacity = capacity;
        }

        public int Count
        {
            get
            {
                return this.count;
            }           
        }

        public int Capacity
        {
            get
            {
                return this.capacity;
            }
        }

        public T this[int index]
        {
            get
            {
                OutOfRangeChek(index);
                return this.list[index];
            }
            set
            {
                OutOfRangeChek(index);
                this.list[index] = value;
            }
        }

        public void OutOfRangeChek(int index)
        {
            if(index < 0 || index >= capacity)
            {
                throw new IndexOutOfRangeException("Index was not found!");
            }
        }

        public void DoubleCollection(T[] list)
        {
            var newList = list;

            this.capacity *= 2;

            this.list = new T[capacity];

            for (int i = 0; i < newList.Length; i++)
            {
                this.list[i] = newList[i];
            }
        }

        public void Add(T element)
        {
            // chek if this index is set
            while (insertIndeces.Contains(count))    
            {
                count++;
            }

            if(this.count == this.capacity)
            {
                DoubleCollection(list);
            }

            this.list[this.count] = element;
            this.count++;
        }

        public void Remove(int index)
        {
            OutOfRangeChek(index);

            for (int i = index; i < capacity - 1; i++)
            {
                list[i] = list[i + 1];
            }

            this.list[capacity - 1] = default(T);

            if (index < count)
            {
                this.count--;
            }
        }

        public void Insert(int index, T element)
        {
            OutOfRangeChek(index);

            // index is set
            insertIndeces.Add(index); 
            
            if(this.count == this.capacity)
            {
                DoubleCollection(list);
            }

            for (int i = count + 1; i > index; i--)
            {
                list[i] = list[i - 1];
            }

            this.list[index] = element;
        }

        public void Clear()
        {
            for (int i = 0; i < capacity; i++)
            {
                this.list[i] = default(T);
            }
        }

        public int IndexOf(T element)
        {
            for (int i = 0; i < capacity; i++)
            {
                if (this.list[i].Equals(element))
                {
                    return i;
                }
            }

            return -1;
        }

        public int LastIndexOf(T element)
        {
            int index = -1;

            for (int i = 0; i < capacity; i++)
            {
                if (this.list[i].Equals(element))
                {
                    index = i;
                }
            }

            return index;
        }

        public T Min()
        {
            if(capacity == 0)
            {
                throw new ArgumentException("The Collection is empty!");
            }

            T min = this.list[0];

            foreach (var element in this.list)
            {
                if(min.CompareTo(element) > 0)
                {
                    min = element;
                }
            }

            return min;
        }

        public T Max()
        {
            if (capacity == 0)
            {
                throw new ArgumentException("The Collection is empty!");
            }

            T max = list[0];

            foreach (var element in list)
            {
                if(max.CompareTo(element) < 0)
                {
                    max = element;
                }
            }

            return max;
        }

        public override string ToString()
        {
            return string.Format(string.Join(", ", this.list));
        }
    }
}
