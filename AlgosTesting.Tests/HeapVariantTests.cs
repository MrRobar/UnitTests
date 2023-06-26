using NUnit.Framework;
using Algos;

namespace AlgosTesting.Tests
{
    public class HeapVariantTests
    {
        [Test]
        public void DisplayArray_Should_Print_All_Elements()
        {
            // Arrange
            int[] arr = { 1, 2, 3 };
            HeapVariant heapVariant = new HeapVariant();

            // Act
            heapVariant.DisplayArray(arr);

            // Assert
            Assert.Pass();
        }

        [Test]
        public void FillArrayRandomly_Should_Fill_Array_With_Random_Numbers()
        {
            // Arrange
            int[] arr = new int[10];
            HeapVariant heapVariant = new HeapVariant();

            // Act
            heapVariant.FillArrayRandomly(arr);

            // Assert
            for (int i = 0; i < arr.Length; i++)
            {
                Assert.That(arr[i], Is.GreaterThan(0));
            }
        }

        [Test]
        public void InitialHeapFill_Should_Add_First_10_Elements_To_Heap()
        {
            // Arrange
            int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 };
            MinHeap heap = new MinHeap(10);
            HeapVariant heapVariant = new HeapVariant();

            // Act
            heapVariant.InitialHeapFill(heap, arr);

            // Assert
            for (int i = 0; i < 10; i++)
            {
                Assert.That(heap.GetMin(), Is.EqualTo(i + 1));
                heap.ReplaceMin(int.MaxValue);
            }
        }

        [Test]
        public void IterateThrowRemains_Should_Replace_Min_Values_In_Heap()
        {
            // Arrange
            int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 };
            MinHeap heap = new MinHeap(10);
            HeapVariant heapVariant = new HeapVariant();

            heapVariant.InitialHeapFill(heap, arr);

            // Act
            heapVariant.IterateThrowRemains(heap, arr);

            // Assert
            for (int i = 3; i < 13; i++)
            {
                Assert.That(heap.GetMin(), Is.EqualTo(i));
                heap.ReplaceMin(int.MaxValue);
            }
        }

        [Test]
        public void WriteTopValues_Should_Return_Top_10_Values_From_Heap()
        {
            // Arrange
            int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 };
            MinHeap heap = new MinHeap(10);
            HeapVariant heapVariant = new HeapVariant();
            int[] topValues = new int[10];

            heapVariant.InitialHeapFill(heap, arr);
            heapVariant.IterateThrowRemains(heap, arr);

            // Act
            heapVariant.WriteTopValues(heap, topValues);

            // Assert
            for (int i = 3; i < 13; i++)
            {
                Assert.That(topValues[i - 3], Is.EqualTo(i));
            }
        }
    }
}