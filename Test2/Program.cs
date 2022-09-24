// Switch

Console.WriteLine("What grade did you get?");

char Grade = Convert.ToChar(Console.ReadLine().ToUpper());

switch (Grade)
{
    case 'A':
        Console.WriteLine("Excellent!");
        break;
    case 'B':
        Console.WriteLine("Very good!");
        break;
    case 'C':
        Console.WriteLine("Good.");
        break;
    case 'D':
        Console.WriteLine("Satisfactory.");
        break;
    case 'E':
        Console.WriteLine("Poor.");
        break;
    case 'F':
        Console.WriteLine("Incomplete.");
        break;
    default:
        Console.WriteLine("Wrong value.");
        break;
}