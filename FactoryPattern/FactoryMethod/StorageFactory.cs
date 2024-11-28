namespace FactoryPattern.FactoryMethod;
using FactoryPattern.Models;

public enum StorageType
{
    File = 1,
    Database = 2,
}

public class StorageFactory
{
 //public IStorage GetStorage(string storageType)
 public IStorage GetStorage(StorageType storageType)
 {
    switch(storageType)
    {
        //case"file":
        case StorageType.File:
        return new FileStorage();
        //break;
        //case "database":
        case StorageType.Database:
        return new DataStorage();
        //break;
        default:
        return new FileStorage();
        //break;
    }
 }
}