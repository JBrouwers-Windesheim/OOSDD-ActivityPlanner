using ActivityPlanner.ConsoleUI;

//declare a variable(reserve memory) and create an object instance (load an object)
Organizer organizer = new Organizer();

organizer.FirstName = ConsoleHelper.GetUserInput("firstname", true);
organizer.SurnamePrefix = ConsoleHelper.GetUserInput("surname prefix");
organizer.Surname = ConsoleHelper.GetUserInput("surname", true);

string[] inviteeFirstName;
string[] inviteeSurnamePrefix;
string[] inviteeSurname;




string fullName = $"{organizer.FirstName} {(organizer.SurnamePrefix + " ").TrimStart()}{organizer.Surname}";
Console.WriteLine("Hello " + fullName);

