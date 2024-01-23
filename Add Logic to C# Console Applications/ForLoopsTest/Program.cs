/*
for (int i = 0; i < 10; i++) {
    Console.WriteLine(i);
    if (i == 7) break;
}

for (int i = 0; i < names.Length; i++) {
    Console.WriteLine(names[i]);
}

string[] names = { "Alex", "Eddie", "David", "Michael" };
for (int i = 0; i < names.Length; i++)
    if (names[i] == "David") 
        names[i] = "Sammy";

foreach (var name in names)
    Console.WriteLine(name);
*/

int moduleThree = 1;
int moduleFive = 1;

for (int i = 1; i <= 100; i++) {
    moduleFive = i % 5;
    moduleThree = i % 3;

    if (moduleFive == 0 && moduleThree == 0)
        Console.WriteLine($"{i} - FizzBuzz");

    else if (moduleFive == 0)
        Console.WriteLine($"{i} - Buzz");
        
    else if (moduleThree == 0)
        Console.WriteLine($"{i} - Fizz");

    else
        Console.WriteLine($"{i}");
}

