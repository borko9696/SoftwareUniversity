namespace Data_Structures__Algorithms_and_Complexity
{
    using System;

    public class StupidList<T>
    {
        private T[] arr = new T[0];

        public int Length
        {
            get { return this.arr.Length; }
        }

        public T this[int index]
        {
            get { return this.arr[index]; }
        }

        public T First
        {
            get { return this.arr[0]; }
        }

        public T Last
        {
            get { return this.arr[this.arr.Length - 1]; }
        }

        public void Add(T item)
        {
            var newArr = new T[this.arr.Length + 1];
            Array.Copy(this.arr, newArr, this.arr.Length);
            newArr[newArr.Length - 1] = item;
            this.arr = newArr;
        }

        public T Remove(int index)
        {
            var result = this.arr[index];
            var newArr = new T[this.arr.Length - 1];
            Array.Copy(this.arr, newArr, index);
            Array.Copy(this.arr, index + 1, newArr, index, this.arr.Length - index - 1);
            this.arr = newArr;
            return result;
        }

        public T RemoveFirst()
        {
            return this.Remove(0);
        }

        public T RemoveLast()
        {
            return this.Remove(this.Length - 1);
        }
    }

    //----------------------------------------------------------
    // Problem 1.      Add(T) Complexity
    // Answer: O(N)
    //----------------------------------------------------------

    //----------------------------------------------------------
    // Problem 2.      Remove(index) Complexity – Worst Case
    // Answer: O(N)
    //----------------------------------------------------------

    //----------------------------------------------------------
    // Problem 3.      Remove(index) Complexity – Best Case
    // Answer: O(N)
    //----------------------------------------------------------

    //----------------------------------------------------------
    // Problem 4.      Remove(index) Complexity – Average Case
    // Answer: O(N)
    //----------------------------------------------------------

    //----------------------------------------------------------
    // Problem 5.      RemoveFirst(T) Complexity
    // Answer: O(N)
    //----------------------------------------------------------

    //----------------------------------------------------------
    // Problem 6.      RemoveLast(T) Complexity
    // Answer: O(N)
    //----------------------------------------------------------

    //----------------------------------------------------------
    // Problem 7.      Length Complexity
    // Answer: O(N)
    //----------------------------------------------------------

    //----------------------------------------------------------
    // Problem 8.      This[index] Complexity
    // Answer: O(1)
    //----------------------------------------------------------

    //----------------------------------------------------------
    // Problem 9.      First Complexity
    // Answer: O(1)
    //----------------------------------------------------------

    //----------------------------------------------------------
    // Problem 10.     Last Complexity
    // Answer: O(1)
    //----------------------------------------------------------
}