using System;

int[] arrayN = {5,1,8,2,3,9,4,7,6,10};
//int median = (arrayN[0] + arrayN[arrayN.Length-1] + arrayN[arrayN.Length/2]) / 3;

Console.WriteLine($"Unsorted Array: ");
foreach (int items in arrayN) {
    Console.Write(items + ",");
}
Quicksort(arrayN, 0, arrayN.Length);
System.Console.WriteLine();

Console.WriteLine($"Sorted Array: ");
foreach (int items in arrayN) {
    Console.Write(items + ",");
}

void Quicksort(int[] quickArray, int quickLower, int quickUpper) {

    if (quickLower < quickUpper) {
        int pivot = Partition(quickArray, quickLower, quickUpper);
        Quicksort(quickArray, quickLower, pivot);
        Quicksort(quickArray, pivot + 1, quickUpper);
    }
}

int Partition(int[] partArray, int partLower, int partUpper) {

    int pivot = partArray[partLower];
    int leftBound = partLower, temp;

    for (int i = partLower + 1; i < partUpper; i++) {
        if (partArray[i] < pivot) {
            temp = partArray[i];
            partArray[i] = partArray[leftBound];
            partArray[leftBound] = temp;
            leftBound++;

            temp = pivot;
            pivot = partArray[leftBound];
            partArray[leftBound] = temp;
        }
    }

    return leftBound;
}