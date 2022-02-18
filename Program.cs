// Написать программу для замены элементов массива на противоположные.

Console.Clear();

Random rnd = new Random();

Console.Write("На сколько элементов задаём массив? ");
int elem = int.Parse(Console.ReadLine());
int[] array = new int[elem];

for (int i = 0; i < elem; i++)
{
    array[i] = rnd.Next(0, 100);
    Console.Write(array[i] + "\t");
}

Console.WriteLine();
int change = 0;
for (int j = 0; j < elem/2; j++)
{
    change = array[j];
    array[j] = array[elem - j -1];
    array[elem - j - 1] = change;    
}

for(int u = 0; u < elem; u++)
{
Console.Write(array[u] + "\t");
}