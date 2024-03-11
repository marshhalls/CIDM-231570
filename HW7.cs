namespace HW;
class Program{
    static void Main(string[]args){
        Customer p1 = new Customer();
        p1.cus_name = "Alice";
        p1.cus_id = 110;
        p1.new_id = 220;
        p1.cus_age = 28;
        p1.PrintInfo();
        
        Customer p2 = new Customer();
        p2.cus_name = "Bob";
        p2.cus_id = 111;
        p2.new_id = 221;
        p2.cus_age = 30;
        p2.PrintInfo();
        }
    }
}
class Customer{
    public string cus_name;
    public int cus_age;
    private int cus_id;
    public void PrintCusInfo(){
    Console.WriteLine($"Customer:{cus_id}, name:{cus_name}, age:{cus_age}");
}
}
public Customer(int cus_id, string cus_name, int cus_age){
id = input cus_id;
age = input cus_age;
name = input cus_name;
}
public void ChangeID(int new_id){
    Console.WriteLine($"Customer:{new_id}, name:{cus_name}, age:{cus_age}")
}

public void CompareAge(Customer objCustomer){
    if(p1.cus_age<= p2.cus_age){
    Console.WriteLine("Bob is older.");
}else{
    Console.WriteLine("Alice is older.");
}
}