using System;

namespace Algos
{
    public class HeapVariant
    {

        public void DisplayArray(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
        }

        public void FillArrayRandomly(int[] arr)
        {
            Random rand = new Random();
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rand.Next(0, 100);
            }
        }

        public void InitialHeapFill(MinHeap heap, int[] arr)
        {
            for (int i = 0; i < 10; i++)
            {
                heap.Add(arr[i]);
            }
        }

        public void IterateThrowRemains(MinHeap heap, int[] arr)
        {
            for (int i = 10; i < arr.Length; i++)
            {
                int currentHealth = arr[i];

                if (currentHealth > heap.GetMin())
                {
                    heap.ReplaceMin(currentHealth);
                }
            }
        }

        public void WriteTopValues(MinHeap heap, int[] topValues)
        {
            for (int i = 0; i < 10; i++)
            {
                topValues[i] = heap.GetMin(); // Тут записываются итоговые значения
                heap.ReplaceMin(int.MaxValue);
            }
        }
    }
}
