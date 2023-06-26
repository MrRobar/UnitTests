using NUnit.Framework;
using Algos;

namespace AlgosTesting.Tests
{

    [TestFixture]
    public class MergeSortVariantTests
    {
        [Test]
        public void Test_Merge_Sort_Result_With_Integers()
        {
            // Arrange 
            int[] arrToSort = new int[10] { 8, 1, 3, 2, 6, 10, 7, 5, 9, 4 };
            int[] expectedArr = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            MergeSortVariant mergeSortVariant = new MergeSortVariant();

            // Act
            mergeSortVariant.MergeSort(arrToSort, 0, arrToSort.Length - 1);

            // Assert
            CollectionAssert.AreEqual(expectedArr, arrToSort);
        }

        [Test]
        public void Test_Merge_Sort_Result_Empty()
        {
            int[] emptyArr = new int[10];
            int[] expectedArr = new int[10];
            MergeSortVariant mergeSortVariant = new MergeSortVariant();

            mergeSortVariant.MergeSort(emptyArr, 0, emptyArr.Length - 1);

            CollectionAssert.AreEqual(expectedArr, emptyArr);
        }

        [Test]
        public void Test_Merge_Sort_Result_With_Negative_Values()
        {
            int[] arrWithNegative = new int[10] { 3, -1, 9, 10, -5, 2, -3, 5, 7, -8 };
            int[] expectedArr = new int[10] { -8, -5, -3, -1, 2, 3, 5, 7, 9, 10 };
            MergeSortVariant mergeSortVariant = new MergeSortVariant();

            mergeSortVariant.MergeSort(arrWithNegative, 0, arrWithNegative.Length - 1);

            CollectionAssert.AreEqual(expectedArr, expectedArr);
        }

        [Test]
        public void Test_Merge_Sort_Result_With_Duplicated_Values()
        {
            int[] arrWithDuplicates = new int[10] { 9, 9, 3, 8, 5, 5, 1, 1, 4, 6 };
            int[] expectedArr = new int[10] { 1, 1, 3, 4, 5, 5, 6, 8, 9, 9 };
            MergeSortVariant mergeSortVariant = new MergeSortVariant();

            mergeSortVariant.MergeSort(arrWithDuplicates, 0, arrWithDuplicates.Length - 1);

            CollectionAssert.AreEqual(expectedArr, expectedArr);
        }
    }
}