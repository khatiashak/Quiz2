//First exercise

Console.WriteLine("enter the size of an array: ");
int size = int.Parse(Console.ReadLine());

int[] array = new int[size];

Console.WriteLine("Now write the elements of your array: ");

for (int i = 0; i < size; i++)
{
    array[i] = int.Parse(Console.ReadLine());
}


int sumOddNumb = 0;
int prodEvenNumb = 1;
foreach (int element in array)
{
    if (element % 2 == 0)
    {
        sumOddNumb += element;
    }
    else
    {
        prodEvenNumb *= element;
    }
}

Dictionary<int, int> counts = new Dictionary<int, int>();

foreach (int element in array)
{
    if (counts.ContainsKey(element))
    {
        counts[element]++;
    }
    else
    {
        counts[element] = 1;
    }
}

Console.WriteLine($"There are {sumOddNumb} odd and {prodEvenNumb} even numbers");

foreach (KeyValuePair<int, int> pair in counts)
{
    Console.WriteLine($"Element {pair.Key} occurs {pair.Value} times.");
}
