// Las Colecciones en C# son objetos, por lo tanto ademas, son tipos de referencia

// Forma 1: Declaracion y asignacion en una Linea sin valores iniciales
using Dictionary_Practice_02;

Dictionary<string, int> miDiccionario1 = new Dictionary<string, int>();

// Forma 2: Declaración y asignación en una línea sin valores iniciales con capacidad inicial especificada
Dictionary<string, int> miDiccionario2 = new Dictionary<string, int>(10);

// Forma 3: Declaración e inicialización en una sola línea con elementos
Dictionary<string, int> miDiccionario3 = new Dictionary<string, int>()
{
    {"clave1", 1},
    {"clave2", 2},
    {"clave3", 3}
};

// Forma 4: Declaracion y asignacion en varias Lineas
Dictionary<string, int> miDiccionario4;
miDiccionario4 = new Dictionary<string, int>();

//-----------------------------------------------------------------------------------------------

// Forma 1: Declarar Objetos // Declaracion y asignacion en una Linea sin valores iniciales
Dictionary<string, Auto> garageDePepe = new Dictionary<string, Auto>();

// Forma 2: Declarar Objetos // Declaración y asignación en una línea sin valores iniciales con capacidad inicial especificada
Dictionary<string, Auto> garageDeAlejandra = new Dictionary<string, Auto>(10);

// Forma 3 Declarar Objetos // Declaración e inicialización en una sola línea con elementos
Dictionary<string, Auto> garageDeRoman = new Dictionary<string, Auto>()
{
    {"clave1", new Auto("ABC123", "Toyota", 2012)},
    {"clave2", new Auto("XYZ789", "Ford", 2015)},
    {"clave3", new Auto("123ABC", "Honda", 2018)}
    // Puedes seguir agregando más objetos Auto aquí si es necesario
};

// Forma 4: Declarar Objetos // Declaracion y asignacion en varias Lineas
Dictionary<string, Auto> garageDeLucia;
garageDeLucia = new Dictionary<string, Auto>();

