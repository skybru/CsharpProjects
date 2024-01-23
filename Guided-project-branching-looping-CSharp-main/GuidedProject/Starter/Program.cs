using System;

// the ourAnimals array will store the following: 
string animalSpecies = "";
string animalID = "";
string animalAge = "";
string animalPhysicalDescription = "";
string animalPersonalityDescription = "";
string animalNickname = "";

// variables that support data entry
int maxPets = 8;
string? readResult;
string menuSelection = "";
bool validEntry = false;
bool validData = false;
int petAge;

// array used to store runtime data, there is no persisted data
string[,] ourAnimals = new string[maxPets, 6];

// TODO: Convert the if-elseif-else construct to a switch statement

// create some initial ourAnimals array entries
for (int i = 0; i < maxPets; i++)
{   
    switch (i) {
        case 0:
            animalSpecies = "dog";
            animalID = "d1";
            animalAge = "2";
            animalPhysicalDescription = "medium sized cream colored female golden retriever weighing about 65 pounds. housebroken.";
            animalPersonalityDescription = "loves to have her belly rubbed and likes to chase her tail. gives lots of kisses.";
            animalNickname = "lola";
            break;
        case 1:
            animalSpecies = "dog";
            animalID = "d2";
            animalAge = "9";
            animalPhysicalDescription = "large reddish-brown male golden retriever weighing about 85 pounds. housebroken.";
            animalPersonalityDescription = "loves to have his ears rubbed when he greets you at the door, or at any time! loves to lean-in and give doggy hugs.";
            animalNickname = "loki";
            break;
        case 2:
            animalSpecies = "cat";
            animalID = "c3";
            animalAge = "1";
            animalPhysicalDescription = "small white female weighing about 8 pounds. litter box trained.";
            animalPersonalityDescription = "friendly";
            animalNickname = "Puss";
            break;
        case 3:
            animalSpecies = "cat";
            animalID = "c4";
            animalAge = "?";
            animalPhysicalDescription = "";
            animalPersonalityDescription = "";
            animalNickname = "";
            break;
        default:
            animalSpecies = "";
            animalID = "";
            animalAge = "";
            animalPhysicalDescription = "";
            animalPersonalityDescription = "";
            animalNickname = "";
            break;
    }

    ourAnimals[i, 0] = "ID #: " + animalID;
    ourAnimals[i, 1] = "Species: " + animalSpecies;
    ourAnimals[i, 2] = "Age: " + animalAge;
    ourAnimals[i, 3] = "Nickname: " + animalNickname;
    ourAnimals[i, 4] = "Physical description: " + animalPhysicalDescription;
    ourAnimals[i, 5] = "Personality: " + animalPersonalityDescription;
}

