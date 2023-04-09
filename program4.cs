//Fourth exercise
Console.WriteLine("enter the size of your array: ");
int size = int.Parse(Console.ReadLine());

int[] array = new int[size];

Console.WriteLine("Now write the elements of your array: ");

for (int i = 0; i < size; i++)
{
    array[i] = int.Parse(Console.ReadLine());
}

Dictionary<int, int> elementCount = new Dictionary<int, int>();

foreach (int num in array)
{
    if (elementCount.ContainsKey(num))
    {
        elementCount[num]++;
    }
    else
    {
        elementCount[num] = 1;
    }
}

int maxCount = 0;
int maxValue = 0;

foreach (KeyValuePair<int, int> entry in elementCount)
{
    if (entry.Value > maxCount)
    {
        maxCount = entry.Value;
        maxValue = entry.Key;
    }
}

Console.WriteLine($"The element that appears most often is {maxValue} and it appears {maxCount} times");
