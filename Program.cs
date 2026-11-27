ItemStore.Load();

while (true)
{
    Console.WriteLine("\n=== CRUD de Items ===");
    Console.WriteLine("1. Crear item");
    Console.WriteLine("2. Listar items");
    // MENU
    Console.WriteLine("0. Salir");
    Console.Write("Opcion: ");
    switch (Console.ReadLine())
    {
        case "1": Crud.Create(); break;
        case "2": Crud.ListAll(); break;
        // CASES
        case "0": return;
        default: Console.WriteLine("Opcion invalida."); break;
    }
}
