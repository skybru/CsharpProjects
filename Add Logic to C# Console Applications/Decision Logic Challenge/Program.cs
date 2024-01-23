/*
Admin && >55 = Welcome, Super Admin user.
Admin && <=55 = Welcome, Admin user.
Manager && >=20 = Contact an Admin for access.
Manager && <20 = You do not have sufficient privileges.
!Admin && !Manager = You do not have sufficient privileges.
*/

using System;

string permission = "Admin|Manager";
int level = 55;
string message = "";

if (permission.Contains("Admin")) {
    message = level > 55 ? "Welcome, Super Admin User" : "Welcome, Admin User";
} else if (permission.Contains("Manager")) {
    message = level >= 20 ? "Contact an Admin for access" : "You do not have sufficient privileges";
} else
    message = "You do not have sufficient privileges.";

Console.WriteLine(message);
