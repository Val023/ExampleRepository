int [] array = { 5, 99, 53, 14, 7, 33, 62, 21, 14 };

int n = array.Length;
int find = 14;

int index = 0;

while (index < n)
{
    if(array[index] == find)
    {
        Console.WriteLine(index);
        break;
    }
    //index = index + 1
    index++;
}
