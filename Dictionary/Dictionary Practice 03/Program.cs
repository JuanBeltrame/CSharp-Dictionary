Dictionary<string, int> agendaTelefonica = new Dictionary<string, int>();

agendaTelefonica.Add("Marcelo", 4714277);
agendaTelefonica.Add("Franky", 4713197);
agendaTelefonica.Add("Lucas", 4711005);
agendaTelefonica.Add("Juan", 4714277);
agendaTelefonica.Add("Ayelen", 4714277);


foreach (var kvp in agendaTelefonica)
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine($"Nombre: {kvp.Key}, Telefono: {kvp.Value}");
}

Console.WriteLine("Ingresar nombre");
string inputName = Console.ReadLine()!;

if (agendaTelefonica.TryGetValue(inputName, out int result))
{
    agendaTelefonica.Add(inputName, result);
}

