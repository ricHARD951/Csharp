//InsertionSort "Dlzka triedenia : 2,5896765 sekund"
int length = 50000;
int[] arr = new int[length];
Random random = new Random();

for (int i = 0; i < length; i++)
{
    arr[i] = random.Next();
}


var watch = new System.Diagnostics.Stopwatch();
watch.Start();
InsertionSort(arr, arr.Length);
watch.Stop();
Console.WriteLine($"Dĺžka triedenia : {watch.Elapsed.TotalSeconds} sekund");


static void InsertionSort(int[] arr, int n)
{
    for (int i = 1; i < n; ++i)
    {
        int key = arr[i];
        int j = i - 1;

        while (j >= 0 && arr[j] > key)
        {
            arr[j + 1] = arr[j];
            j = j - 1;
        }
        arr[j + 1] = key;
    }
}

//BubbleSort "Dlzka triedenia : 9,4447361 sekund"
int length = 50000;
int[] arr = new int[length];
Random random = new Random();

for (int i = 0; i < length; i++)
{
    arr[i] = random.Next();
}


var watch = new System.Diagnostics.Stopwatch();
watch.Start();
Bubblesort(arr, arr.Length);
watch.Stop();
Console.WriteLine($"Dĺžka triedenia : {watch.Elapsed.TotalSeconds} sekund");


static void Bubblesort(int[] arr, int n)
{
    for (int i = 0; i < n - 1; i++)
    {
        for (int j = 0; j < n - i - 1; j++)
        {
            if (arr[j] > arr[j + 1])
            {
                int temp = arr[j];
                arr[j] = arr[j + 1];
                arr[j + 1] = temp;
            }
        }
    }
}


//SelectionSort "Dlzka triedenia : 3,7589431 sekund"
int length = 50000;
int[] arr = new int[length];
Random random = new Random();

for (int i = 0; i < length; i++)
{
    arr[i] = random.Next();
}


var watch = new System.Diagnostics.Stopwatch();
watch.Start();
SelectionSort(arr, arr.Length);
watch.Stop();
Console.WriteLine($"Dĺžka triedenia : {watch.Elapsed.TotalSeconds} sekund");


static void SelectionSort(int[] arr, int n)
{
    for (int i = 0; i < n - 1; i++)
    {
        int min_idx = i;
        for (int j = i + 1; j < n; j++)
            if (arr[j] < arr[min_idx])
                min_idx = j;

        
        int temp = arr[min_idx];
        arr[min_idx] = arr[i];
        arr[i] = temp;
    }
}




/*for (int i = 0; i < length; i++)
{
    Console.WriteLine(arr[i]);
}*/



