using System;


namespace MergeSort
{
    class MergeSort
    {
        static int[] Splits(int[] arr)
        {
            if (arr.Length == 1) // Ако дължината на масива стане равна на 1 елемент,
            {                    // тогава се връща този елемент и отиваме към другия метод
                return arr;
            }
            // Инициализират се два масива с равен брой елемента спрямо подаденият масив(arr).
            int middle = arr.Length / 2;
            int[] leftArr = new int[middle];
            int[] rightArr = new int[arr.Length - middle];
            // Слагаме в първия масив(left), половината от елементите на подадения масив (arr).
            for (int i = 0; i < middle; i++)
            {
                leftArr[i] = arr[i];
            }
            // Слагаме в втория масив(right), другата половината от елементи на подадения масив (arr).
            for (int i = middle, j = 0; i < arr.Length; i++, j++)
            {
                rightArr[j] = arr[i];
            }

            leftArr = Splits(leftArr); //Вика се рекурсия на лявата половина, докато нейната дължина не стане равна на 1.
            rightArr = Splits(rightArr); // След като свършим изцяло с лявата половина на първоначално подадения масив,
                                         // прави се същото и с дясната половина, докато не се изчерпят всички нейни стойности

            return Merge(leftArr, rightArr); //Когато в двата масива остане само по 1 елемент, викаме метода
                                             //Merge, който ще ги слее, разпределени по големина

        }

        public static int[] Merge(int[] left, int[] right)
        {
            int leftIndex = 0;
            int rightIndex = 0;
            int[] arr = new int[left.Length + right.Length];

            for (int i = 0; i < arr.Length; i++)
            {
                if (rightIndex == right.Length
                    || (leftIndex < left.Length
                    && left[leftIndex] <= right[rightIndex]))
                {
                    arr[i] = left[leftIndex];
                    leftIndex++;
                }
                else if (leftIndex == left.Length
                    || (rightIndex < right.Length
                    && left[leftIndex] >= right[rightIndex]))
                {
                    arr[i] = right[rightIndex];
                    rightIndex++;
                }
            }

            return arr;
        }

        static void Main()
        {
            int N = int.Parse(Console.ReadLine());

            int[] array = new int[N];

            for (int i = 0; i < N; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }

            array = Splits(array);

            for (int i = 0; i < N; i++)
            {
                Console.WriteLine(array[i]);
            }
            
        }
    }
}