do {

    // display the top-level menu options

    Console.Clear();

    Console.WriteLine("Welcome to the Contoso PetFriends app. Your main menu options are:");
    Console.WriteLine(" 1. List all of our current pet information");
    Console.WriteLine(" 2. Add a new animal friend to the ourAnimals array");
    Console.WriteLine(" 3. Ensure animal ages and physical descriptions are complete");
    Console.WriteLine(" 4. Ensure animal nicknames and personality descriptions are complete");
    Console.WriteLine(" 5. Edit an animal’s age");
    Console.WriteLine(" 6. Edit an animal’s personality description");
    Console.WriteLine(" 7. Display all cats with a specified characteristic");
    Console.WriteLine(" 8. Display all dogs with a specified characteristic");
    Console.WriteLine();
    Console.WriteLine("Enter your selection number (or type Exit to exit the program)");

    readResult = Console.ReadLine();
    if (readResult != null)
    {
        menuSelection = readResult.ToLower();
    }

    //Console.WriteLine($"You selected menu option {menuSelection}.");
    //Console.WriteLine("Press the Enter key to continue");

    // pause code execution
    //readResult = Console.ReadLine();

    switch (menuSelection) {
        /*
        1. Outer loop: build the outer loop that iterates through the animals in the ourAnimals array.
        2. Data check: write code that checks for existing pet data and displays the pet ID if data exists for a pet.
        3. Inner loop: build an inner loop that displays all of the pet characteristics for pets with data assigned.
        4. Verification test: perform verification tests for the code that you develop in this exercise.
        */
        case "1":
            //List all of our current pet information
            for (int i = 0; i < maxPets; i++) {
                // This is a good example for when != should be used. You don't care what value is assigned to petID as long as it's not the default value.
                if (ourAnimals [i, 0] != "ID #: ") {
                    Console.WriteLine();

                    for (int j = 0; j < 6; j++) {
                        Console.WriteLine(ourAnimals[i, j]);
                    }
                }
            }

            Console.WriteLine("Press the Enter key to continue.");
            readResult = Console.ReadLine();
            break;
        /*
        PART 1
        1. Calculate petCount: write code that counts the number of pets in the ourAnimals array that have assigned data.
        2. Conditional messages: write code to display message output when petCount is less than maxPets.
        3. Outer loop: build a loop structure that will be used for entering new ourAnimals array data.
        4. Exit criteria: write code that evaluates the exit condition for the "enter new ourAnimals array data" loop.
        5. Verification test: perform verification tests for the code you develop in this exercise.

        PART 2
        1. Read and validate species: build a loop and the inner code structure used to enter and validate the pet species.
        2. Construct pet ID: write the code that uses petCount and the species name to construct the petID value.
        3. Read and validate age: build a loop and the inner code structure used to enter and validate the pet's age.
        4. Read and validate physical description: build a loop and the inner code structure used to enter a physical description of the pet.
        5. Read and validate personality description: build a loop and the inner code structure used to enter a description of the pet's personality.
        6. Read and validate nickname: build a loop and the inner code structure used to enter a nickname for the pet.
        7. Verification test: perform verification tests for the code that you develop in this exercise.
        */
        case "2":
            //Add a new animal friend to the ourAnimals array
            string anotherPet = "y";
            int petCount = 0;

            for (int i = 0; i < maxPets; i++) {

                if (ourAnimals [i, 0] != "ID #: ")
                    petCount++;
            }

            if (petCount < maxPets)
                Console.WriteLine($"We currently have {petCount} pets that need homes. We can manage {(maxPets - petCount)} more.");

            while (anotherPet == "y" && petCount < maxPets) {

                // get the pet's species
                validEntry = false;
                do {
                    Console.WriteLine("\n\rEnter 'dog' or 'cat' to begin a new entry:");
                    readResult = Console.ReadLine();

                    if (readResult != null) {
                        animalSpecies = readResult.ToLower();

                        if (animalSpecies != "dog" && animalSpecies != "cat")
                            validEntry = false;

                            else
                                validEntry = true;
                    }
                } while (validEntry == false);

                // build the animal the ID number - for example C1, C2, D3 (for Cat 1, Cat 2, Dog 3)
                animalID = animalSpecies.Substring(0, 1) + (petCount + 1).ToString();

                // get the pet's age. can be ? at initial entry.
                do {
                    Console.WriteLine("\n\rEnter pet's age or ? if unknown:");
                    readResult = Console.ReadLine();

                    if (readResult != null) {
                        animalAge = readResult;

                        if (animalAge != "?")
                            validEntry = int.TryParse(animalAge, out petAge);

                            else
                                validEntry = true;
                    }
                } while (validEntry == false);

                // get a description of the pet's physical appearance/condition - animalPhysicalDescription can be blank.
                do {
                    Console.WriteLine("\n\rEnter pet's physical description (size, color, gender, weight, housebroken)");
                    readResult = Console.ReadLine();

                        if (readResult != null) {
                            animalPhysicalDescription = readResult.ToLower();

                            if (animalPhysicalDescription == "")
                                animalPhysicalDescription = "tbd";
                        }
                    } while (animalPhysicalDescription == "");

                // get a description of the pet's personality - animalPersonalityDescription can be blank.
                do {
                    Console.WriteLine("\n\rEnter pet's personality description (likes or dislikes, tricks, energy level)");
                    readResult = Console.ReadLine();

                    if (readResult != null) {
                        animalPersonalityDescription = readResult.ToLower();

                        if (animalPersonalityDescription == "")
                            animalPersonalityDescription = "tbd";
                    }
                } while (animalPersonalityDescription == "");

                //get the pet's nickname. animalNickname can be blank.
                do {
                    Console.WriteLine("\n\rEnter pet's nickname");
                    readResult = Console.ReadLine();

                    if (readResult != null) {
                        animalNickname = readResult.ToLower();

                        if (animalNickname == "")
                            animalNickname = "tbd";
                    }
                } while (animalNickname == "");

                // store the pet information in the ourAnimals array (zero based)
                ourAnimals[petCount, 0] = "ID #: " + animalID;
                ourAnimals[petCount, 1] = "Species: " + animalSpecies;
                ourAnimals[petCount, 2] = "Age: " + animalAge;
                ourAnimals[petCount, 3] = "Nickname: " + animalNickname;
                ourAnimals[petCount, 4] = "Physical description: " + animalPhysicalDescription;
                ourAnimals[petCount, 5] = "Personality: " + animalPersonalityDescription;

                petCount++;

                if (petCount < maxPets) {
                    Console.WriteLine("Would you enter another pet's characteristic? (y/n)");

                    do {
                        readResult = Console.ReadLine();

                           if (readResult != null)
                            anotherPet = readResult.ToLower();

                    } while (anotherPet != "y" && anotherPet != "n");
                }
            }

            if (petCount >= maxPets) {
                Console.WriteLine("We have reached our limit on the number of pets that we can manage.");
                Console.WriteLine("Press the Enter key to continue.");
                readResult = Console.ReadLine();
            }
            break;

        case "3":
            //Ensure animal ages and physical descriptions are complete
            //Console.WriteLine("Challenge Project - please check back soon to see progress.");
            validEntry = false;
            validData = false;
            string correctData = "n";

            for (int i = 0; i < maxPets; i++) {

                if (ourAnimals[i, 0] != "ID #: ") {
                    
                    if (ourAnimals[i, 2] == "Age: " || ourAnimals[i, 2] == "Age: ?") {

                        do {

                            do {
                                Console.WriteLine($"Enter an age for {ourAnimals[i, 0]}");
                                readResult = Console.ReadLine();

                                if (readResult != null) {
                                    animalAge = readResult;

                                    if (animalAge != "?")                        
                                        validEntry = int.TryParse(animalAge, out petAge);
                                    else
                                        validEntry = false;
                                }

                            } while (validEntry == false);

                            do {
                                Console.WriteLine($"Enter a physical description for {ourAnimals[i, 0]} (size, color, gender, weight, housebroken)");
                                readResult = Console.ReadLine();

                                if (readResult != null) {
                                    animalPhysicalDescription = readResult;

                                    if (animalPhysicalDescription != "") 
                                        validEntry = true;
                                    else
                                        validEntry = false;
                                }

                            } while (validEntry == false);

                            Console.WriteLine($"------------\nPetID: {ourAnimals[i, 0]}\nAge: {animalAge}\nPhysical description: {animalPhysicalDescription}");
                            Console.WriteLine("\nAre these data correct? (y/n)");
                            readResult = Console.ReadLine();

                            if (readResult != null) {
                                correctData = readResult.ToLower();

                                if (correctData == "y") {
                                    validData = true;
                                    ourAnimals[i, 2] = "Age: " + animalAge;
                                    ourAnimals[i, 4] = "Physical description: " + animalPhysicalDescription;
                                    Console.WriteLine("Data inserted.");
                                } else
                                    validData = false;
                            }

                        } while (validData == false);
                    }
                }
            }

            Console.WriteLine("Age and physical description fields are complete for all of our friends.");
            Console.WriteLine("Press the Enter key to continue.");
            readResult = Console.ReadLine();
            break;

        case "4":
            //Ensure animal nicknames and personality descriptions are complete
            //Console.WriteLine("UNDER CONSTRUCTION - please check back next month to see progress.");

            validEntry = false;
            validData = false;
            correctData = "n";

            for (int i = 0; i < maxPets; i++) {
                Console.WriteLine(ourAnimals[i, 0]);
                if (ourAnimals[i, 0] != "ID #: ") {
                    //
                    //Console.WriteLine(ourAnimals[i, 3]); }
                    

                        if (ourAnimals[i, 3] == "Nickname: ") {

                            do {

                                Console.WriteLine($"Enter a nickname for {ourAnimals[i, 0]}");
                                readResult = Console.ReadLine();

                                if (readResult != null) {
                                    animalNickname = readResult;

                                    if (animalNickname != "")
                                        validEntry = true;
                                    else
                                        validEntry = false;
                                }
                            } while (validEntry == false);
                        }   

                        else if (ourAnimals[i, 5] == "Personality:  ") {

                            do {
                                    
                                Console.WriteLine($"Enter a personality description for {ourAnimals[i, 0]}");
                                readResult = Console.ReadLine();

                                if (readResult != null) {
                                    animalPersonalityDescription = readResult;

                                    if (animalPersonalityDescription != "")
                                        validEntry = true;
                                    else
                                        validEntry = false;
                                }
                            } while (validEntry == false);
                        }

                        /*Console.WriteLine($"------------\nPetID: {ourAnimals[i, 0]}\nNickname: {animalNickname}\nPersonality description: {animalPersonalityDescription}");
                        Console.WriteLine("\nAre these data correct? (y/n)");
                        readResult = Console.ReadLine();

                        if (readResult != null) {
                            correctData = readResult.ToLower();

                            if (correctData == "y") {
                                validData = true;
                                ourAnimals[i, 3] = "Nickname: " + animalNickname;
                                ourAnimals[i, 5] = "Personality: " + animalPersonalityDescription;
                                Console.WriteLine("Data inserted.");
                            } 
                            else
                                validData = false;
                        }*/
                    } while (validData == false);
                }
            
            
            Console.WriteLine("Nickname and personality description fields are complete for all of our friends.");
            Console.WriteLine("Press the Enter key to continue.");
            readResult = Console.ReadLine();
            break;
        
        case "5":
            //Edit an animal’s age
            Console.WriteLine("UNDER CONSTRUCTION - please check back next month to see progress.");
            Console.WriteLine("Press the Enter key to continue.");
            readResult = Console.ReadLine();
            break;
        case "6":
            //Edit an animal’s personality description
            Console.WriteLine("UNDER CONSTRUCTION - please check back next month to see progress.");
            Console.WriteLine("Press the Enter key to continue.");
            readResult = Console.ReadLine();
            break;
        case "7":
            //Display all cats with a specified characteristic
            Console.WriteLine("UNDER CONSTRUCTION - please check back next month to see progress.");
            Console.WriteLine("Press the Enter key to continue.");
            readResult = Console.ReadLine();
            break;
        case "8":
            //Display all dogs with a specified characteristic
            Console.WriteLine("UNDER CONSTRUCTION - please check back next month to see progress.");
            Console.WriteLine("Press the Enter key to continue.");
            readResult = Console.ReadLine();
            break;
        default:
            break;
    }

} while (menuSelection != "exit");