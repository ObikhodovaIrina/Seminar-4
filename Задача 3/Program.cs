//Напишите программу, которая задаёт массив из некоторого количества элементов 
// и выводит их на экран с помощью функций. (можно спрашивать количество вводимых 
// элементов и вводить все значения с клавиатуры)
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

Console.Write("Введите числа через запятую: ");
string _numbers = Console.ReadLine();
string[] _arrayNumbers = _numbers.Split(new char[] {','});

for(int i = 0; i < _arrayNumbers.Length; i++)
{
    Console.Write($"{_arrayNumbers[i]} ");
}
Console.WriteLine();