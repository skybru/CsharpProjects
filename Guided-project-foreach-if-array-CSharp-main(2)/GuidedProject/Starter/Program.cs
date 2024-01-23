using System;

// initialize variables - graded assignments 
int currentAssignments = 5;

int[] sophiaScores = new int[] {90, 86, 87, 98, 100};
int[] andrewScores = new int[] {92, 89, 81, 98, 68};
int[] emmaScores = new int[] {90, 85, 87, 98, 68};
int[] loganScores = new int [] {90, 95, 87, 88, 96};

//student names
string[] studentNames = new string [] {"Sophia", "Andrew", "Emma", "Logan"};
int[] studentScores = new int [10];

foreach (string name in studentNames) {
    
    string currentStudent = name;

    if (currentStudent == "Sophia")
        studentScores = sophiaScores;
    else if (currentStudent == "Andrew")
        studentScores = andrewScores;
    else if (currentStudent == "Emma")
        studentScores = emmaScores;
    else if (currentStudent == "Logan")
        studentScores = loganScores;

    int studentSum = 0;
    decimal studentScore;

    foreach (int score in studentScores) {
        studentSum += score;
    }

    studentScore = (decimal)studentSum / currentAssignments;

    Console.WriteLine("Student\t\tGrade\n");
    Console.WriteLine($"{name}:\t\t" + studentScore + "\tA-");
}



Console.WriteLine("Press the Enter key to continue");
Console.ReadLine();
