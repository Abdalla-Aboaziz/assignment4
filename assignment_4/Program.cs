using System;
using System.Linq;
using System.Collections.Generic;

namespace HelloWold;

public static class Program
{
    public static void Main()
    {
        //   1)PRINT yes or no 
        //Console.WriteLine("Enter number to check ");
        //int num = int.Parse(Console.ReadLine());
        //if (num % 3 == 0 && num % 4 == 0) { Console.WriteLine("yes"); }
        //else { Console.WriteLine("no"); }



        // 2 check  id negative 
        // Console.WriteLine("enter number to check if it negative ");
        //int num = int.Parse(Console.ReadLine());
        //if (num < 0) Console.WriteLine("negative ");
        // else if (num > 0) Console.WriteLine("postive ");
        // else Console.WriteLine("0");



        //3/ get min and max 
        // Console.WriteLine("enter three number to get min and max ");
        // int a = int.Parse(Console.ReadLine());
        //int b = int.Parse(Console.ReadLine());
        // int c = int.Parse(Console.ReadLine());

        //  int max = Math.Max(a, Math.Max(b, c));
        //int min = Math.Min(a, Math.Min(b, c));

        //        Console.WriteLine($"Max number is  : {max}");
        //      Console.WriteLine($"Min number is {min}");



        //4 //  check if odd or even 


        //    Console.WriteLine("enter number to check if even or odd ");
        //   int number = int.Parse(Console.ReadLine());

        //  if (number % 2 == 0) Console.WriteLine(" number is even ");
        //  else if (number % 3 == 0) Console.WriteLine("number is odd ");




        //5// check vowel chars (a,e,I,o,u)

        //   Console.WriteLine(" enter char to check if its a vowel ");
        //  string x = Console.ReadLine();

        // if (x == "a" || x == "e" || x == "I" || x == "o" || x == "u") Console.WriteLine(" char is a vowel ");
        // else Console.WriteLine(" not a vowel char");



        // 6// print all between 1 and number 

        //    Console.WriteLine(" enter number to print from 1 ");
        //int number = int.Parse(Console.ReadLine());
        // while (number >= 1)
        //{

        //   Console.WriteLine(number);
        // number--;

        //        }


        //7//     print multiplacation table  for number     

        //        Console.WriteLine(" enter  number to print multiplacation table ");

        //        int number = int.Parse(Console.ReadLine());

        //        for (int i = 1; i <= 12; i++)
        //        {

        //            Console.WriteLine(i * number);
        //      }




        //8//   print even number  to 1 
        //        Console.WriteLine(" please  enter number ");
        //      int number = int.Parse(Console.ReadLine());

        //        while (number >= 1)
        //      {
        //        if (number % 2 == 0) { Console.WriteLine(number); }
        //      /      number--;


        //        }


        //9// calc power for number 

        //            Console.WriteLine("please enter number ");
        //      int number = int.Parse(Console.ReadLine());
        //    Console.WriteLine(" please  enter the power  ");
        //  int pow = int.Parse(Console.ReadLine());
        //long result = 0;

        //        for (int i = 0; i <= pow; i++)
        //      {


        //            result += number * pow;
        //        }




        //        Console.WriteLine(result);




        //10// calc avg of five subject 
        //Console.WriteLine(" enter degreas of five subjects :");
        //int a = int.Parse(Console.ReadLine());
        //int b = int.Parse(Console.ReadLine());
        //int c = int.Parse(Console.ReadLine());
        //int d = int.Parse(Console.ReadLine());
        //int e = int.Parse(Console.ReadLine());

        //int sum = a + b + c + d + e;
        //Console.WriteLine($"the  avg is {sum / 5}");




        //  11 // input the month number and print month dayes 
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



        //12// write a program to create a Simple Calculator.
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



        //13// reverse a String
        //Console.WriteLine(" enter a string to reverse it ");
        //string str = Console.ReadLine();
        //for (int i = str.Length - 1; i >= 0; i--)
        //{
        //    Console.Write(str[i]);
        //}



        //14// reverse int number 
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






        //15//  find prime number in range
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




        //16//  ====> idk 

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




        //21//  ==>> idk

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



        //25//


    }
}