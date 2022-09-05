﻿ // Задача 34
 Console.Clear();
Console.WriteLine(" Количество чётных чисел в массиве:\n");
int[] numbers = new int[10];

void FillArray(int[] array, int min, int max){
  for (int i = 0; i<array.Length; i++ ){
    array[i] = new Random().Next(min, max);
  }
}

void WriteArray(int[] array){
    for (int i = 0; i<array.Length; i++ ){
    Console.Write(array[i] + " ");
  }
  Console.WriteLine();
}

int QuantityPositive(int[] array){
    int quantity = 0;
    for (int i = 0; i<array.Length; i++ ){
    if (array[i] % 2 == 1)
    {
      quantity++;
    }
  }
  return quantity;
}

FillArray(numbers, 100, 1000);
WriteArray(numbers);
Console.WriteLine();

int quantity = QuantityPositive(numbers);
Console.WriteLine("Количество чётных чисел в массиве: {quantity}");



// задача 36
 Console.Clear();
Console.WriteLine(" Количество чётных чисел в массиве:\n");
int[] numbers = new int[10];

void FillArray(int[] array, int min, int max){
  for (int i = 0; i<array.Length; i++ ){
    array[i] = new Random().Next(min, max);
  }
}

void WriteArray(int[] array){
    for (int i = 0; i<array.Length; i++ ){
    Console.Write(array[i] + " ");
  }
  Console.WriteLine();
}

int QuantityPositive(int[] array){
    int quantity = 0;
    for (int i = 0; i<array.Length; i++ ){
    if (array[i] % 2 == 1)
    {
      quantity++;
    }
  }
  return quantity;
}

FillArray(numbers, 100, 1000);
WriteArray(numbers);
Console.WriteLine();

int quantity = QuantityPositive(numbers);
Console.WriteLine("Количество чётных чисел в массиве: {quantity}");


//Задача 38
Console.WriteLine("Найдите разницу между максимальным и минимальным элементов массива из вещественных чисел:\n");

double[] arrayRealNumbers = new double[10];
  for (int i = 0; i < arrayRealNumbers.Length; i++ )
  {
    arrayRealNumbers[i] = new Random().Next(1, 10);
    Console.Write(arrayRealNumbers[i] + " ");
  }

double maxNumber = arrayRealNumbers[0];
double minNumber = arrayRealNumbers[0];

  for (int i = 1; i < arrayRealNumbers.Length; i++)
  {
    if (maxNumber < arrayRealNumbers[i])
    {
      maxNumber = arrayRealNumbers[i];
    }
        if (minNumber > arrayRealNumbers[i])
    {
      minNumber = arrayRealNumbers[i];
    }
  }

  double decision = maxNumber - minNumber;

  Console.WriteLine($"\nразница между между максимальным ({maxNumber}) и минимальным({minNumber}) элементами: {decision}");