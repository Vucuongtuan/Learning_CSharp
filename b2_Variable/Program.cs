// This program demonstrates declaring variables of different data types
// and displaying their names, types, and values in a formatted table.

Console.WriteLine("--- C# Variable Declaration and Information ---");

// Declare and initialize variables of different types.
int age = 25;
string name = "Alice";
double height = 1.68;
bool isStudent = true;

// Print a formatted table header.
Console.WriteLine($"{"Variable Name",-15} | {"Data Type",-15} | {"Value"}");
Console.WriteLine(new string('-', 50));

// Print information for each variable using string interpolation and the nameof operator.
// The 'nameof' operator gets the string name of a variable, which is safer for refactoring.
Console.WriteLine($"{nameof(age),-15} | {age.GetType().Name,-15} | {age}");
Console.WriteLine($"{nameof(name),-15} | {name.GetType().Name,-15} | {name}");
Console.WriteLine($"{nameof(height),-15} | {height.GetType().Name,-15} | {height}");
Console.WriteLine($"{nameof(isStudent),-15} | {isStudent.GetType().Name,-15} | {isStudent}");