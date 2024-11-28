namespace FactoryPattern.AbstractFactory;

using FactoryPattern.Models;

public abstract class StorageAbstractFactory
{
 public abstract IStorage GetStorage(StorageType storageType);
}
