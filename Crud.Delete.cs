static partial class Crud
{
    public static void Delete()
    {
        Console.Write("Id del item a eliminar: ");
        if (!int.TryParse(Console.ReadLine(), out var id))
        {
            Console.WriteLine("Id invalido.");
            return;
        }

        var removed = ItemStore.Items.RemoveAll(i => i.Id == id);
        if (removed == 0)
        {
            Console.WriteLine("No existe ese item.");
            return;
        }

        ItemStore.Save();
        Console.WriteLine("Item eliminado.");
    }
}
