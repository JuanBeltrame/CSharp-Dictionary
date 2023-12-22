//----------Programa Principal----------

Dictionary<string, string> fruits = new Dictionary<string, string>()
{
    {"apple", "red"},
    {"banana", "yellow"},
    {"orange", "orange"},
    {"grape", "purple"},
    {"kiwi", "brown"},
    {"pear", "green"},
    {"strawberry", "red"},
    {"watermelon", "green"},
    {"pineaple", "yellow"},
    {"mango", "orange"},
};

if (fruits.TryGetValue("banana", out string? bananaColor))
{
    Console.WriteLine("Found Value: " + bananaColor);
}
else
{
    Console.WriteLine("Value not found");
}
Console.ReadKey();