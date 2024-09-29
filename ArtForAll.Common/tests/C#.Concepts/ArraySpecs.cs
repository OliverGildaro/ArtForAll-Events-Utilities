using C_.Concepts.Helpers;

namespace C_.Concepts
{
    public class ArraySpecs
    {
        [Fact]
        public void ReverseArray()
        {
            int[] array = new CustomArray().GetIntegers();
            var reverse = array.Reverse();
            Assert.Equal(reverse.Last(), array.First());
        }

        [Fact]
        public void CloneArray()
        {
            int[] array = new CustomArray().GetIntegers();
            var array2 = array.Clone();
            Assert.Equal(array, array2);
        }


        [Fact]
        public void IndexOfArray()
        {
            int[] array = new CustomArray().GetIntegers();
            int number = Array.IndexOf(array, 5);
            int number2 = Array.IndexOf(array, 9);
            Assert.Equal(0, number);
            Assert.Equal(2, number2);
        }

        [Fact]
        public void ClearArray()
        {
            int[] array = new CustomArray().GetIntegers();
            Array.Clear(array);
            Assert.Equal(0, array[0]);
            Assert.Equal(0, array[3]);

            string[] array2 = new CustomArray().GetStrings();
            Array.Clear(array2);
            Assert.Null(array2[0]);
            Assert.Null(array2[3]);

            object[] array3 = new CustomArray().GetMixedArray();
            Array.Clear(array3);
            Assert.Null(array3[0]);
            Assert.Null(array3[3]);
        }

        [Fact]
        public void SetValueArray()
        {
            int[] array = new CustomArray().GetIntegers();
            array.SetValue(3, 5);
            Assert.Equal(1, array[3]);
        }

        [Fact]
        public void GetValueArray()
        {
            int[] array = new CustomArray().GetIntegers();
            object val = array.GetValue(3);
            Assert.Equal(1, val);
        }
    }
}
//// Length
//Console.WriteLine($"Length: {numbers.Length}");

//// Sort
//Array.Sort(numbers);
//Console.WriteLine("Sorted: " + string.Join(", ", numbers));

//// Reverse
//Array.Reverse(numbers);
//Console.WriteLine("Reversed: " + string.Join(", ", numbers));

//// Clear
//Array.Clear(numbers, 1, 3);
//Console.WriteLine("Cleared: " + string.Join(", ", numbers));

//// IndexOf
//int index = Array.IndexOf(numbers, 5);
//Console.WriteLine($"Index of 5: {index}");

//// Copy
//int[] copy = new int[numbers.Length];
//Array.Copy(numbers, copy, numbers.Length);
//Console.WriteLine("Copy: " + string.Join(", ", copy));

//// BinarySearch
//int position = Array.BinarySearch(copy, 9); // Searching for an element
//Console.WriteLine($"Position of 9: {position}");