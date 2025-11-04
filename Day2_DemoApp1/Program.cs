using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2_DemoApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {  

            Console.ReadLine();
        }
        }
}





//// single dimensional array
// array declaration and initialiaztion
//int[] numArray = new int[5] { 10, 20, 30, 40, 50 };

////array declaration
//int[] myArray2 = new int[5];
////myArray2[0] = 100;
////myArray2[1] = 120;
////myArray2[2] = 130;
////myArray2[3] = 140;
////myArray2[4] = 150;

//Console.WriteLine($"Enter {myArray2.Length} numbers:");
//// for loop
//for (int i = 0; i < myArray2.Length; i++)
//{
//    myArray2[i] = Convert.ToInt32(Console.ReadLine());
//}
//Console.WriteLine("\n Array Elements are \n --------------");
//foreach (var item in myArray2)
//{
//    Console.WriteLine(item);
//}



//// 2D array declaration and initialization
//int[,] marks = new int[2, 5] { { 60, 70, 80, 80, 90 }, { 70, 80, 80, 90, 90 } };
//Console.WriteLine($"{marks.GetLength(0)}");
//////outer loop for rows
//for (int i = 0; i < marks.GetLength(0); i++)
//{
//    //inner loop for columns
//    for (int j = 0; j < marks.GetLength(1); j++)
//    {
//        Console.Write(marks[i, j] + "\t");
//    }
//    Console.WriteLine();
//}



/// Example of Dynamic Array Size

//            int rowSize, colSize;
//Console.WriteLine("Enter the number of Students:");
//rowSize = Convert.ToInt32(Console.ReadLine());

//colSize = 5;
//int[,] StudentMarks = new int[rowSize, colSize];


//for (int i = 0; i < rowSize; i++)
//{
//    Console.WriteLine($"\nEnter the marks for Student {i + 1}:");
//    for (int j = 0; j < colSize; j++)
//    {
//        Console.Write($"Enter the marks for Subject {j + 1}: ");
//        StudentMarks[i, j] = Convert.ToInt32(Console.ReadLine());
//    }
//}

//Console.WriteLine("\nDisplaying the Marks of Students:");

//for (int i = 0; i < rowSize; i++)
//{
//    Console.WriteLine($"\nStudent {i + 1} Marks are:");
//    int totalMarks = 0;

//    for (int j = 0; j < colSize; j++)
//    {
//        Console.Write(StudentMarks[i, j] + "\t");
//        totalMarks += StudentMarks[i, j];
//    }

//    Console.WriteLine($"\nTotal Marks of Student {i + 1}: {totalMarks}");
//}



//Example for an Array with Reverse
//int[] myArray = new int[5] { 10, 20, 30, 40, 50 };
//foreach (int item in myArray)
//{
//    Console.Write(item + "\t");
//}

//Console.WriteLine(" After Reversed my Array is ");
//Array.Reverse(myArray);
//foreach (int item in myArray)
//{
//    Console.Write(item + "\t");
//}



// Jagged Array Example
// Declare the array of four elements:
//int[][] jaggedArray = new int[4][];

//// Initialize the elements:
//jaggedArray[0] = new int[2] { 7, 9 };
//jaggedArray[1] = new int[4] { 12, 42, 26, 38 };
//jaggedArray[2] = new int[6] { 3, 5, 7, 9, 11, 13 };
//jaggedArray[3] = new int[3] { 4, 6, 8 };

//// Display the array elements:
//for (int i = 0; i < jaggedArray.Length; i++)
//{
//    System.Console.Write("Element({0}): ", i + 1);

//    for (int j = 0; j < jaggedArray[i].Length; j++)
//    {
//        System.Console.Write(jaggedArray[i][j] + "\t");
//    }
//    System.Console.WriteLine();
//}


//// Jagged Array Example
//string[][] Members = new string[4][]{
//            new string[]{"Rocky", "Deva", "Rolex"},
//            new string[]{"Peter", "Sanju", "Priety", "Ronald", "Dulquer"},
//            new string[]{"Yami", "John", "Srk", "Alia", "Tim", "Shaun"},
//            new string[]{"Trump", "Modi", "Putin", "Stalin", "Musk", "Meloni", "Jeff"},
//            };
//for (int i = 0; i < Members.Length; i++)
//{
//    System.Console.Write("Name List ({0}):", i + 1);

//    for (int j = 0; j < Members[i].Length; j++)
//    {
//        System.Console.Write(Members[i][j] + "\t");
//    }
//    System.Console.WriteLine();
//}