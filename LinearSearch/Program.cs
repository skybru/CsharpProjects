/*

Considerate il seguente problema di ricerca:
Input: una sequenza di n numeri A D (A1, A2,..., An) e un valore v.
Output: un indice i tale che V = a[i] o il valore speciale NIL se v non figura in A.
Scrivete uno pseudocodice di ricerca lineare che esamina gli elementi della sequenza alla ricerca di v. 
Utilizzando un’invariante di ciclo, dimostrate che il vostro algoritmo `e corretto. Verificate che la vostra invariante di ciclo soddisfa le tre
proprietà richieste.

Inizializzazione: è vera prima della prima iterazione del ciclo. 
Conservazione: se è vera prima di un’iterazione del ciclo, rimane vera prima
della successiva iterazione.
Conclusione: quando il ciclo termina, l’invariante fornisce un’utile proprietà che
ci aiuta a dimostrare che l’algoritmo `e corretto.


LINEAR-SEARCH(Array, v)

    for i = 0 to Array.length
        if (v == Array[i]) 
            print(i)
            return 0;
print(nil)
return 1

Invariante di ciclo: il subarray A[1...i-1] non contiene il valore v
Inizializzazione: l'array è vuoto
Conservazione: controlliamo se il valore v è presente alla i-esima iterazione, se il subarray A[1...i-1] non contiene il valore v prima della i-esima iterazione,
il subarray A[1...i] non conterrà v prima della prossima iterazione.
Conclusione: il ciclo termina quando raggiungiamo un indice per cui A[i] = v oppure non troviamo v e ritorniamo NIL
*/



