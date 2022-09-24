// If

Console.WriteLine("What grade did you get?");

char Grade = Convert.ToChar(Console.ReadLine().ToUpper());

if (Grade == 'A')
{
    Console.WriteLine("Excellent!");
}
else if (Grade == 'B')
{
    Console.WriteLine("Very good!");
}
else if (Grade == 'C')
{
    Console.WriteLine("Good.");
}
else if (Grade == 'D')
{
    Console.WriteLine("Satisfactory.");
}
else if (Grade == 'E')
{
    Console.WriteLine("Poor.");
}
else if (Grade == 'F')
{
    Console.WriteLine("Incomplete.");
}
else
{
    Console.WriteLine("Wrong value.");
}