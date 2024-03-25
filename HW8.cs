class Program
{
    //*** Do NOT change the code in Main ***
    public static void Main (string[] args) {
        // Q1: calculate the sum of elements in a given int_array (4 points)
        int[] int_array = {11,23,31,42,53};
        ArraySum(int_array);
        public static void ArraySum(int[] int_array){
        //put your answer below
        static int sum(int[] int_array, int 5)
        {
            int x = sum(int_array, arr.Length);
            foreach(int x in int_array){
          Console.Write("The sum of int_array is:" + x);
        }
    }
 }
        // Input 2d array for Q2
        int[,] array_2d = {
            {1, 2, 3},
            {4, 5, 6},
            {7, 8, 9}
        };


        //Q2.1: given a 2d array, print all the odd elements (2 points)
        PrintAllOddNumber(array_2d);
        public static void PrintAllOddNumber(int[ , ] array_2d){
        //put your answer below
        int[,] array_2d = {
            {1, 2, 3},
            {4, 5, 6},
            {7, 8, 9}
        };
        foreach(int val in array_2d){
            if(val%2!==0){
                Console.WriteLine(val + "")
            }
        }

        //Q2.2: given a 2d array, return the sum of all elements (2 points)
        Console.WriteLine($"\nSum of 2d array: {ElementSum(array_2d)}");
        public static int ElementSum(int[ , ] array_2d){
        //put your answer below
        int ElementSum = sum(array_2d, arr.Length);

        //Q2.3: given a 2d array, double its element values and return it (2 points)

        int[,] Q2_3 = DoubleArray(array_2d);
        Console.WriteLine("The new 2d array:");
        foreach(int num in Q2_3){
                Console.Write(num +" ");
        }
        public static int[ , ] DoubleArray(int[ , ] array_2d){
         //put your answer below
         for(int num = 0;num<5;num++){
    		array2_2d[num] = array_2d[num]*2;
    }
    }
    }
