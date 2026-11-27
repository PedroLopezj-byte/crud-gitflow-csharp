static partial class Crud
{
    public static void Update()
    {
        Console.Write("Id del item a editar: ");
        if (!int.TryParse(Console.ReadLine(), out var id))
        {
            Console.WriteLine("Id invalido.");
            return;
        }

        var item = ItemStore.Items.FirstOrDefault(i => i.Id == id);
        if (item is null)
        {
            Console.WriteLine("No existe ese item.");
            return;
        }

        Console.Write("Nuevo titulo: ");
        var newTitle = Console.ReadLine() ?? "";
        Console.Write("Nueva descripcion: ");
        var newDesc = Console.ReadLine() ?? "";

        item.Title = newTitle;
        item.Description = newDesc;
        ItemStore.Save();
        Console.WriteLine("Item actualizado.");
    }
}
