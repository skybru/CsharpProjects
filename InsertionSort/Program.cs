void InsertionSort(int[] Array) {

    for (int j = 1; j < Array.Length; j++) {
        int key = Array[j];     //current number
        int i = j - 1;          //precedent number

        //insert current(key) in the right position of sorted Array[1.. j - 1]
        while (i >= 0 && Array[i] > key) {   //i is valid index and precedent bigger than current(key)
            Array[i + 1] = Array[i];         //precedent and current value swap
            i = i - 1;                       //scan the array backwards to find place to current
        }
        
        Array[i + 1] = key;              //set the current(key) to the place next to current
    }
}

int[] Unsorted = {5, 2, 4, 6, 1, 3, 10, 14, 28, 11, 7, 16, 30, 50, 25, 18};
InsertionSort(Unsorted);

for (int i = 0; i < Unsorted.Length; i++) {
    Console.Write($"{Unsorted[i]} ");
}
Console.WriteLine();
InsertionSortReverse(Unsorted);

for (int i = 0; i < Unsorted.Length; i++) {
    Console.Write($"{Unsorted[i]} ");
}
//---------------------------------------

void InsertionSortReverse(int[] Array) {

    for (int j = 1; j < Array.Length; j++) {
        int key = Array[j];     //current number
        int i = j - 1;          //precedent number

        //insert current(key) in the right position of sorted Array[1.. j - 1]
        while (i >= 0 && Array[i] < key) {   //i is valid index and precedent smaller than current(key)
            Array[i + 1] = Array[i];         //precedent and current value swap
            i = i - 1;                       //scan the array backwards to find place to current
        }
        
        Array[i + 1] = key;              //set the current(key) to the place next to current
    }
}