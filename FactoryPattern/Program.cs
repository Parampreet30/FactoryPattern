namespace FactoryPattern.Models;

public interface IStorage
{
    public int GetStorage();
    public void SaveData(string data);
}
