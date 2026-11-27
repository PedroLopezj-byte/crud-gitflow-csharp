ItemStore.Load();

while (true)
{
    Console.WriteLine("\n=== CRUD de Items ===");
    Console.WriteLine("1. Crear item");
    Console.WriteLine("2. Listar items");
    Console.WriteLine("3. Editar item");
    Console.WriteLine("4. Eliminar item");
    // MENU
    Console.WriteLine("0. Salir");
    Console.Write("Opcion: ");
    switch (Console.ReadLine())
    {
        case "1": Crud.Create(); break;
        case "2": Crud.ListAll(); break;
        case "3": Crud.Update(); break;
        case "4": Crud.Delete(); break;
        // CASES
        case "0": return;
        default: Console.WriteLine("Opcion invalida."); break;
    }
}
