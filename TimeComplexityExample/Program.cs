using System;

int[] arrayN = {1,2,3,4,5,6,7,8,9,10}; //this is n
int[] unsortedN = {29,96,57,3,75,69,41,32,14,84};

factorialAlgo();
exponentialAlgo();
//polynomialAlgo(unsortedN);
SuperLinearAlgo(unsortedN);
linearAlgo(arrayN, 8);
logarithmicAlgo(arrayN, 3);


void factorialAlgo() {
    //Big-O Notation: O(n!) - Runtime grows the fastest and becomes quickly unusable for even small values of n. 
}

void exponentialAlgo() {
    //Big-O Notation: O(c^n) - Runtime grows even faster than polynomial algorithm based on n. 
}

void polynomialAlgo(int[] unsortedArray) {
    //Big-O Notation: O(n^c) - Runtime grows quicker than next all based on n.
    Console.WriteLine($"\nThis is a BubbleSort where n is " + unsortedArray.Length);
    int polyCounter = 0;
    Bubblesort(unsortedArray);

    void Bubblesort(int[] bubbleArray) {

        for (int i = 0; i <= bubbleArray.Length - 2; i++) {
            polyCounter++;

            for (int j = i + 1; j <= bubbleArray.Length - 1; j++) {
                if (bubbleArray[i] > bubbleArray[j]) {
                    //(unsortedArray[j], unsortedArray[i]) = (unsortedArray[i], unsortedArray[j]); tuple for swap value
                    int temp = bubbleArray[i];
                    bubbleArray[i] = bubbleArray[j];
                    bubbleArray[j] = temp;
                    Bubblesort(bubbleArray);
                } else
                    break;
            }
        }
    }

    Console.Write($"Array sorted: ");
    for (int i = 0; i < unsortedArray.Length; i++) {
        Console.Write(unsortedArray[i] + ", ");
    }
    Console.WriteLine();
}

void SuperLinearAlgo(int[] unsortedArray) {
    //Big-O Notation: O(n*logn) - Runtime grows in proportion to n.
    Console.WriteLine($"\nThis is a MergeSort where n is " + unsortedArray.Length);
    int mergeCounter = 0;
    
    SortArray(unsortedArray, 0, unsortedArray.Length - 1);
    
    int[] SortArray(int[] unsortArray, int low, int up) {
        if (low < up) {
            int mid = low + (up - low) / 2;

            SortArray(unsortArray, low, mid);
            SortArray(unsortArray, mid + 1, up);

            Mergesort(unsortArray, low, mid, up);
        }

        return unsortArray;
    }

    void Mergesort(int[] mergeArray, int lower, int middle, int upper) {

        int leftArrayLength = middle - lower + 1;
        int rightArrayLength = upper - middle;
        int[] leftTempArray = new int[leftArrayLength];
        int[] rightTempArray = new int[rightArrayLength];
        int i, j;

        for (i = 0; i < leftArrayLength; ++i)
            leftTempArray[i] = mergeArray[lower + i];

        for (j = 0; j < rightArrayLength; ++j)
            rightTempArray[j] = mergeArray[middle + 1 + j];

        int k = lower;

        while (i < leftArrayLength && j < rightArrayLength) {

            if (leftTempArray[i] <= rightTempArray[j]) {
                mergeArray[k++] = leftTempArray[i++];
            } else {
                mergeArray[k++] = rightTempArray[j++];
            }
        }

        while (i < leftArrayLength) {
            mergeArray[k++] = leftTempArray[i++];
        }

        while (j < rightArrayLength) {
            mergeArray[k++] = rightTempArray[j++];
        }
    }

    Console.Write($"Array sorted: ");
    for (int i = 0; i < unsortedArray.Length; i++) {
        Console.Write(unsortedArray[i] + ", ");
    }
    Console.WriteLine();



    Console.WriteLine($"\nThis is a QuickSort where n is " + unsortedArray.Length);
    int quickCounter = 0, pivot;
    int lower = 0, upper = unsortedArray.Length - 1;

    Quicksort(unsortedArray, lower, upper);

    void Quicksort(int[] quickArray, int quickLower, int quickUpper) {

        int pivot = quickUpper;

    }
}

void linearAlgo(int[] linearArray, int target) {
    //Big-O Notation: O(n) - Runtime grows directly in proportion to n.
    Console.WriteLine($"\nThis is a Simple Search where n is " + linearArray.Length);
    int linearCounter = 0;
    for (int i = 0; i < linearArray.Length; i++) {
        linearCounter++;

        if (linearArray[i] == target)
            Console.WriteLine($"Target: " + target + ", found after " + linearCounter + " try.");
    }
}

void logarithmicAlgo(int[] logArray, int target) {
    //Big-O Notation: O(logn) - Runtime grows logarithmically in proportion to n.
    Console.WriteLine($"\nThis is a Binary Search where n is " + logArray.Length); //Binary Search uses two pointers as boundaries for the search
    int logCounter = 0;
    bool isValid = false;
    int lower = 0, upper = logArray.Length-1, middle = 0;

    while (isValid == false) {
        logCounter++;

        if (lower > upper) {
            Console.WriteLine("Unsuccessful research: target not found.\n");
            break;
        }

        middle = (lower + upper) / 2;

        if (logArray[middle] < target) 
            lower = middle + 1;
        else if (logArray[middle] > target)
            upper = middle - 1;
        else {
            isValid = true;
            Console.WriteLine($"Target: " + target + ", found after " + logCounter + " try.\n");
        }
    }
}