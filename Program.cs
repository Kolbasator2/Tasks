//Task 2
//
// Console.Write("Input number a: ");
// int a = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input number b: ");
// int b = Convert.ToInt32(Console.ReadLine());
// int max = a;
// if(a < b)
// {
//     max = b;
// }
// Console.WriteLine($"Max = {max}");
//
//Task 4
//
// Console.Write("Input number a: ");
// int a = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input number b: ");
// int b = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input number c: ");
// int c = Convert.ToInt32(Console.ReadLine());
// int max = a;
// if(a < b)
// {
//     max = b;
// }
// if(a < c)
// {
//     max = c;
// }
// Console.WriteLine(max);
//
//Task 6
//
// Console.Write("Input number: ");
// int number = Convert.ToInt32(Console.ReadLine());
// bool isEven = number % 2 == 0;
// if(isEven)
// {
//     Console.WriteLine("Yes");
// }
// else
// {
//     Console.WriteLine("No");
// }
//
//Task 8
//
// Console.Write("Input number: ");
// int number = Convert.ToInt32(Console.ReadLine());
// int current = 1;
// while(current <= number)
// {
//     if(current % 2 == 0)
//     {
//         Console.WriteLine(current);
//     }
//     current++;
// }
//
// Task 10
//
// Console.Write("Input number: ");
// int number = Convert.ToInt32(Console.ReadLine());
// int thirdChar = number % 10;
// int secondChar = ((number % 100) - thirdChar) / 10;
// Console.WriteLine(secondChar);
//
// Task 13
//
// Console.Write("Input number: ");
// string number = Console.ReadLine();
// if(number.Length <= 2)
// {
//     Console.WriteLine("The number is too small");
// }
// else
// {
//     Console.WriteLine(number[2]);
// }
//
// Task 13 
//
// Console.Write("Input number: ");
// int number = Convert.ToInt32(Console.ReadLine());
// if(number < 100)
// {
//     Console.WriteLine("The number is too small");
// }
// else
// {
//     int lengthOfNumber = 0;
//     int currentDigit = 1;
//     while(Math.Pow(10, lengthOfNumber) < number)
//     {
//         lengthOfNumber++;
//         currentDigit++;
//     }
//     for(int i = 0; i < lengthOfNumber; i++)
//     {
//         if(number / Math.Pow(10, i) < 1000)
//         {
//             number = Convert.ToInt32(Math.Truncate(number / Math.Pow(10, i)));
//             int result = number % 10;
//             Console.WriteLine(result);
//             break;
//         }
//     }
// }
//
// Task 15
//
// Console.Write("Input № of day: ");
// int numberOfDay = Convert.ToInt32(Console.ReadLine());
// if(numberOfDay < 0)
// {
//     Console.WriteLine("Incorrect input");
// }
// else if(numberOfDay <= 5)
// {
//     Console.WriteLine("No");
// }
// else
// {
//     Console.WriteLine("Yes");
// }