//The third exercise
int[] array = { 0, 99, 26, 31, 3, 3, 41, 41, 41, 4, 5 };

int currentCount = 1;
int maxCount = 1;

for (int i = 1; i < array.Length; i++)
{

    if (array[i] == array[i - 1])
    {
        currentCount++;
    }

    else
    {
        currentCount = 1;
    }

    if (currentCount > maxCount)
    {
        maxCount = currentCount;
    }
}

Console.WriteLine($"The maximum number of equal elements next to each other is {maxCount}.");
