﻿namespace Lecture2;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Lecture2");
        /*Q1: Input a grade in letters (A, B, C, D, F), print the corresponding GPA points
A:4 B:3 C:2	D:1	F:0 If the user input a letter rather than (A, B, C, D, F), then print “Wrong Letter Grade!”
Sample output:*/

Console.WriteLine("Please input a letter grade: ");
{
int lettergrade = Convert.ToInt32(Console.ReadLine());
switch(lettergrade)
{
case "A":
  Console.WriteLine("GPA Point: 4");
break;
case "B":
  Console.WriteLine("GPA Point: 3");
  break;
case "C":
  Console.WriteLine("GPA Point: 2");
break;
case "D":
  Console.WriteLine("GPA Point: 1");
break;
case "F":
  Console.WriteLine("GPA Point: 0");
break;
default:
  Console.WriteLine("Wrong Letter Grade!");
  break;
}
Console.WriteLine("Please input the first num:");
int n1=12;
Console.WriteLine("Please input the second num:");
int n2=11;
Console.WriteLine("PLease input the third num:");
int n3=14;
 if(n1<n2){
  if(n1<n3){
    Console.WriteLine("The smallest value is: n1");
  }
  else{
    Console.WriteLine("The smallest value is: n3");
  }
 }
 else{
  if(n2<n3){
    Console.WriteLine("The smallest value is: n2");
  }
  else{
    Console.WriteLine("The smallest value is: n3");
  }
 }
}

    }
}
