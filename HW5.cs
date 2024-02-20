namespace HW;
class Program
{
    Console.WriteLine(Q1);
    static void MyMethod(){
        int a=Convert.ToInt32(Console.ReadLine());
        int b=Convert.ToInt32(Console.ReadLine());
        int a, b, max;
        a = 3; 
        b = 5;
        if(a > b){
            max = a;
        }
        else{
            max = b;
        }
        Console.WriteLine($"The largest number is: {max}");

        }
        Console.WriteLine(Q2:);
        static void Main(string[]args){MyMethod();}
        int a=Convert.ToInt32(Console.ReadLine());
        int b=Convert.ToInt32(Console.ReadLine());
        int c=Convert.ToInt32(Console.ReadLine());
        int d=Convert.ToInt32(Console.ReadLine());
         int a, b, c, d, max;
        a = 3;
        b = 5;
        c = 7;
        d = 9;
        if(a>b && a>c && a>d: return a){
        a= max;
        }
        else if{
        (b>c && b>d: return b)
        b= max;
        }
        else if{(c>d: return c) 
        c= max;
        }
        else{(return d) 
        d= max;
            }
        Console.WriteLine($"The largest number is: {max}")
        }
        Console.WriteLine(Q3:);
        Console.WriteLine(Pt1:);
    static bool checkAge(int birth_year){
    int age = 2024 - birth_year 
    if(age>=18){
        return true 
            }
            else{
                return false 
            }
    }
        Console.WriteLine(Pt2:);
        static void createAccount(){
        Console.Write("Input username: ");
            string username = Console.ReadLine();
            Console.Write("Input password: ");
            string password = Console.ReadLine();
            Console.Write("Input password again: ");
            string passwordA = Console.ReadLine();
             Console.WriteLine("Input birthyear:");
        int birth_year = Convert.ToInt16(Console.ReadLine());
        {
            checkAge(int birth_year)
        }

            if (checkAge == true && password == passwordA)
            {
                Console.WriteLine("Account is created successfully");
                break;
            }
            else
            {
                Console.WriteLine($"Wrong password.");
            }
        }
}