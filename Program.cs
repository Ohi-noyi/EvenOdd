// See https://aka.ms/new-console-template for more information
using System.Data;


Console.WriteLine("Enter number :");
int num1 = Convert.ToInt32(Console.ReadLine());
int a = num1 % 2;


if(a != 0){
  Console.WriteLine($" {num1} is an odd number. ");  
}
else{
     Console.WriteLine($" {num1} is an even number. ");
}
