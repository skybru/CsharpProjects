/*

Supponete di ordinare n numeri memorizzati nell’array A trovando prima il più
piccolo elemento di A e scambiandolo con l’elemento in A[1]; poi, trovate il secondo elemento più piccolo di A e scambiatelo con A[2]. 
Continuate in questo modo per i primi n-1 elementi di A. Scrivete lo pseudocodice 
per questo algoritmo, che è noto come selection sort (ordinamento per selezione). 
Quale invariante di ciclo conserva questo algoritmo? i < j
Perché basta eseguirlo soltanto per i primi n - 1 elementi, anzichè per tutti gli n elementi? Perché avremmo n-1 elementi ordinati, di conseguenza il rimanente è già nella sua posizione
Esprimete nella notazione‚ i tempi di esecuzione nei casi migliore e peggiore dell’algoritmo selection sort.

SELECTION-SORT (A)

for i = 0 to A.length
    for j = 1 to A.length
        if A[j] < A[i]
            var temp = A[i]
            A[i] = A[j]
            A[j] = temp

*/