namespace CASPAR.Shared.Exceptions.Tests
{
    public static class DummyHelper
    {
        public static async Task<double> Division(int a, int b)
        {
            return await Task.FromResult(a / b);
        }

        public static async Task<string> ProcessStringInformation(string value1, string value2)
        {
            return await Task.FromResult($"{value1}-{value2}");
        }
    }
}
