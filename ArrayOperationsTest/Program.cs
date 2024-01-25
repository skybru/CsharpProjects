using System;


/*
string[] pallets = { "B14", "A11", "B12", "A13" };
Console.WriteLine("");

Console.WriteLine("Sorted...");
Array.Sort(pallets);
foreach (var pallet in pallets)
{
    Console.WriteLine($"-- {pallet}");
}

Console.WriteLine("");
Console.WriteLine("Reversed...");
Array.Reverse(pallets);
foreach (var pallet in pallets)
{
    Console.WriteLine($"-- {pallet}");
}


Array.Clear(pallets, 0, 2);
if (pallets[0] != null)
    Console.WriteLine($"After: {pallets[0].ToLower()}");

Console.WriteLine($"Clearing 2 ... count: {pallets.Length}");
foreach (var pallet in pallets)
{
    Console.WriteLine($"-- {pallet}");
}

Array.Resize(ref pallets, 6);
Console.WriteLine($"Resizing 6 ... count: {pallets.Length}");

pallets[4] = "C01";
pallets[5] = "C02";

foreach (var pallet in pallets)
    Console.WriteLine($"-- {pallet}");

Console.WriteLine("");
Array.Resize(ref pallets, 3);
Console.WriteLine($"Resizing 3 ... count: {pallets.Length}");

foreach (var pallet in pallets)
    Console.WriteLine($"-- {pallet}");

string value = "abc123";
char[] valueArray = value.ToCharArray();
Array.Reverse(valueArray);
string result = String.Join(",", valueArray);
Console.WriteLine(result);

string[] items = result.Split(',');
foreach (string item in items) {
    Console.WriteLine(item);
}

string pangram = "The quick brown fox jumps over the lazy dog";
char[] pangramChar = pangram.ToCharArray();
Array.Reverse(pangramChar);
Console.WriteLine(pangramChar); 
risultato: god yzal eht revo spmuj xof nworb kciuq ehT

string pangram = "The quick brown fox jumps over the lazy dog";
string[] pangramArray = pangram.Split(' ');
string[] reversedArray = new string[pangramArray.Length];
string wordReversed = "";
string reversedPangram = "";

for (int i = 0; i < pangramArray.Length; i++) {
    char[] wordToReverse = pangramArray[i].ToCharArray(); //array di char in cui inserisco la parola da invertire
    Array.Reverse(wordToReverse); //inverto la parola
    wordReversed = String.Join("", wordToReverse); //parola invertita da char[] a string
    //reversedArray[i] = new string(wordReversed);
    reversedArray[i] = wordReversed;
}
reversedPangram = String.Join(" ", reversedArray);
Console.WriteLine(reversedPangram);

*/

string orderStream = "B123,C234,A345,C15,B177,G3003,C235,B179";
string[] orderIDsArray = orderStream.Split(",");
Array.Sort(orderIDsArray);

for (int i = 0; i < orderIDsArray.Length; i++) {
    //ordine diventa char[], si conta la lunghezza del char[] e si stampa con -error
    char[] IDCharArray = orderIDsArray[i].ToCharArray();
    int counterChar = IDCharArray.Length;
    if (counterChar == 4)
        Console.WriteLine($"{orderIDsArray[i]}");
    else
        Console.WriteLine($"{orderIDsArray[i]}\t- Error");
}
