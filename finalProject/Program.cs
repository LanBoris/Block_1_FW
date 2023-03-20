Console.Clear();

Console.Write("Введите количество вводимых слов: ");
int size = Convert.ToInt32(Console.ReadLine());
size = CheckNumber(size);
string[] arrayOfStrings = new string[size];
string[] resultArray = new string[size];

FillArray(arrayOfStrings);
Console.Write("\n" + "Массив для обработки: ");
PrintArray(arrayOfStrings);
resultArray = CreateNewArray(arrayOfStrings);
Console.Write("Массив состоящий из элементов, длина которых меньше или равна 3 символам: ");
PrintArray(resultArray);

/// <summary>
/// Метод, который позволяет заполнить массив через консоль
/// </summary>
/// <param name="array">Массив, который надо заполнить</param>
void FillArray(string[] array)
{
  for (int i = 0; i < array.Length; i++)
  {
    Console.Write($"Введите {i+1} элемент массива: ");
    array[i] = Console.ReadLine()!;
  }
}

/// <summary>
/// Метод создающий новый массив из элементов длиной меньше или равной 3 символам
/// </summary>
/// <param name="array">Входящий массив для обработки</param>
/// <returns>Новый массив из элементов длиной меньше или равной 3 символам</returns>
string[] CreateNewArray(string[] array)
{
  int sizeOfResultArray = 0;
  for (int i = 0; i < array.Length; i++)
  {
    if (array[i].Length <= 3) sizeOfResultArray++;
  }
  string[] newArrayOfStrings = new string[sizeOfResultArray];
  int index = 0;
  for (int j = 0; j < array.Length; j++)
  {
    if (array[j].Length <= 3)
    {
      newArrayOfStrings[index] = array[j];
      index++;
    }
  }
  return newArrayOfStrings;
}

/// <summary>
/// Метод выводящий массив на экран
/// </summary>
/// <param name="array">Массив для вывода на экран</param>
void PrintArray(string[] array)
{
  Console.WriteLine($"[{String.Join(", ", array)}]" + "\n");
}

/// <summary>
/// Метод проверяющий число на положительность
/// </summary>
/// <param name="number">Число для проверки</param>
/// <returns>Положительное число</returns>
int CheckNumber(int number)
{
  while (number <=0)
  {
    Console.Write("Количество должно быть больше 0, введите новое количество: ");
    number = Convert.ToInt32(Console.ReadLine());
  }
  return number;
}