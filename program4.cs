the fourth exercise

int[] array = { 33, 4, 5, 22, 4, 5, 6, 22, 22 };

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

int appearsMost = counts.OrderByDescending(kv => kv.Value).First().Key;

Console.WriteLine($"The most frequent element is {appearsMost}.");
