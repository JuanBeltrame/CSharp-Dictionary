using Dictionary_Practice_01;

Auto auto1 = new Auto("1234", "Fiat", 2005);
Auto auto2 = new Auto("1234", "Renault", 1998);
Auto auto3 = new Auto("1234", "Peugeot", 2002);


//----------------------------------------------------------------------------------------------------
// Ejemplo 01
Dictionary<string, int> agenda = new Dictionary<string, int>();

// La KEY no se puede repetir, El valor SI se puede repetir
agenda.Add("Lautaro", 123456);
agenda.Add("Mauricio", 123459);
agenda.Add("Lucas", 2343459);

// Como Recorrer
Console.WriteLine();
foreach (KeyValuePair<string, int> kvp in agenda)
{
    Console.ForegroundColor = ConsoleColor.Green; Console.WriteLine(kvp);
}

// Ahora bien, si lo quiero mostrar por separado seria de la siguiente manera
Console.WriteLine();
foreach (KeyValuePair<string, int> kvp in agenda)
{
    Console.ForegroundColor = ConsoleColor.Red; Console.WriteLine($"Nombre: {kvp.Key} Numero: {kvp.Value}");
}

// Para recorrer solo las keys
Console.WriteLine();
foreach (var kvp in agenda.Keys)
{
    Console.ForegroundColor = ConsoleColor.Blue; Console.WriteLine(kvp);
}

// Para recorrer solo los values
Console.WriteLine();
foreach (var kvp in agenda.Values)
{
    Console.ForegroundColor = ConsoleColor.Yellow; Console.WriteLine(kvp);
}


Console.WriteLine();
foreach (KeyValuePair<string, int> kvp in agenda)
{
    if (agenda.ContainsKey("Lucas"))
        Console.WriteLine("Lucas esta agendado...");
    if (agenda.ContainsValue(123456))
        Console.WriteLine("Exito");
}

Console.WriteLine();
if (agenda.TryGetValue("Lautaro", out int value))
{
    Console.WriteLine(value);
}


//----------------------------------------------------------------------------------------------------
// Ejemplo 02
Dictionary<string, string> diccionario = new Dictionary<string, string>();

// La KEY no se puede repetir, El valor SI se puede repetir
diccionario.Add("Taco", "Mexico");
diccionario.Add("Burrito", "Mexico");
diccionario.Add("Pizza", "Italia");

Console.WriteLine();
foreach (KeyValuePair<string, string> kvp in diccionario)
{
    Console.ForegroundColor = ConsoleColor.Magenta; Console.WriteLine($"Key: {kvp.Key} Value: {kvp.Value}");
}

Console.WriteLine();
// Para eliminar, se hace por medio de la Key
diccionario.Remove("Taco");
Console.WriteLine("---------------");
foreach (var kvp in diccionario)
{
    Console.ForegroundColor = ConsoleColor.Cyan; Console.WriteLine($"Key: {kvp.Key} Value: {kvp.Value}");
}

Console.WriteLine();
Console.WriteLine("---------------");
// Los diccinarios estan indexados
diccionario["Burrito"] = "USA";
foreach (var kvp in diccionario)
{
    Console.ForegroundColor = ConsoleColor.DarkCyan; Console.WriteLine($"Key: {kvp.Key} Value: {kvp.Value}");
}


// Metodos ContainsKey/ContainsValue
Console.WriteLine(diccionario.ContainsKey("Pasta"));
Console.WriteLine(diccionario.ContainsKey("Burrito"));
Console.WriteLine(diccionario.ContainsValue("Italia"));
Console.WriteLine(diccionario.ContainsValue("Argentina"));

Console.WriteLine();
Console.WriteLine(diccionario.Count());

// Se puede acceder a un elemento pasandole la key, ya que estan indexados por key // Indexacion en base a la Key
Console.WriteLine(diccionario["Pizza"]);


//----------------------------------------------------------------------------------------------------
// Ejemplo 03
Dictionary<string, List<string>> wishList = new Dictionary<string, List<string>>();

wishList.Add("Tim Corey", new List<string> { "Xbox", "Tesla", "Pizza" });
wishList.Add("Billy Bob", new List<string> { "PS5", "Ford", "Hoagie" });
wishList.Add("Mary Jane", new List<string> { "House", "Car", "Sub" });

foreach (var (key, vAlue) in wishList)
{
    Console.WriteLine($"{key}'s Whislist: ");
    foreach (var item in vAlue)
    {
        Console.WriteLine($"\t{item}");
    }
}

Console.WriteLine(wishList["Tim Corey"][0]);
Console.WriteLine(wishList["Tim Corey"][1]);
Console.WriteLine(wishList["Tim Corey"][2]);