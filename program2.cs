// the second exercise

//First Array
Console.WriteLine("enter the size of the first array: ");
int size1 = int.Parse(Console.ReadLine());

int[] array1 = new int[size1];

Console.WriteLine("Now write the elements of your first array: ");

for (int i = 0; i < size1; i++)
{
    array1[i] = int.Parse(Console.ReadLine());
}

//Second Array
Console.WriteLine("enter the size of your second array: ");
int size2 = int.Parse(Console.ReadLine());

int[] array2 = new int[size2];

Console.WriteLine("Now write the elements of your second array: ");

for (int i = 0; i < size2; i++)
{
    array2[i] = int.Parse(Console.ReadLine());
}

//comparing
if (array1.Length != array2.Length)
{
    Console.WriteLine("These arrays are not equal");
}
else
{
    Console.WriteLine("These arrays are  equal");
}
