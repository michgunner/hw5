
int[] CreateRandomIntArray(int size, int minValue, int maxValue)
{
   int[] array = new int[size];
   for(int i = 0; i < size; i++)
   {
      array[i] = new Random().Next(minValue, maxValue+1);
   }
   return array;
}

void ShowIntArray(int[] array)
{
   Console.Write("[");
   for (int i = 0; i < array.Length; i++)
   {
      Console.Write(array[i]);
      if(i == array.Length-1) Console.Write("].");
      else Console.Write(", ");
   }
}


Console.WriteLine("Please, enter size of an array: ");
int size = Convert.ToInt32(Console.ReadLine());

//Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

int CountEvenNumbers(int[] array)
{
   int count = 0;
   for(int i=0; i<array.Length; i++)
   {
      if(array[i]%2==0) count++;
   }
   return count;
}

int[] threeDigitsArray = CreateRandomIntArray(size, 100, 1000);
int result = CountEvenNumbers(threeDigitsArray);
ShowIntArray(threeDigitsArray);
Console.Write(" In this array, number of even numbers is - " + result);




//Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
/*
int OddIndexSum(int[] array)
{
   int sum = 0;
   for(int i=1; i<array.Length; i+=2)
      sum+=array[i];
   return sum;
}


Console.WriteLine("Please, enter min value of an array: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Please, enter max value of an array: ");
int max = Convert.ToInt32(Console.ReadLine());


int[] oddIndexArray = CreateRandomIntArray(size, min, max);
int sum = OddIndexSum(oddIndexArray);
ShowIntArray(oddIndexArray);
Console.Write("The sum of the numbers placed in odd cells is: " + sum);
*/


//Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
/*
double DiffMaxMin (double[] array)
{
   double max = array[0];
   double min = array[0];
   for (int i=1; i<array.Length; i++)
   {
      if(array[i] > max) max = array[i];
      else if(array[i] < min) min = array[i];
   }
   return max-min;
}

double[] CreateRandomDoubleArray(int size)
{
   double[] array = new double[size];
   var random = new Random();
   for(int i = 0; i < size; i++)
   {
      array[i] = Math.Round(random.Next(0, 100) + random.NextDouble(), 2);
   }
   return array;
}

void ShowDoubleArray(double[] array)
{
   Console.Write("[");
   for (int i = 0; i < array.Length; i++)
   {
      Console.Write(array[i]);
      if(i == array.Length-1) Console.Write("].");
      else Console.Write("; ");
   }
}

double[] arrayOfDoubles = CreateRandomDoubleArray(size, min, max);
ShowDoubleArray(arrayOfDoubles);
double
diff = DiffMaxMin(arrayOfDoubles);
Console.WriteLine("The difference between max and min is: " + diff);
*/