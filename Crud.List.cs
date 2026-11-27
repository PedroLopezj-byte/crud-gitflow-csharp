static partial class Crud
{
    public static void ListAll()
    {
        if (ItemStore.Items.Count == 0)
        {
            Console.WriteLine("No hay items.");
            return;
        }

        foreach (var item in ItemStore.Items)
            Console.WriteLine($"[{item.Id}] {item.Title} - {item.Description}");
    }
}
