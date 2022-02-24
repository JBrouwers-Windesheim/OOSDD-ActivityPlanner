using ActivityPlanner.ConsoleUI;

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
Invitee[] invitees = new Invitee[1];

string fullName = $"{organizer.FirstName} {(organizer.SurnamePrefix + " ").TrimStart()}{organizer.Surname}";

//Display the invitations per invitee
Console.WriteLine("Organizer " + fullName);

