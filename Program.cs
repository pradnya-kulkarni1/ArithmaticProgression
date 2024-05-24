namespace ArithmaticProgression
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World! This program checks array elements are in arithmatic progression");
            Console.WriteLine("Please enter the length of the array of integers");
            String aLength = Console.ReadLine();
            int arrayLength = Convert.ToInt32(aLength);
            int[] firstArray = new int[arrayLength];

            Console.WriteLine($"Please enter {arrayLength} numbers of first array");
            for (int i = 0; i < arrayLength; i++)
            {
                String num = Console.ReadLine();
                int n = Convert.ToInt32(num);
                firstArray[i] = n;

            }
            bool isArithmatic = CanMakeArithmeticProgression(firstArray);
            Console.WriteLine("\n"+isArithmatic);
        }
        public static bool CanMakeArithmeticProgression(int[] arr)
        {
            bool result = true;
            Array.Sort(arr);
            if(arr.Length == 2)
            {
                if (arr[0] == arr[1]) result = false;
                else result = true;
            }
            int[] arrayOfdiff = new int[arr.Length-1];

            for(int i=0; i < arr.Length-1; i++)
            {
                arrayOfdiff[i] = arr[i] - arr[i+1];
            }
            for(int i = 0; i < arrayOfdiff.Length-1; i++)
            {
                if (arrayOfdiff[i] != arrayOfdiff[i + 1])
                {
                    return false;
                }
            }



            return result;
        }
    }
}
