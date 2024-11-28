namespace FactoryPattern.FactoryMethod;
using FactoryPattern.Models;

public class StorageFactory
{
 public IStorage GetStorage(string storageType)
 {
    switch(storageType)
    {
        case"file":
        return new FileStorage();
        //break;
        case "database":
        return new DataStorage();
        //break;
        default:
        return new FileStorage();
        //break;
    }
 }
}