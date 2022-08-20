int[] array = { 21, 33, 16, 67, 56, 55, 34, 97, 56 };

int n = array.Length;
int find = 56;

int index = 0;

while (index < n)
{
    if (array[index] == find)
    {
        Console.WriteLine(index);
        break;
    }
    index++;
}
