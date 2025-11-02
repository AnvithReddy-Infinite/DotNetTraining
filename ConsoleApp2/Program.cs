using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int employeeId;
            //string employeeName, designation;
            //decimal salary;
            //Console.WriteLine(" Enter Employee Id, Name, Designation and Salary");
            //employeeId = Convert.ToInt32(Console.ReadLine());
            //employeeName = Console.ReadLine();
            //designation = Console.ReadLine();
            //salary = Convert.ToDecimal(Console.ReadLine());
            //Console.WriteLine(" Employee Details \n ******* \n ");
            //Console.WriteLine($"Employee ID : {employeeId} \n Name : {employeeName} \n designation ={designation} \n Salary : {salary}");

            //Switch
            Console.WriteLine("Choose the opton 1.Add \n 2. Subtract \n 3.Multiplication \n 4 Divide");
            int choice = Convert.ToInt32(Console.ReadLine());
            double num1, num2;
            Console.WriteLine("Enter the First Number");
            num1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the Second Number");
            num2 = Convert.ToDouble(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.WriteLine("Addition is: " + (num1 + num2));
                    break;
                case 2:
                    Console.WriteLine("Subtraction is: " + (num1 - num2));
                    break;
                case 3:
                    Console.WriteLine("Multiplication is: " + (num1 * num2));
                    break;
                case 4:
                    if (num2 != 0)
                        Console.WriteLine("Division is: " + (num1 / num2));
                    else
                        Console.WriteLine("Error: Division by zero is not allowed.");
                    break;

            }
        }
    }
}



// If-Else:
//int age;
//Console.WriteLine("Enter the Age");
//age = Convert.ToInt32(Console.ReadLine());

//if (age < 0 || age > 100)
//    Console.WriteLine("Invalid Age");

//else
//    Console.WriteLine(" Your age is " + age + " years old.");
//Console.ReadLine();


//if -else-if else:
//int num1, num2, num3;
//num1 = Convert.ToInt32(Console.ReadLine());
//num2 = Convert.ToInt32(Console.ReadLine());
//num3 = Convert.ToInt32(Console.ReadLine());
//if (num1 >= num2 && num1 >= num3)
//    Console.WriteLine("Num1 is greatest");
//else if (num2 >= num1 && num2 >= num3)
//    Console.WriteLine("num2 is greatest");
//else
//    Console.WriteLine("num3 is greatest");
//Console.ReadLine();


//Switch: 
//Console.WriteLine("Choose the opton 1.Add \n 2. Subtract \n 3.Multiplication \n 4 Divide");
//int choice = Convert.ToInt32(Console.ReadLine());
//double num1, num2;
//Console.WriteLine("Enter the First Number");
//num1 = Convert.ToDouble(Console.ReadLine());
//Console.WriteLine("Enter the Second Number");
//num2 = Convert.ToDouble(Console.ReadLine());

//switch (choice)
//{
//    case 1:
//        Console.WriteLine("Addition is: " + (num1 + num2));
//        break;
//    case 2:
//        Console.WriteLine("Subtraction is: " + (num1 - num2));
//        break;
//    case 3:
//        Console.WriteLine("Multiplication is: " + (num1 * num2));
//        break;
//    case 4:
//        if (num2 != 0)
//            Console.WriteLine("Division is: " + (num1 / num2));
//        else
//            Console.WriteLine("Error: Division by zero is not allowed.");
//        break;
// }






//int num = 47;
//double value = num; // implicit type conversion
//Console.WriteLine($"num = {num} \nvalue = {value}");


//double pi = 3.14;
//int intPi = (int) pi; // explicit type conversion
//Console.WriteLine($"pi = {pi} \nintPi = {intPi}");
///** Converting value type to object type is Called as Boxing. 
//  Converting Object type to value type is called as Unboxing * */

//object obj = num; //Boxing
//int myval = (int)obj; //Unboxing
//Console.WriteLine($"obj = {obj} \nmyval = {myval}");

//int a = 100;
//int b = a;

//Console.WriteLine($"A value is {a} \t b value is ={b}");
//b = 899;
//Console.WriteLine($"A value is {a} \t b value is ={b}");

//string[] names = { "Anvith", "Lucky" };
//string[] copyNames = names;
//Console.WriteLine($"names [0] {names[0]} \t names[1] value is ={names[1]}"); // Value Type

//copyNames[0] = "Shyam";
//Console.WriteLine($"names [o] {names[0]} \t names[1] value is ={names[1]}"); // Reference Type










//string firstName,lastName, gender;
//int age;
//char grade;
//int score1, score2, score3;
//Console.WriteLine("Enter the FirstName, LastName, Gender, Age, Grade, score1, score2, score3");
//firstName = Console.ReadLine();
//lastName = Console.ReadLine();
//gender = Console.ReadLine();
//age = Convert.ToInt16(Console.ReadLine());
//grade = Convert.ToChar(Console.ReadLine());
//score1 = Convert.ToInt16(Console.ReadLine());
//score2 = Convert.ToInt32(Console.ReadLine());
//score3 = Convert.ToInt32(Console.ReadLine());

//Console.WriteLine(" \n Student Info: \n");
//Console.WriteLine($"Full Name = {firstName} {lastName}");
//Console.WriteLine($"Gender = {gender}\nAge = {age}\nGrade = {grade}");
//Console.WriteLine($"Score1 ={score1}\nScore2 = {score2}\nScore3 = {score3}");



