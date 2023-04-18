int number = GetNumberInput("сколько чисел вы хотите проверить?");
int[] array = GetAndFillArray(number);
Console.WriteLine($"-->{CheckPositiveNumbers(array)}");


int GetNumberInput(string str = "")
{
    Console.WriteLine(str);
    string input = Console.ReadLine();
    return int.Parse(input);
}

int[] GetAndFillArray(int size)
{
    int[] array = new int[size];

for (int i = 0; i < size; i++)
{

    array[i]=GetNumberInput($"Введите {i+1}-е число: ");
}

    return array;
}

int CheckPositiveNumbers(int[] array)
{
    int count = 0;
for (int i = 0; i < array.Length; i++)
{
    if (array[i] > 0) count++;
}
    return count;
}