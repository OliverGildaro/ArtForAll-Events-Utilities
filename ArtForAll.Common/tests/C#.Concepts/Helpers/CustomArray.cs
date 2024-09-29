namespace C_.Concepts.Helpers
{
    using System;

    public class CustomArray
    {
        int[] numbers = { 5, 2, 9, 1, 5, 6 };
        string[] fruits = { "Apple", "Banana", "Cherry", "Date" };
        object[] mixedArray = { 1, "Hello", 3.14, true };
        public string[] GetStrings()
        {
            return fruits;
        }
        public object[] GetMixedArray()
        {
            return mixedArray;
        }
        public int[] GetIntegers()
        {
            return numbers;

        }
    }

}
