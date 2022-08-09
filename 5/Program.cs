void FillArray(int[] Collection)
{
    int lentch = Collection.Length;
    int index = 0;
    while (index < lentch)
    {
        Collection[index] = new Random().Next(1, 10);
        index++;
    }
}

void PrintArray(int[] col)
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        Console.WriteLine(col[position]);
        position++;
    }
}

int IndexOf(int[] Collection, int find)
{
    int count = Collection.Length;
    int index = 0;
    int position = -1;
    while (index < count)
    {
        if (Collection[index] == find)
        {
            position = index;
            break;
        }
        index++;
    }
    return position;
}

int[] array = new int[10];

FillArray(array);
PrintArray(array);
Console.WriteLine();
int pos = IndexOf(array,9);
Console.WriteLine(pos);

