
void MergeSort (int[] Unsorted, int p, int r) {
    if (p < r) {

        int q = (p + r) / 2;
        MergeSort(Unsorted, p, q);
        MergeSort(Unsorted, q + 1, r);
        Merge(Unsorted, p, q, r);
    }
}

void Merge (int[] Array, int p, int q, int r) {

    int n1 = q - p + 1; //la prima metà senza il primo
    int n2 = r - q;     //la seconda metà
    //creazione di due array per le metà
    int[] arrayL = new int[n1];
    int[] arrayR = new int[n2];
    //copia delle metà nei relativi array
    for (int i = 0; i < n1; i++) {
        arrayL[i] = Array[p + i - 1];
    }
    for (int j = 0; j < n2; j++) {
        arrayR[j] = Array[q + j];
    }

    int m = 0, n = 0;
    //aggiunta condizione per vedere se un array è vuoto e di conseguenza copiare l'altro (che è già ordinato)
    for (int k = p; k < r; k++) {
        if (m > n1) {
            Array[k] = arrayR[n];
            n++;
        } else if (n > n2) {
            Array[k] = arrayL[m];
            m++;
        } else if (arrayL[m] <= arrayR[n]) {
            Array[k] = arrayL[m];
            m++;
        } else {
            Array[k] = arrayR[n];
            n++;
        }
    }
}   

