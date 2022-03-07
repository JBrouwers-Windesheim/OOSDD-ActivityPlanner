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
//inviteeList.Add()

//List<string> stringList = new List<string>();
//stringList.Add()




//Display the invitations per invitee
Console.WriteLine("Organizer " + organizer.FullName);

