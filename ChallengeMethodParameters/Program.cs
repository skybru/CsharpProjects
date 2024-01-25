string[,] corporate = 
{
    {"Robert", "Bavin"}, {"Simon", "Bright"},
    {"Kim", "Sinclair"}, {"Aashrita", "Kamath"},
    {"Sarah", "Delucchi"}, {"Sinan", "Ali"}
};

string[,] external = 
{
    {"Vinnie", "Ashton"}, {"Cody", "Dysart"},
    {"Shay", "Lawrence"}, {"Daren", "Valdes"}
};

string internalDomain = "contoso.com";
string externalDomain = "hayworth.com";
//username = 2 char name + full surname

for (int i = 0; i < corporate.GetLength(0); i++) 
{
    // display internal email addresses
    DisplayEmployeeMail(i);

}

for (int i = 0; i < external.GetLength(0); i++) 
{
    // display external email addresses
    DisplayEmployeeMail(i, true);

}

void DisplayEmployeeMail (int index, bool isExternal = false) {

    if (isExternal) {

        string name = external[index, 0].ToLower().Remove(2);
        string surname = external[index, 1].ToLower();
        string username = name + surname + "@" + externalDomain;
        Console.WriteLine(username);

    } else {

        string name = corporate[index, 0].ToLower().Remove(2);
        string surname = corporate[index, 1].ToLower();
        string username = name + surname + "@" + internalDomain;
        Console.WriteLine(username);
    }
}