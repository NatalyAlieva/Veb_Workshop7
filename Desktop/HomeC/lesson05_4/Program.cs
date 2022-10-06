//Написать программу перемножения любых целых чисел

long MasToStr(long[] mas)
{
    string str = "";
    for (int i = 0; i < mas.Length; ++i)
        str += mas[i].ToString();
    long Number = Int32.Parse(str);
    return Number;
}

long Composition(long num, long[] mas2, int mas3len)
{
    long[] mas3 = new long[mas3len];
    long sum = 0;
    for (int i = 0; i < mas3len; i++)
    {
        int temp = 1;
        for (int j = mas2.Length - 1; j >= 0; j--)
        {
            if (i == 0 && j == mas2.Length - 1) mas3[i] = num * mas2[j];
            else
            {
                mas3[i] = num * mas2[j];
                mas3[i] = mas3[i] * temp;
            }
            temp = temp * 10;
            sum = sum + mas3[i];
            
        }
         break;
    }
    return sum;
}

long[] array1 = new long[5] { 1, 1, 3, 5, 8 };
long[] array2 = new long[4] { 2, 0, 4, 7,6};
int a=array1.Length + array2.Length - 1;
Console.WriteLine(Composition((MasToStr(array1)),array2,a));

