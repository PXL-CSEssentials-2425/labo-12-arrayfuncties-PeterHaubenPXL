// See https://aka.ms/new-console-template for more information

string[] names = new string[10]{"Peter", "Tom", "Piet", "Ahmed", "Benny", "Anna", "Jane", "Ali", "John", "Tom"};

// Deel 1

Console.WriteLine($"Deel 1: \n");
Console.Write("Geef een naam in: ");
string chosenName = Console.ReadLine();
int index = 0;

index = Array.IndexOf(names, chosenName);

if (index > -1)
{
    Console.WriteLine($"De naam \"{chosenName}\"staat op plaats {(index + 1)}.");
}
else
{
    Console.WriteLine($"De naam {chosenName} komt niet voor in de gegevens");
}
Console.WriteLine();


// Deel 2

Console.WriteLine($"Deel 2: \n");
Console.Write("Geef een Letter in: ");
string letter = Console.ReadLine();

if (!string.IsNullOrEmpty(letter) && char.IsLetter(letter[0]))
{
    //char firstLetter = char.ToLower(letter[0]);

    string[] filteredNames = Array.FindAll(names, name => name.ToUpper().StartsWith(letter.ToUpper()));

    if (filteredNames.Length > 0)
    {
        Console.WriteLine($"Namen die beginnen met {letter}: {string.Join(", ", filteredNames)}");
    }
    else
    {
        Console.WriteLine($"Er zijn geen namen met letter {letter}");
    }
}
else
{
    Console.WriteLine("Voer een geldige letter in");
}


// Deel 3

string input1;
string input2;
int number1;
int number2;

Console.WriteLine();
do {
    Console.Write($"Geef eerste getal in tussen 0 en {names.Length}:");
    input1 = Console.ReadLine();
} while (!int.TryParse(input1,out number1) || number1<0 || number1>names.Length);

do
{
    Console.Write($"Geef tweede getal in tussen 0 en {names.Length - number1}:");
    input2 = Console.ReadLine();
} while (!int.TryParse(input2, out number2) || number2 < 0 || number2 > names.Length - number1);

Console.WriteLine($"Eerste getal: {number1}");
Console.WriteLine($"Tweede getal: {number2}");

Console.Write("Ongesorteerde array: ");

for(int i = 0;i < names.Length; i++)
{
    Console.Write(names[i] + ", ");
}
Console.WriteLine();

Array.Sort(names, number1, number2);
Console.Write("Gesorteerde array: ");
foreach(var item in names)
{
    Console.Write(item + ", ");
}

Console.ReadLine();