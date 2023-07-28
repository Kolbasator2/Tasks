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
//
// Task 19
//
// Console.Write("Input number: ");
// string number = Console.ReadLine();
// if(number[0] == number[4] && number[1] == number[3])
// {
//     Console.WriteLine("Yes");
// }
// else
// {
//     Console.WriteLine("No");
// }
//
// Task 21
//
// Console.Write("Input Ox coordinate of A: ");
// int OxCoordinateOfA = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input Oy coordinate of A: ");
// int OyCoordinateOfA = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input Oz coordinate of A: ");
// int OzCoordinateOfA = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input Ox coordinate of B: ");
// int OxCoordinateOfB = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input Oy coordinate of B: ");
// int OyCoordinateOfB = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input Oz coordinate of B: ");
// int OzCoordinateOfB = Convert.ToInt32(Console.ReadLine());
// double distance = Math.Sqrt(Math.Pow(OxCoordinateOfA - OxCoordinateOfB, 2) + Math.Pow(OyCoordinateOfA - OyCoordinateOfB, 2) + Math.Pow(OzCoordinateOfA - OzCoordinateOfB, 2));
// Console.WriteLine(distance);
//
// Task 23
//
// Console.Write("Input number: ");
// int number = Convert.ToInt32(Console.ReadLine());
// for(int i = 1; i <= number; i++)
// {
//     Console.Write($"{Math.Pow(i, 3)}, ");
// }
//
// Task 25
//
// Console.Write("Input number: ");
// int number = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input degree: ");
// int degree = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine(Math.Pow(number, degree));
//
// Task 27
//
// Console.Write("Input number: ");
// string number = Console.ReadLine();
// double sum = 0;
// for(int i = 0; i < number.Length; i++)
// {
//     sum += Char.GetNumericValue(number[i]);
// }
// Console.WriteLine(sum);
//
// Task 29
//
// int[] numbers = new int[8];
// for(int i = 0; i < numbers.Length; i++)
// {
//     numbers[i] = new Random().Next(-100, 99);
// }
// Console.WriteLine($"[{string.Join(", ", numbers)}]");
//
// Task 34
//
// int[] generateArray(int length)
// {
//     int[] result = new int[length];
//     for(int i = 0; i < length; i++)
//     {
//         result[i] = new Random().Next(101, 999);
//     }
//     return result;
// }
// int findNumberOfEvenElements(int[] array)
// {
//     int result = 0;
//     for(int i = 0; i < array.Length; i++)
//     {
//         if(array[i] % 2 == 0)
//         {
//             result++;
//         }
//     }
//     return result;
// }
// Console.Write("Input length of array: ");
// int length = Convert.ToInt32(Console.ReadLine());
// int[] array = generateArray(length);
// Console.WriteLine($"[{string.Join(", ", array)}]");
// Console.WriteLine($"Number of even elements equals to {findNumberOfEvenElements(array)}");
//
// Task 36 
//
// int[] generateArray(int length)
// {
//     int[] result = new int[length];
//     for(int i = 0; i < length; i++)
//     {
//         result[i] = new Random().Next(-100, 99);
//     }
//     return result;
// }
// int findSumOfElementsWithOddIndexes(int[] array)
// {
//     int result = 0;
//     for(int i = 1; i < array.Length; i+=2)
//     {
//         result += array[i];
//     }
//     return result;
// }
// Console.Write("Input length of array: ");
// int length = Convert.ToInt32(Console.ReadLine());
// int[] array = generateArray(length);
// Console.WriteLine($"[{string.Join(", ", array)}]");
// Console.WriteLine($"Sum of elements with odd indexes equals to {findSumOfElementsWithOddIndexes(array)}");
//
// Task 38
//
// double[] generateArray(int length)
// {
//     double[] result = new double[length];
//     for(int i = 0; i < length; i++)
//     {
//         result[i] = new Random().Next(-100, 99) * Math.PI;
//     }
//     return result;
// }
// double getMaxElement(double[] array)
// {
//     double max = array[0];
//     for(int i = 0; i < array.Length; i++)
//     {
//         if(max <= array[i])
//         {
//             max = array[i];
//         }
//     }
//     return max;
// }
// double getMinElement(double[] array)
// {
//     double min = array[0];
//     for(int i = 0; i < array.Length; i++)
//     {
//         if(min >= array[i])
//         {
//             min = array[i];
//         }
//     }
//     return min;
// }
// Console.Write("Input length of array: ");
// int length = Convert.ToInt32(Console.ReadLine());
// double[] array = generateArray(length);
// Console.WriteLine($"[{string.Join(", ", array)}]");
// Console.WriteLine($"Difference between max and min elements equals to {getMaxElement(array) - getMinElement(array)}");