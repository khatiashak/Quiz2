//First exercise

Console.WriteLine("enter the size of an array: ");
int size = int.Parse(Console.ReadLine());

int[] array = new int[size];

Console.WriteLine("Now write the elements of your array: ");

for (int i = 0; i < size; i++)
{
    array[i] = int.Parse(Console.ReadLine());
}


int sumOfOdds = 0;
int productOfEvens = 1;
Dictionary<int, int> elementCounts = new Dictionary<int, int>();

foreach (int num in array)
{
    if (num % 2 == 0)
    {
        productOfEvens *= num;
    }
    else
    {
        sumOfOdds += num;
    }

    if (elementCounts.ContainsKey(num))
    {
        elementCounts[num]++;
    }
    else
    {
        elementCounts[num] = 1;
    }
}

Console.WriteLine($"Sum of odd numbers in this array is {sumOfOdds}, Product of even numbers {productOfEvens}");

Console.WriteLine("each element counts:");
foreach (KeyValuePair<int, int> entry in elementCounts)
{
    Console.WriteLine(entry.Key + ": " + entry.Value);
}
