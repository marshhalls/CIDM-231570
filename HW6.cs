namespace HW;
class Program{
    static void Main(string[]args){
        Professor p1 = new Professor();
        p1.profName = "Alice";
        p1.classTeach = "Java";
        p1.salary = 9,000;
        p1.PrintInfo();

        Professor p2 = new Professor();
        p2.profName = "Bob";
        p2.classTeach = "Math";
        p2.salary = 8,000;
        p2.PrintInfo();

        student p1 = new student();
        p1.studentName = "Lisa";
        p1.classEnroll = "Java";
        p1.studentGrade = 90;
        p1.PrintInfo();

        student p2 = new student();
        p2.studentName = "Tom";
        p2.classEnroll = "Math";
        p2.studentGraded = 80;
        p2.PrintInfo();
        {
        Console.WriteLine($"The salary difference between {p1.profName} and {p2.profName} is: {difference}");
}
        {
        Console.WriteLine($"The total grade of {p1.student} and {p2.student} is: {total}");
}
    }
}
class student{
    public string studentName;
    public string classEnroll;
    private double studentGrade;
    public double newGrade{get;set;}
    public void PrintInfo(){
        Console.WriteLine($"Student {studentName} is enrolled in {classEnroll} and has a grade of: {studentGrade}. ");
    }
}
class Professor{
    public string profName;
    public string classTeach;
    private double salary;
    public double salary_amount{get;set;}
    public void PrintInfo(){
        Console.WriteLine($"Professor {profName} teaches {classTeach} and has a salary of: {salary}. ");
    }
}
class scores{
private int total;
public void grades(int amount){
total = p1.studentGrade + p2.studentGrade;
    }
}
class salaries{
private int difference;
public void salaries(int amount){
difference = p1.salary - p2.salary;
    }

}
}