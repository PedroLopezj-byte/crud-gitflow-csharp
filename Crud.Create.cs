static partial class Crud
{
    public static void Create()
    {
        Console.Write("Titulo: ");
        var title = Console.ReadLine() ?? "";
        Console.Write("Descripcion: ");
        var desc = Console.ReadLine() ?? "";

        var id = ItemStore.Items.Count == 0 ? 1 : ItemStore.Items.Max(i => i.Id) + 1;
        ItemStore.Items.Add(new Item { Id = id, Title = title, Description = desc });
        ItemStore.Save();
        Console.WriteLine("Item creado.");
    }
}
