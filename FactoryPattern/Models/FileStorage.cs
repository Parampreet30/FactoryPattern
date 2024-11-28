namespace FactoryPattern.Models;

public class FileStorage : IStorage
{
    public int GetStorage()
    {
        return 2;
    }

    public void SaveData(string data)
    {
        Console.WriteLine($"{this.GetStorage()}:> {data}");
    }
}