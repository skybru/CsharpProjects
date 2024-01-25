/*
SayHello();

void SayHello() {
    Console.WriteLine("Hello World!");
}

int[] a = {1,2,3,4,5};

Console.WriteLine("Contents of Array:");
PrintArray();

void PrintArray() {
    foreach (int x in a) {
        Console.Write($"{x} ");
    }
    Console.WriteLine();
}

Console.WriteLine("Generating random numbers:");
DisplayRandomNumbers();

void DisplayRandomNumbers() {

    Random random = new Random();

    for (int i = 0; i < 5; i++) {
        Console.Write($"{random.Next(1,12)} ");
    }

    Console.WriteLine();
}


using System;

int[] times = {800, 1200, 1600, 2000};
int diff = 0;

Console.WriteLine("Enter current GMT");
int currentGMT = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Current Medicine Schedule:");

/* Format and display medicine times 
DisplayTimes();

Console.WriteLine("Enter new GMT");
int newGMT = Convert.ToInt32(Console.ReadLine());

if (Math.Abs(newGMT) > 12 || Math.Abs(currentGMT) > 12)
{
    Console.WriteLine("Invalid GMT");
}
else if (newGMT <= 0 && currentGMT <= 0 || newGMT >= 0 && currentGMT >= 0) 
{
    diff = 100 * (Math.Abs(newGMT) - Math.Abs(currentGMT));

    /* Adjust the times by adding the difference, keeping the value within 24 hours 
    AdjustTimes();
} 
else 
{
    diff = 100 * (Math.Abs(newGMT) + Math.Abs(currentGMT));

    /* Adjust the times by adding the difference, keeping the value within 24 hours 
    AdjustTimes();
}

Console.WriteLine("New Medicine Schedule:");

/* Format and display medicine times 
DisplayTimes();


void DisplayTimes() {
    foreach (int val in times) {

        string time = val.ToString();
        int len = time.Length;

        if (len >= 3)
        {
            time = time.Insert(len - 2, ":");
        }
        else if (len == 2)
        {
            time = time.Insert(0, "0:");
        }
        else
        {
            time = time.Insert(0, "0:0");
        }

        Console.Write($"{time} ");
    }

    Console.WriteLine();
}

void AdjustTimes() {
    for (int i = 0; i < times.Length; i++) {

        times[i] = ((times[i] + diff)) % 2400;
    }
}

// if IPv4 is four numbers
// if No leading 0s
// if Number from 0 to 255
// then ipAddr valid
// else ipAddr not valid

//string ipv4Input = "107.31.1.5";
string[] ipv4Input = {"107.31.1.5", "255.0.0.255", "555..0.555", "255...255"};
string[] address;
bool validLength = false;
bool validZeroes = false;
bool validRange = false;

foreach (string ip in ipv4Input) {

    address = ip.Split(".", StringSplitOptions.RemoveEmptyEntries);

    ValidateLength();
    ValidateZeroes();
    ValidateRange();

    if (validLength && validZeroes && validRange) {
        Console.WriteLine($"{ip} is a valid IPv4 address");
    } else {
        Console.WriteLine($"{ip} is not a valid IPv4 address");
    }

}
void ValidateLength() {

    validLength = address.Length == 4;
}

void ValidateZeroes() {
    
    foreach (string number in address) {

        if (number.Length > 1 && number.StartsWith("0")) {
            validZeroes = false;
            return;
        }
    }

    validZeroes = true;
}

void ValidateRange() {

    foreach (string number in address) {

        int value = int.Parse(number);

        if (value < 0 || value > 255) {
            validRange = false;
            return;
        }
    }
    validRange = true;
}

CountTo(5);

	void CountTo(int max) 
	{
		for (int i = 0; i < max; i++)
		{
			Console.Write($"${i}, ");
		}
	}

int[] schedule = {800, 1200, 1600, 2000};

DisplayAdjustedTimes(schedule, 6, -6);

void DisplayAdjustedTimes(int[] times, int currentGMT, int newGMT) {

    int diff = 0;
    if (Math.Abs(newGMT) > 12 || Math.Abs(currentGMT) > 12) {
        Console.WriteLine("Invalid GMT");
    }
    else if (newGMT <= 0 && currentGMT <= 0 || newGMT >= 0 && currentGMT >= 0) {
        diff = 100 * (Math.Abs(newGMT) - Math.Abs(currentGMT));
    }
    else {
        diff = 100 * (Math.Abs(newGMT) + Math.Abs(currentGMT));
    }
    for (int i = 0; i < times.Length; i++) {
        int newTime = (times[i] + diff) % 2400;
        Console.WriteLine($"{times[i]} -> {newTime}");
    }
}

string[] students = {"Jenna", "Ayesha","Carlos","Viktor"};

DisplayStudents(students);
DisplayStudents(new string[] {"Robert","Vanya"});

void DisplayStudents(string[] students) {

    foreach (string student in students) {
        Console.Write($"{student}, ");
    }
    Console.WriteLine();
}

double pi = 3.14159;

PrintCircleInfo(12);
PrintCircleInfo(24);


void PrintCircleInfo(int radius) {

    Console.WriteLine($"Circle with radius {radius}");
    PrintCircleArea(radius);
    PrintCircleCircumference(radius);
    Console.WriteLine();
    
}

void PrintCircleArea(int radius) {

    double area = pi * (radius * radius);
    Console.WriteLine($"Area = {area}");

}

void PrintCircleCircumference(int radius) {

    double circumference = 2 * pi * radius;
    Console.WriteLine($"Circumference = {circumference}");
}

//TEST WITH INT
int a = 3;
int b = 4;
int c = 0;

Multiply(a, b, c);
Console.WriteLine($"global statement: {a} x {b} = {c}");

void Multiply(int a, int b, int c) {

    c = a * b;
    Console.WriteLine($"Inside Multiply method: {a} x {b} = {c}");
}

//TEST WITH ARRAY
int[] array = {1, 2, 3, 4, 5};

PrintArray(array);
Clear(array);
PrintArray(array);

void PrintArray(int[] array) {

    foreach (int a in array) {
        Console.Write($"{a} ");
    }
    Console.WriteLine();
}

void Clear(int[] array)
 {
    for (int i = 0; i < array.Length; i++) {
        array[i] = 0;
    }
}

//TEST WITH STRINGS
string status = "Healthy";

Console.WriteLine($"Start: {status}");
SetHealth(false);
Console.WriteLine($"End: {status}");

void SetHealth(bool isHealthy) {

    status = (isHealthy ? "Healthy" : "Unhealthy");
    Console.WriteLine($"Middle: {status}");

}
*/

string[] guestList = {"Rebecca","Nadia","Noor","Jonte"};
string[] rsvps = new string[10];
int count = 0;

RSVP("Rebecca");
RSVP("Nadia", 2, "Nuts", true);
RSVP("Linh", 2, "none", inviteOnly: false);
RSVP("Tony", inviteOnly: true, allergies: "Jackfruit");
RSVP("Noor", 4, "none");
RSVP("Jonte", 2, "Stone fruit", false);
ShowRSVPs();

void RSVP(string name, int partySize = 1, string allergies = "none", bool inviteOnly = true) {

    if (inviteOnly) {
        bool found = false;

        foreach (string guest in guestList) {

            if (guest.Equals(name)) {
                found = true;
                break;
            }
        }

        if (!found) {
            Console.WriteLine($"Sorry, {name} is not on the guest list");
            return;
        }
    }

    rsvps[count] = $"Name: {name}, \tParty Size: {partySize}, \t Allergies: {allergies}";
    count++;
}

void ShowRSVPs() {
    Console.WriteLine("\nTotal RSVPs:");

    for (int i = 0; i < count; i++) {

        Console.WriteLine(rsvps[i]);
    }
}