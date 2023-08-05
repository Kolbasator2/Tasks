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
//
// Task 41
//
// Console.Write("Input numbers: ");
// int[] numbers = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
// int amountOfPositiveNumbers = 0;
// for(int i = 0; i < numbers.Length; i++)
// {
//     if(numbers[i] >= 0)
//     {
//         amountOfPositiveNumbers++;
//     }
// }
// Console.WriteLine(amountOfPositiveNumbers);
//
// Task 43
//
// Console.Write("Input k1: ");
// double k1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input b1: ");
// double b1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input k2: ");
// double k2 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input b2: ");
// double b2 = Convert.ToInt32(Console.ReadLine());
// double x = (b2 - b1) / (k1 - k2);
// double y = k1 * x + b1;
// Console.WriteLine($"({x}, {y})");
//
// Task 47
//
// double[,] generateMatrixWithRealElements(int m, int n)
// {
//     double[,] matrix = new double[m, n];
//     for(int i = 0; i < m; i++)
//     {
//         for(int j = 0; j< n; j++)
//         {
//             matrix[i, j] = new Random().Next(-10, 9) * Math.PI;
//         }
//     }
//     return matrix;
// }
// void showMatrix(double[,] matrix, int m, int n)
// {
//     for(int i = 0; i < m; i++)
//     {
//         for(int j = 0; j < n; j++)
//         {
//             Console.Write(matrix[i, j] + "\t");
//         }
//         Console.WriteLine("\n");
//     }
//     Console.WriteLine("\n\n");
// }
// Console.Write("Input m: ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input n: ");
// int n = Convert.ToInt32(Console.ReadLine());
// showMatrix(generateMatrixWithRealElements(m, n), m, n);
//
// Task 50
//
// int[,] generateMatrix(int m, int n)
// {
//     int[,] matrix = new int[m, n];
//     for(int i = 0; i < m; i++)
//     {
//         for(int j = 0; j< n; j++)
//         {
//             matrix[i, j] = new Random().Next(-0, 9);
//         }
//     }
//     return matrix;
// }
// int checkElement(int[,] matrix, int m, int n, int i, int j)
// {
//     if(m <= i || n <= j)
//     {
//         throw new Exception("There is no element with such indexes!");
//     } 
//     return matrix[i, j];
// }
// void showMatrix(int[,] matrix, int m, int n)
// {
//     for(int i = 0; i < m; i++)
//     {
//         for(int j = 0; j < n; j++)
//         {
//             Console.Write(matrix[i, j] + "\t");
//         }
//         Console.WriteLine("\n");
//     }
//     Console.WriteLine("\n\n");
// }
// Console.Write("Input m: ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input n: ");
// int n = Convert.ToInt32(Console.ReadLine());
// int[,] matrix = generateMatrix(m, n);
// showMatrix(matrix, m, n);
// Console.Write("Input i: ");
// int i = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input j: ");
// int j = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine(checkElement(matrix, m, n, i, j));
//
// Task 52
//
// int[,] generateMatrix(int m, int n)
// {
//     int[,] matrix = new int[m, n];
//     for(int i = 0; i < m; i++)
//     {
//         for(int j = 0; j < n; j++)
//         {
//             matrix[i, j] = new Random().Next(0, 9);
//         }
//     }
//     return matrix;
// }
// double[] findMeanValuesInRows(int[,] matrix, int m, int n)
// {
//     double[] meanValues = new double[m];
//     for(int i = 0; i < m; i++)
//     {
//         double sum = 0;
//         for(int j = 0; j < n; j++)
//         {
//             sum += matrix[i, j];
//         }
//         meanValues[i] = sum / n;
//     }
//     return meanValues;
// }
// void showMatrix(int[,] matrix, int m, int n)
// {
//     for(int i = 0; i < m; i++)
//     {
//         for(int j = 0; j < n; j++)
//         {
//             Console.Write(matrix[i, j] + "\t");
//         }
//         Console.WriteLine("\n");
//     }
//     Console.WriteLine("\n\n");
// }
// Console.Write("Input m: ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input n: ");
// int n = Convert.ToInt32(Console.ReadLine());
// int[,] matrix = generateMatrix(m, n);
// showMatrix(matrix, m, n);
// Console.WriteLine($"Mean values in rows are {string.Join(", ", findMeanValuesInRows(matrix, m, n))}");
//
// Task 54
//
// int[,] generateMatrix(int m, int n)
// {
//     int[,] matrix = new int[m, n];
//     for(int i = 0; i < m; i++)
//     {
//         for(int j = 0; j < n; j++)
//         {
//             matrix[i, j] = new Random().Next(0, 9);
//         }
//     }
//     return matrix;
// }
// void sortRowsOfMatrix(int[,] matrix, int m, int n)
// {
//     for(int i = 0; i < m; i++)
//     {
//         for(int j = 0; j < n - 1; j++)
//         {
//             if(matrix[i, j] > matrix[i, j + 1])
//             {
//                 swapNeighborsInRow(matrix, m, n, i, j);
//             }
//         }
//     }
// }
// void swapNeighborsInRow(int[,] matrix, int m, int n, int i, int j)
// {
//     int temp = matrix[i, j];
//     matrix[i, j] = matrix[i, j + 1];
//     matrix[i, j + 1] = temp;
// }
// void showMatrix(int[,] matrix, int m, int n)
// {
//     Console.WriteLine("\n\n");
//     for(int i = 0; i < m; i++)
//     {
//         for(int j = 0; j < n; j++)
//         {
//             Console.Write(matrix[i, j] + "\t");
//         }
//         Console.WriteLine("\n");
//     }
//     Console.WriteLine("\n");
// }
// Console.Write("Input m: ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input n: ");
// int n = Convert.ToInt32(Console.ReadLine());
// int[,] matrix = generateMatrix(m, n);
// showMatrix(matrix, m, n);
// sortRowsOfMatrix(matrix, m, n);
// showMatrix(matrix, m, n);
//
// Task 56
//
// int[,] generateMatrix(int m, int n)
// {
//     int[,] matrix = new int[m, n];
//     for(int i = 0; i < m; i++)
//     {
//         for(int j = 0; j < n; j++)
//         {
//             matrix[i, j] = new Random().Next(0, 9);
//         }
//     }
//     return matrix;
// }
// int findIndexOfRowWithMinSumOfElements(int[,] matrix, int m, int n)
// {
//     int[] sumsOfElementsInRows = new int[n];
//     for(int i = 0; i < m; i++)
//     {
//         for(int j = 0; j < n; j++)
//         {
//             sumsOfElementsInRows[i] += matrix[i, j];
//         }
//     }
//     return findIndexOfMinElementInArray(sumsOfElementsInRows);
// }
// int findIndexOfMinElementInArray(int[] array)
// {
//     int indexOfMinElement = 0;
//     for(int i = 0; i < array.Length; i++)
//     {
//         if(array[i] < array[indexOfMinElement])
//         {
//             indexOfMinElement = i;
//         }
//     }
//     return indexOfMinElement;
// }
// void showMatrix(int[,] matrix, int m, int n)
// {
//     Console.WriteLine("\n\n");
//     for(int i = 0; i < m; i++)
//     {
//         for(int j = 0; j < n; j++)
//         {
//             Console.Write(matrix[i, j] + "\t");
//         }
//         Console.WriteLine("\n");
//     }
//     Console.WriteLine("\n");
// }
// Console.Write("Input m: ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input n: ");
// int n = Convert.ToInt32(Console.ReadLine());
// int[,] matrix = generateMatrix(m, n);
// showMatrix(matrix, m, n);
// Console.WriteLine($"The index of row with min sum of elements is {findIndexOfRowWithMinSumOfElements(matrix, m, n)}");
//
// Task 58
//
// int[,] generateMatrix(int m, int n)
// {
//     int[,] matrix = new int[m, n];
//     for(int i = 0; i < m; i++)
//     {
//         for(int j = 0; j < n; j++)
//         {
//             matrix[i, j] = new Random().Next(0, 9);
//         }
//     }
//     return matrix;
// }
// int[,] findProductOfMatrices(int[,] firstMatrix, int[,] secondMatrix, int firstM, int firstN, int secondM, int secondN)
// {
//     if(firstN != secondM)
//     {
//         throw new Exception("Exception: cannot find product of matrices!");
//         return null;
//     }
//     else
//     {
//         int[,] product = new int[firstM, secondN];
//         for(int i = 0; i < firstM; i++)
//         {
//             for(int j = 0; j < secondN; j++)
//             {
//                 int sum = 0;
//                 for(int r = 0; r < firstN; r++)
//                 {
//                     sum += firstMatrix[i, r] * secondMatrix[r, j];
//                 }
//                 product[i, j] = sum;
//             }
//         }
//         return product;
//     }

