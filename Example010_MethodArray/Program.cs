//               0   1   2   3   4   5   6   7   8    9  10   11   12   13   14   15
int[] array = { 10, 12, 31, 41, 35, 145, 63, 67, 85, 69, 130, 11, 112, 133, 154, 145 };

int n = array.Length;
int find = 145;

int index = 0;

while (index < n)
{

    if (array[index] == find)
    {
        Console.WriteLine(index);
        break;
    }
    //index = index + 1;
    index++;
}