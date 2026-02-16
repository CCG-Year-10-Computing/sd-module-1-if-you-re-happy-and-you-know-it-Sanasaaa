// Program Name: 
// Created on: 10/02/26
// Author: Sarrah

using System.ComponentModel.Design;

Console.Write("HOTPOT HOTPOT HOTPOT");
Console.WriteLine();
Console.WriteLine("--------------------");

// collecting name
Console.WriteLine();
Console.Write("What is your name?: ");
string name = Console.ReadLine();
Console.WriteLine($"Hello {name}! You are very hungry so you go get hotpot.");

// fav colour-shopping
Console.WriteLine();
Console.Write("You walk by some shops and see a cool shirt. Do you want to go inside and buy it? (yes or no): ");
string response = Console.ReadLine().ToLower();


if (response == "yes")

{
    Console.WriteLine();
    Console.Write("Whats your favourite colour?: ");
    string colour = Console.ReadLine();
    Console.WriteLine($"You go into the store and find the shirt in your favourite colour {colour}");
    Console.WriteLine();    
    Console.WriteLine($"After choosing your {colour} shirt, you go to check out. Do you decide you buy it?(yes or no)");
    
    string response2 = Console.ReadLine().ToLower();

    if (response2 == "yes")

    {
        Console.WriteLine();
        Console.WriteLine("You purchase the shirt then continue your way to hotpot");
    }

    else if (response2 == "no")

    {
        Console.WriteLine();
        Console.WriteLine("You put the shirt back, leave the store, then continue your way to hotpot.");
    }
}

else

{
    Console.WriteLine($"You walk by the shop and keep walking to hotpot.");
}


// friends name
Console.WriteLine();
Console.WriteLine($"After some shopping, you see your friend walking on the other side of the road, do you say hi? (yes or no)");
string answer = Console.ReadLine().ToLower();

if ( answer == "yes")

{
    Console.WriteLine();
    Console.Write("What's your friends name?: ");
    string fname = Console.ReadLine();
    Console.WriteLine($"You greet {fname} and insist they join you at hotpot.");
    Console.WriteLine($"Does {fname} agree to join you at hotpot? (yes/no): ");

    string fnameres = Console.ReadLine().ToLower();
    if ( fnameres == "yes")

    {
        Console.WriteLine($"You and {fname} walk to hotpot and eat together");
        Console.WriteLine($"{fname} decides to head home and says goodbye");
    }

    else if( fnameres == "no")

    {
        Console.WriteLine("You walk to hot pot alone.");
    }
}
else if ( answer == "no" )
{
    Console.WriteLine("You walk past them.");
    Console.WriteLine("You got to hot pot alone.");
}

Console.WriteLine("After a fun day you decide to go home with your belly full of hot pot.");

// at home
Console.WriteLine("You arrive home.");
Console.WriteLine("Do you have a pet? (yes/no)");
string response3 = Console.ReadLine().ToLower();

if (response3 == "yes")

{
    Console.WriteLine("What pet do you have?: ");
    string pet = Console.ReadLine();
    Console.WriteLine($"You greet your {pet} then go to bed.");
}

else if     ( response3 == "no")
{
    Console.WriteLine("You go to bed.");
}

Console.WriteLine("You wake up the next morning and get ready for school.");
Console.WriteLine("You look at your timetable and your next class is Math");

// math class
int length;
int width;
int area;
Console.WriteLine("You go to Math class. Your teacher asks you to calculate the area of a rectangle");
Console.WriteLine("What is the length of the rectangle?: ");
string response4 = Console.ReadLine();
length = Convert.ToInt32(response4);
Console.WriteLine("What is the width of the rectangle?");
response4 = Console.ReadLine();
width = Convert.ToInt32(response4);
area = length * width;
Console.WriteLine($"The area of the rectangle is {length} x {width} = {area}");
Console.WriteLine("You finish class and manage to complete all your timestables");

Console.WriteLine("")
Console.WriteLine("END");