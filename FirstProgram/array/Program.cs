int size = 10;
int[] arr = new int[size];

for(int k = 0; k < size; k++)
{
    arr[k] = k;
}

foreach(int k in arr)
{
    Console.WriteLine(k);
}

