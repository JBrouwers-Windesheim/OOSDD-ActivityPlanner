using ActivityPlanner.ConsoleUI;
using System.Collections;

//declare a variable(reserve memory) and create an object instance (load an object)
Organizer organizer = new Organizer();

organizer.FirstName = ConsoleHelper.GetUserInput("firstname", true);
organizer.SurnamePrefix = ConsoleHelper.GetUserInput("surname prefix");
organizer.Surname = ConsoleHelper.GetUserInput("surname", true);

//Ask which activity is being organized
string activityTitle = ConsoleHelper.GetUserInput("Title", true);
string activityDescription = ConsoleHelper.GetUserInput("Description");


//Ask which dates the invitees can choose from

//Ask for the amount of invitees
Invitee[] inviteeArray = new Invitee[1];
inviteeArray[0] = new Invitee("Jan", "Jansen");
Console.WriteLine(inviteeArray[0].FirstName);
//Maak een Person Array, stop er Invitees in en lees de invitees uit 

List<Invitee> inviteeList = new List<Invitee>();
inviteeList.Add(new Invitee("Jan", "Jansen"));
inviteeList.Add(new Invitee("Marie", "Mariessen"));
inviteeList.Add(new Invitee("Pieter", "Pietersen"));

//sorteer de genodigden (standaard sortering is op achternaam)
inviteeList.Sort();//implementeer de generic IComparable in Person (by Surname)

//en geef de genodigden weer
foreach (var invitee in inviteeList)
{
    Console.WriteLine(invitee.FullName);
}


//Display the invitations per invitee
Console.WriteLine("Organizer " + organizer.FullName);

