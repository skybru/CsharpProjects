/*


Write pseudocode to implement the naive polynomial-evaluation algorithm that computes each term of the polynomial from scratch. 
What is the running time of this algorithm? How does it compare to Horner’s rule?

y = 0
for i = n downto 0
    y = a[i] + x * y

Naive-Horner (A, n)
y = 0
for i = 1 to A.length
    m = 0
    for j = 0 to i - 1
        m = m * n
    y = y + A[i] * m

*/