// }
// void showMatrix(int[,] matrix, int m, int n)
// {
//     Console.WriteLine("\n\n");
//     for(int i = 0; i < m; i++)
//     {
//         for(int j = 0; j < n; j++)
//         {
//             Console.Write(matrix[i, j] + "\t");
//         }
//         Console.WriteLine("\n");
//     }
//     Console.WriteLine("\n");
// }
// Console.Write("Input first m: ");
// int firstM = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input first n: ");
// int firstN = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input second m: ");
// int secondM = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input second n: ");
// int secondN = Convert.ToInt32(Console.ReadLine());
// int[,] firstMatrix = generateMatrix(firstM, firstN);
// int[,] secondMatrix = generateMatrix(secondM, secondN);
// showMatrix(firstMatrix, firstM, firstN);
// showMatrix(secondMatrix, secondM, secondN);
// showMatrix(findProductOfMatrices(firstMatrix, secondMatrix, firstM, firstN, secondM, secondN), firstM, secondN);
//
// Task 60
//
// int[,,] generateArray(int m, int n, int o)
// {
//     int[,,] result = new int[m, n, o];
//     for(int i = 0; i < m; i++)
//     {
//         for(int j = 0; j < n; j++)
//         {
//             for(int k = 0; k < o; k++)
//             {
//                 result[i, j, k] = new Random().Next(10, 40);
//             }
//         }
//     }
//     return result;
// }
// void showArray(int[,,] array, int m, int n, int o)
// {
//     Console.WriteLine("\n\n");
//     for(int i = 0; i < m; i++)
//     {
//         for(int j = 0; j < n; j++)
//         {
//             for(int k = 0; k < o; k++)
//             {
//                 Console.Write($"{array[i, j, k]}({i}, {j}, {k}), ");
//             }
//             Console.WriteLine("\n");
//         }
//     }
//     Console.WriteLine("\n\n");
// }
// Console.Write("Input m: ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input n: ");
// int n = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input o: ");
// int o = Convert.ToInt32(Console.ReadLine());
// showArray(generateArray(m, n, o), m, n, o);
//
// Task 62
//
// int[,] generateMatrix()
// {
//     int[,] matrix = new int[4, 4];
//     matrix[0, 0] = 1;
//     matrix[0, 1] = 2;
//     matrix[0, 2] = 3;
//     matrix[0, 3] = 4;
//     matrix[1, 3] = 5;
//     matrix[2, 3] = 6;
//     matrix[3, 3] = 7;
//     matrix[3, 2] = 8;
//     matrix[3, 1] = 9;
//     matrix[3, 0] = 10;
//     matrix[2, 0] = 11;
//     matrix[1, 0] = 12;
//     matrix[1, 1] = 13;
//     matrix[1, 2] = 14;
//     matrix[2, 2] = 15;
//     matrix[2, 1] = 16;
//     return matrix;
// }
// void showMatrix(int[,] matrix)
// {
//     Console.WriteLine("\n\n");
//     for(int i = 0; i < 4; i++)
//     {
//         for(int j = 0; j < 4; j++)
//         {
//             Console.Write($"{matrix[i, j]}\t");
//         }
//         Console.WriteLine("\n");
//     }
//     Console.WriteLine("\n\n");
// }
// showMatrix(generateMatrix());