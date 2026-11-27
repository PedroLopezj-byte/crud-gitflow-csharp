using System.Text.Json;

static class ItemStore
{
    private const string FilePath = "items.json";

    public static List<Item> Items { get; private set; } = new();

    public static void Load()
    {
        if (!File.Exists(FilePath)) return;
        Items = JsonSerializer.Deserialize<List<Item>>(File.ReadAllText(FilePath)) ?? new();
    }

    public static void Save()
    {
        var options = new JsonSerializerOptions { WriteIndented = true };
        File.WriteAllText(FilePath, JsonSerializer.Serialize(Items, options));
    }
}
