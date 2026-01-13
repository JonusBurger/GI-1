// See https://aka.ms/new-console-template for more information
int[] a;

Console.WriteLine("Geben Sie die Zahl getrennt mit Leerzeichen ein:");
string input = Console.ReadLine();
a = Array.ConvertAll(input.Split(" "), int.Parse);

Quicksort(0, a.Length - 1);
Console.WriteLine("Sortiertes Array:");
Console.WriteLine(string.Join(" ", a));

void Quicksort(int li, int re)
{
    int i = li;
    int j = re;
    int pivot = a[li];

    while (i < j)
    {
        while (a[i] <= pivot && i < re)
        {
            i++;
        }
        while (a[j] > pivot && j > li)
        {
            j--;
        } if(i < j)
        {
            int temp = a[i];
            a[i] = a[j];
            a[j] = temp;
        }
    }

    a[li] = a[j];
    a[j] = pivot;

    if (li < j - 1)
    {
        Quicksort(li, j - 1);
    }
    if (j + 1 < re)
    {
        Quicksort(j + 1, re);
    }
}
