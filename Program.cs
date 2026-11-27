ItemStore.Load();

while (true)
{
    Console.WriteLine("\n=== CRUD de Items ===");
    // MENU
    Console.WriteLine("0. Salir");
    Console.Write("Opcion: ");
    switch (Console.ReadLine())
    {
        // CASES
        case "0": return;
        default: Console.WriteLine("Opcion invalida."); break;
    }
}
