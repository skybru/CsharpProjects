
int n = 1;
while (100*n*n > Math.Pow(2, n)) {
    n++;
}

Console.WriteLine($"Valore minimo di n per cui A è meglio di B è: {n}");