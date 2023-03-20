Console.Clear();

Console.Write("Введите количество вводимых слов: ");
int size = Convert.ToInt32(Console.ReadLine());
string[] arrayOfStrings = new string[size];


void FillArray(string[] array)
{
  for (int i = 0; i < array.Length; i++)
  {
    Console.Write($"Введите {i+1} элемент массива: ");
    array[i] = Console.ReadLine();
  }
}

FillArray(arrayOfStrings);
Console.WriteLine(String.Join(", ", arrayOfStrings));

