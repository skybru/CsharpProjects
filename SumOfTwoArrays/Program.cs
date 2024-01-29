/*

Considerate il problema di sommare due numeri interi binari di n-bit, memorizzati
in due array A e B di n elementi. La somma dei due interi deve essere memorizzata
in forma binaria nell’array C di n C 1 elementi. Definite formalmente il
problema e scrivete lo pseudocodice per sommare i due interi.

0 + 0 =   0
0 + 1 =   1
1 + 0 =   1
1 + 1 =  10

SUMMA-ARRAYS(A, B)
let C[n+1] be new array
carry = 0

for i = A.Length-1 to 0
    C[i] = (A[i] + B[i] + carry)%2
    carry = (A[i] + B[i])/2

C[0] = carry
return C

*/

int[] A = {1, 0, 1, 1, 0, 1, 1, 1};
int[] B = {1, 1, 1, 0, 0, 1, 0, 1};

SummaArrays(A, B);

void SummaArrays(int[] A, int[] B) {
    int[] C = new int[A.Length+1];
    int carry = 0;

    for (int i = A.Length - 1; i >= 0; i-- ) {
        C[i + 1] = (A[i] + B[i] + carry) % 2;
        carry = (A[i] + B[i] + carry) / 2;
    }
    C[0] = carry;

    for (int j = 0; j < C.Length; j++) {
        Console.Write(C[j]);
    }
}
