int Max (int arg1, int arg2, int arg3)
{
    int resulte = arg1;
    if (arg2 > resulte) resulte = arg2;
    if (arg3 > resulte) resulte = arg3;
    return resulte;
}//              0    1   2  3   4   5   6   7  8
int [] array = { 18, 88, 25, 404, 66, 14, 45, 70, 9 };

int resulte = Max (
    Max(array[0], array[1], array[2]),
    Max(array[3], array[4], array[5]),
    Max(array[6], array[7], array[8])
);
Console.WriteLine(resulte);

