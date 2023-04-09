//The third exercise
int[] array = { 0, 99, 26, 31, 3, 3,3,3, 41, 41, 41, 4, 5 };

int mCount = 0;
int nowCount = 1;
int maxValue = 0;

for (int i = 1; i < array.Length; i++)
{
    if (array[i] == array[i - 1])
    {
        nowCount++;

        if (nowCount > mCount)
        {
            mCount = nowCount;
            maxValue = array[i];
        }
    }
    else
    {
        nowCount = 1;
    }
}

Console.WriteLine($"Max number of equal elements next to each other is {mCount}, their value is {maxValue}");
