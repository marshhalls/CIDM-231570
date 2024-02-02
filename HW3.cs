namespace HW;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Homework #3");
        Console.WriteLine("Q1");
        Console.WriteLine("Input an integer:");
        string N = Console.ReadLine();
        int N = 7;
        while()
        {
            if (N % (2<N<N-1) == 0)
            {
                Console.WriteLine("N is non-prime");
                break;
            }
            else {
                Console.WriteLine("N is prime");
            }
        }
        Console.WriteLine("Q2");
        Console.WriteLine("Assign an int value to M:");
        string M = Console.ReadLine();
        int M =5;
        for(int row= 0; row<M; row++){
            for(int col=0; col<M; col++)
        }
        {
            Console.Write('#');
        }
        Console.WriteLine("");
        Console.WriteLine("Q3");
        Conosle.WriteLine("Assign an int value to Y:");
        string Y= Console.ReadLine();
        int Y= 5;
        for(int row = 0; row<Y; row++){
            for(int col=0; col<Y; col++)
            {
                if(row>=col)
                Console.Write('*')
            }
            Console.WriteLine("")
        }
        Console.WriteLine("BONUS");
        Console.WriteLine("Assign an int value to Z:");
        string Z= Console.ReadLine();
        int Z= 5 
        for(int col=0; col<Z; col++)
        { 
           for(int row=0; row<Z; row++)
           {
           if(row>=col)
           Console.Write(row);
           }
           ConsoleWriteLine("")
        }