using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Xml.Linq;

namespace HelloWold;

public static class Program
{
    public static void Main()
    {
        #region Q1
        /*Write a program that takes a number from the user then print yes if that number can be divided by 3 and 4 otherwise print no.*/

        //bool IsParsed;
        //int Number;
        //do
        //{
        //    Console.WriteLine("Please Enter Number To Check");
        //    IsParsed=int.TryParse(Console.ReadLine(), out Number);

        //} while (!IsParsed);

        //if (Number % 3 == 0 && Number % 4 == 0) Console.WriteLine("yes");
        //else Console.WriteLine("no");


        #endregion

        #region Q2

        /*Write a program that allows the user to insert an integer then print negative if it is negative number otherwise print positive.*/


        //bool IsParsed;
        //int num;
        //do
        //{
        //    Console.WriteLine("Enter Number To Check If It Negative ");
        //    IsParsed = int.TryParse(Console.ReadLine(), out num);

        //} while (!IsParsed);

        //if (num < 0) Console.WriteLine("negative ");
        //else if (num > 0) Console.WriteLine("postive ");
        //else Console.WriteLine("0");

        #endregion





        #region Q3
        /* Write a program that takes 3 integers from the user then prints the max element and the min element.*/
        // Console.WriteLine("enter three number to get min and max ");
        // int a = int.Parse(Console.ReadLine());
        //int b = int.Parse(Console.ReadLine());
        // int c = int.Parse(Console.ReadLine());

        //  int max = Math.Max(a, Math.Max(b, c));
        //int min = Math.Min(a, Math.Min(b, c));

        //        Console.WriteLine($"Max number is  : {max}");
        //      Console.WriteLine($"Min number is {min}");

        #endregion


        #region Q4
        /*- Write a program that allows the user to insert an integer number then check If a number is even or odd.*/


        //    Console.WriteLine("enter number to check if even or odd ");
        //   int number = int.Parse(Console.ReadLine());

        //  if (number % 2 == 0) Console.WriteLine(" number is even ");
        //  else if (number % 2 != 0) Console.WriteLine("number is odd ");

        #endregion



        #region Q5
        /*Write a program that takes character from the user then if it is a vowel chars (a,e,I,o,u) then print (vowel) otherwise print (consonant).*/

        //   Console.WriteLine(" enter char to check if its a vowel ");
        //  string x = Console.ReadLine();

        // if (x == "a" || x == "e" || x == "I" || x == "o" || x == "u") Console.WriteLine(" char is a vowel ");
        // else Console.WriteLine(" not a vowel char");

        #endregion


        #region Q6
        /* Write a program that allows the user to insert an integer then print all numbers between 1 to that number.*/




        //bool IsParsed;
        //int num;
        //do
        //{
        //    Console.WriteLine(" Enter number to print from 1 ");
        //    IsParsed = int.TryParse(Console.ReadLine(), out num);

        //} while (!IsParsed);

        //for (int i = 1; i <= num; i++)
        //{
        //    Console.WriteLine(i);
        //}
        #endregion



        #region Q7
        /*Write a program that allows the user to insert an integer then 
  print a multiplication table up to 12.
  */

        //        Console.WriteLine(" enter  number to print multiplacation table ");

        //        int number = int.Parse(Console.ReadLine());

        //        for (int i = 1; i <= 12; i++)
        //        {

        //            Console.WriteLine(i * number);
        //      }

        #endregion



        #region Q8
        /*- Write a program that allows to user to insert number then print all even numbers between 1 to this number*/
        //        Console.WriteLine(" please  enter number ");
        //      int number = int.Parse(Console.ReadLine());

        //        while (number >= 1)
        //      {
        //        if (number % 2 == 0) { Console.WriteLine(number); }
        //      /      number--;


        //        } 
        #endregion

        #region Q9

        /*Write a program that takes two integers then prints the power.*/
        //Console.WriteLine("Enter First Number Base ");
        //int n1=int.Parse(Console.ReadLine());
        //Console.WriteLine("Enter First Number ");
        //int Pow=int.Parse(Console.ReadLine());
        //// 4^3=4*4*4=64
        //int result = 1;
        //while (Pow > 0)
        //{
        //    result *= n1;
        //    Pow--;

        //}
        //Console.WriteLine(result);


        #endregion


        #region Q10

        /*Write a program to enter marks of five subjects and calculate total, average and percentage.*/
        //Console.WriteLine(" enter degreas of five subjects :");
        //int a = int.Parse(Console.ReadLine());
        //int b = int.Parse(Console.ReadLine());
        //int c = int.Parse(Console.ReadLine());
        //int d = int.Parse(Console.ReadLine());
        //int e = int.Parse(Console.ReadLine());

        //int sum = a + b + c + d + e;
        //Console.WriteLine($"the  avg is {sum / 5}");

        #endregion



        #region Q11
        /* Write a program to input the month number and print the number of days in that month.*/
        //Console.WriteLine(" enter month number to get its days ");
        //int month = int.Parse(Console.ReadLine());
        //if(month ==1 || month==3 || month==5 || month==7 || month==8 || month==10 || month==12)
        //{
        //    Console.WriteLine("31 days");
        //}
        //else if (month == 4 || month == 6 || month == 9 || month == 11)
        //{
        //    Console.WriteLine("30 days");
        //}
        //else if (month == 2)
        //{
        //    Console.WriteLine("28 or 29 days");
        //}
        //else
        //{
        //    Console.WriteLine("invalid month number");
        //}

        #endregion


        #region Q12
        /*Write a program to create a Simple Calculator.*/
        //Console.WriteLine(" enter first number ");
        //int a = int.Parse(Console.ReadLine());
        //Console.WriteLine(" enter second number ");
        //int b = int.Parse(Console.ReadLine());
        //Console.WriteLine(" enter the operation + , - , * , / ");
        //string op = Console.ReadLine();
        //int result = 0;
        //switch (op)
        //{
        //    case "+":
        //        result = a + b;
        //        Console.WriteLine($"the result is {result}");
        //        break;
        //    case "-":
        //        result = a - b;
        //        Console.WriteLine($"the result is {result}");
        //        break;
        //    case "*":
        //        result = a * b;
        //        Console.WriteLine($"the result is {result}");
        //        break;
        //    case "/":
        //        if (b != 0)
        //        {
        //            result = a / b;
        //            Console.WriteLine($"the result is {result}");
        //        }
        //        else
        //        {
        //            Console.WriteLine("Error: Division by zero is not allowed.");
        //            return;
        //        }
        //        break;
        //    default:
        //        Console.WriteLine("Invalid operation");
        //        return;
        //}

        #endregion


        #region Q13
        /*13- Write a program to allow the user to enter a string and print the REVERSE of it.*/
        //Console.WriteLine(" enter a string to reverse it ");
        //string str = Console.ReadLine();
        //for (int i = str.Length - 1; i >= 0; i--)
        //{
        //    Console.Write(str[i]);
        //} 
        #endregion


        #region Q14

        /*14- Write a program to allow the user to enter int and print the REVERSED of it.*/
        //Console.WriteLine("enter number to reverse : ");
        //int number = int.Parse(Console.ReadLine());
        //int reversedNumber = 0;
        //while (number != 0)
        //{
        //    int digit = number % 10;
        //    reversedNumber = reversedNumber * 10 + digit;
        //    number /= 10;
        //}
        //Console.WriteLine($"Reversed number is {reversedNumber} ");


        #endregion




        #region Q15
        /*15- Write a program in C# Sharp to find prime numbers within a range of numbers.*/
        //Console.WriteLine(" enter two numbers to find prime numbers in range ");
        //int start = int.Parse(Console.ReadLine());
        //int end = int.Parse(Console.ReadLine());
        //bool isPrime = true;
        //for(int num = start; num <= end; num++)
        //{
        //    if (num <= 1) continue; // Skip numbers less than or equal to 1
        //    isPrime = true;
        //    for (int i = 2; i <= Math.Sqrt(num); i++)
        //    {
        //        if (num % i == 0)
        //        {
        //            isPrime = false;
        //            break;
        //        }
        //    }
        //    if (isPrime)
        //    {
        //        Console.WriteLine(num);
        //    }
        //}

        #endregion



        //16//  ====> idk 

        #region Q16
        /*16- . Write a program in C# Sharp to convert a decimal number into binary without using an array.
      Test Data :
      Enter a number to convert : 25
      Expected Output :
      The Binary of 25 is 11001.
      */


        //Console.WriteLine("please Enter the number ");
        //int  number = int.Parse(Console.ReadLine());
        //// حفظ باقي القسمة 
        //// قسمة الرقم علي 2 
        //StringBuilder stringBuilder = new StringBuilder();
        //while (number > 0)
        //{
        //    stringBuilder.Insert(0,number%2);
        //    number /=2;
        //}
        //Console.WriteLine(stringBuilder.ToString());



        #endregion




        //17//  determie if points lies in single line 
        //Console.Write("Enter x1: ");
        //double x1 = double.Parse(Console.ReadLine());
        //Console.Write("Enter y1: ");
        //double y1 = double.Parse(Console.ReadLine());

        //Console.Write("Enter x2: ");
        //double x2 = double.Parse(Console.ReadLine());
        //Console.Write("Enter y2: ");
        //double y2 = double.Parse(Console.ReadLine());

        //Console.Write("Enter x3: ");
        //double x3 = double.Parse(Console.ReadLine());
        //Console.Write("Enter y3: ");
        //double y3 = double.Parse(Console.ReadLine());

        //double result = (x2 - x1) * (y3 - y1) - (y2 - y1) * (x3 - x1);

        //if (result == 0)
        //    Console.WriteLine("The points are on the same straight line.");
        //else
        //    Console.WriteLine("The points are NOT collinear.");






        //18//  company 
        //Console.Write("Enter time taken (in hours): ");
        //double time = double.Parse(Console.ReadLine());

        //if (time >= 2 && time <= 3)
        //    Console.WriteLine("The worker is highly efficient.");
        //else if (time > 3 && time <= 4)
        //    Console.WriteLine("The worker should increase their speed.");
        //else if (time > 4 && time <= 5)
        //    Console.WriteLine("The worker needs training to improve speed.");
        //else if (time > 5)
        //    Console.WriteLine("The worker should leave the company.");
        //else
        //    Console.WriteLine("Invalid input! Time cannot be less than 2 hours.");



        //19 // identity matrix 
        //Console.Write("Enter size of identity matrix (n): ");
        //int n = int.Parse(Console.ReadLine());

        //for (int i = 0; i < n; i++)  
        //{
        //    for (int j = 0; j < n; j++)  
        //    {
        //        if (i == j)
        //            Console.Write("1 ");
        //        else
        //            Console.Write("0 ");
        //    }
        //    Console.WriteLine();
        //}



        //20//  sum array 
        //Console.Write("Enter number of elements: ");
        //int n = int.Parse(Console.ReadLine());

        //int[] arr = new int[n];
        //int sum = 0;

        //Console.WriteLine("Enter the elements:");

        //for (int i = 0; i < n; i++)
        //{
        //    Console.Write("Element[{0}]: ", i);
        //    arr[i] = int.Parse(Console.ReadLine());
        //    sum += arr[i];
        //}

        //Console.WriteLine($"Sum of all elements = {sum}");



        #region Q21

        /*- Write a program in C# Sharp to merge two arrays of the same size sorted in ascending order.*/

        //int[] arr1 = { 7, 5, 1 };
        //int[] arr2 = { 9, 3, 8 };
        //List<int> list = new List<int>();
        //for(int i = 0; i < arr1.Length; i++)
        //{
        //    list.Add(arr1[i]);
        //    list.Add(arr2[i]);
        //}
        //list.Sort();
        //foreach(var result in list)
        //{
        //    Console.WriteLine(result);
        //}
        //////////////////////////////////////////
        ///



        //int[] arr1 = { 7, 5, 1 };
        //int[] arr2 = { 9, 3, 8 };
        //int[] arr3 = new int[arr1.Length+arr2.Length];
        //int a1=0, a2=0, a3=0;

        //while(a1 < arr1.Length && a2 < arr2.Length)
        //{
        //    if (arr1[a1] < arr2[a2])
        //    {
        //        arr3[a3++]=arr1[a1++];
        //    }
        //    else
        //    {
        //        arr3[a3++] = arr2[a2++];
        //    }


        //    while (a1 < arr1.Length) arr3[a3++] = arr1[a1++]; // for remaining numbers in arr1
        //    while (a2 < arr2.Length) arr3[a3++] = arr2[a2++]; // for remaining numbers in arr2

        //    Array.Sort(arr3);

        //    foreach (int i in arr3)
        //    {
        //        Console.WriteLine(i);
        //    }

        //} 
        #endregion





        //22//  count element 
        //Console.Write("Enter number of elements: ");
        //int n = int.Parse(Console.ReadLine());

        //int[] arr = new int[n];
        //int[] freq = new int[n];
        //int visited = -1;

        //Console.WriteLine("Enter the elements:");
        //for (int i = 0; i < n; i++)
        //{
        //    Console.Write("Element[{0}]: ", i);
        //    arr[i] = int.Parse(Console.ReadLine());
        //}

        //for (int i = 0; i < n; i++)
        //{
        //    int count = 1;
        //    for (int j = i + 1; j < n; j++)
        //    {
        //        if (arr[i] == arr[j])
        //        {
        //            count++;
        //            freq[j] = visited;
        //        }
        //    }
        //    if (freq[i] != visited)
        //        freq[i] = count;
        //}

        //Console.WriteLine("\nFrequency of each element:");
        //for (int i = 0; i < n; i++)
        //{
        //    if (freq[i] != visited)
        //        Console.WriteLine(arr[i] + " occurs " + freq[i] + " time(s)");
        //}






        //23// find min and max in array
        //Console.Write("Enter number of elements: ");
        //int n = int.Parse(Console.ReadLine());

        //int[] arr = new int[n];

        //Console.WriteLine("Enter the elements:");
        //for (int i = 0; i < n; i++)
        //{
        //    Console.Write("Element[{0}]: ", i);
        //    arr[i] = int.Parse(Console.ReadLine());
        //}

        //int max = arr[0];
        //int min = arr[0];

        //for (int i = 1; i < n; i++)
        //{
        //    if (arr[i] > max)
        //        max = arr[i];
        //    if (arr[i] < min)
        //        min = arr[i];
        //}

        //Console.WriteLine($"\nMaximum element ={max} " ;
        //Console.WriteLine($"Minimum element = {min}" );





        //24//  second largest element in array
        //Console.Write("Enter number of elements: ");
        //int n = int.Parse(Console.ReadLine());

        //int[] arr = new int[n];

        //Console.WriteLine("Enter the elements:");
        //for (int i = 0; i < n; i++)
        //{
        //    Console.Write("Element[{0}]: ", i);
        //    arr[i] = int.Parse(Console.ReadLine());
        //}

        //int first = int.MinValue;
        //int second = int.MinValue;

        //for (int i = 0; i < n; i++)
        //{
        //    if (arr[i] > first)
        //    {
        //        second = first;
        //        first = arr[i];
        //    }
        //    else if (arr[i] > second && arr[i] != first)
        //    {
        //        second = arr[i];
        //    }
        //}

        //if (second == int.MinValue)
        //    Console.WriteLine("There is no second largest element (all elements are equal).");
        //else
        //    Console.WriteLine($"Second largest element ={second} ");


        #region Q25

        /*-. Consider an Array of Integer values with size N, having values as    
         in this Example

        7	   0	0	0	0	5	6	7	5	0	7	5	3

        write a program find the longest distance between Two equal cells. In this example. The distance is measured by the number Of cells- for example, the distance between the first and the fourth cell is 2 (cell 2 and cell 3).

        In the example above, the longest distance is between the first 7 and the
        10th 7, with a distance of 8 cells, i.e. the number of cells between the 1st
        And the 10th 7s.

        Note:
        - Array values will be taken from the user
        - If you have input like 1111111 then the distance is the number of
        Cells between the first and the last cell.
        */

        //    int[] arr = { 7, 0, 0, 0, 0, 5, 6, 7, 5, 7, 5, 3 };
        //int[] arr = { 1, 1, 1, 1, 1, 1, 1, 1,1 };

        //int MaxResult = 0;
        //for (int i = 0; i < arr.Length; i++)
        //{
        //    for(int j = arr.Length - 1; j >= 0; j--)
        //    {
        //        if (arr[i] == arr[j])
        //        {
        //           int  result = j - i-1;
        //            MaxResult = Math.Max(result, MaxResult);
        //            break;
        //        }



        //    }

        //}
        //Console.WriteLine(MaxResult);


        #endregion


        #region Q26
        /*  Given a list of space separated words, reverse the order of the words.

        Input: this is a test       Output: test a is this
        Input: all your base        Output: base your all
        Input: Word Output: Word
        Note : 
        Check the Split Function(Member in String Class) Output will be a Single Console.WriteLine Statement

        */

        //Console.WriteLine("Enter the words to reverse : ");
        //string input = Console.ReadLine();
        //string[] words = input.Split(' ');
        //Array.Reverse(words);
        //Console.WriteLine(string.Join(" ", words));

        #endregion


        #region Q27
        /* 27 - Write a Program to Print One Dimensional Array in Reverse Order*/

        //int[] numbers = { 10, 20, 30, 40, 50 };
        //Array.Reverse(numbers);
        //foreach(int i in numbers)
        //{
        //    Console.WriteLine(i);
        //}


        #endregion



    }
}