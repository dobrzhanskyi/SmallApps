namespace Fun_with_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] StartArray = new int[] { 1, 0, 2, 0, 1, 1, 0 };
            int[] FinishArray = new int[StartArray.Length];
            int NumberOfZeros=0;
            for (int StartArrayElementsCount = 0; StartArrayElementsCount < StartArray.Length; StartArrayElementsCount++)
            {
                if (StartArray[StartArrayElementsCount]==0)
                {                  
                    FinishArray[NumberOfZeros] = 0;
                    NumberOfZeros++;
                }             
            }         
            for (int StartArrayElementsCount = 0; StartArrayElementsCount < StartArray.Length; StartArrayElementsCount++)
            {
                if (StartArray[StartArrayElementsCount]!=0)
                {
                    FinishArray[FinishArray.Length - NumberOfZeros-1] = StartArray[StartArrayElementsCount];
                    NumberOfZeros--;
                }                
                Console.Write(FinishArray[StartArrayElementsCount]);
            }
            Console.ReadLine();
        }
    }
}