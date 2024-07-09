namespace SearchingAlgorithms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr1 = { 1, 1, 2, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int arr1Result = LinearSearch(arr1, 4);
        }

        static int LinearSearch(int[] arrToSearch, int target)
        {
            //intitialize loop at 0
            //next we evaluate our expression
            //last we run the update logic
            for (int i = 0; i < arrToSearch.Length; i++)
            {
                if (arrToSearch[i] == target) return i;
            }

            return -1;
        }
    }
}
