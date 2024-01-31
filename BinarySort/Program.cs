/*
Considerate il seguente problema di ricerca:
Input: una sequenza di n numeri A = (A1, A2,..., An) e un valore v.
Output: un indice i tale che V = a[i] o il valore speciale NIL se v non figura in A.

Riprendendo il problema della ricerca (Esercizio 2.1-3), notiamo che, se la sequenza A è ordinata, 
possiamo confrontare il punto centrale della sequenza con v ed escludere metà sequenza da ulteriori controlli.
La ricerca binaria è un algoritmo che ripete questa procedura, dimezzando ogni volta la dimensione della
porzione restante della sequenza. Scrivete uno pseudocodice, iterativo o ricorsivo,
per la ricerca binaria. Dimostrate che il tempo di esecuzione nel caso peggiore
della ricerca binaria è Theta(lg n)

Binary-Search (A, v, lo, hi)

    if (lo > hi) 
        return NIL
    mid = (lo+hi)/2
    if v == A[mid]
        return mid
    else if v > A[mid]
        Binary-Search(A, v, mid + 1, hi)
    else
        Binary-Search(A, v, lo, mid - 1)

    if (p > r)
        return NIL
    //in q viene calcolata la metà
    if (v < A[q])
        r = q - 1
    else if (v > A[q])
        p = q + 1
    else 
        return q

Linear-search(A, v)
    for i = 0 to A.length
        if (A[i] == v)
            print(i)
            return 0
    print(nil)
    return 1

*/