/*int length = 50000;
int[] arr = new int[length];
Random random = new Random();

for (int i = 0; i < length; i++)
{
    arr[i] = random.Next();
}

var watch = new System.Diagnostics.Stopwatch();

watch.Start();
for(int i = 0; i < 15000; i++)
{
    LinearSearch(arr, i);
}
watch.Stop();
Console.WriteLine($"Dĺžka hľadania : {watch.Elapsed.Milliseconds} milisekund");

int LinearSearch(int[] arr, int target)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (target == arr[i])
            return (i + 1);
    }
    return -1;
}*/

int length = 50000;
int[] arr = new int[length];
Random random = new Random();

for (int i = 0; i < length; i++)
{
    arr[i] = random.Next();
}
var watch = new System.Diagnostics.Stopwatch();

watch.Start();
for (int i = 0; i < 15000; i++)
{
    BinarySearch(arr, i);
}
watch.Stop();
Console.WriteLine($"Dĺžka hľadania : {watch.Elapsed.Milliseconds} milisekund");

int BinarySearch(int[] arr, int target)
{
    int low, high, mid;
    low = 0;
    high = arr.Length - 1;
    mid = (low + high) / 2;
    while (low <= high)
    {
        if (arr[mid] == target)
            return mid + 1;
        else
            if (target < arr[mid])
            high = mid - 1;
        else
            low = mid + 1;
        mid = (low + high) / 2;
    }
    return -1;
}
    
