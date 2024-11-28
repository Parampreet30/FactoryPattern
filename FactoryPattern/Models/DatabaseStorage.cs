namespace FactoryPattern.Models;

public class DataStorage : IStorage
{
    public int GetStorage()
    {
        return 2;
    }

    public void SaveData(string data)
    {
        //Console.WriteLine(data);
         Console.WriteLine($"{this.GetStorage()}:> {data}");
    }
}