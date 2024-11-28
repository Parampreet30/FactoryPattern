using FactoryPattern.FactoryMethod;

StorageFactory factory = new StorageFactory();


Console.WriteLine("What type of storage do you want?");
var storageType = Console.ReadLine();

if (storageType is not null)
{
    var storage = factory.GetStorage(storageType ?? "");

Console.WriteLine("What  is your data?");
  var data = Console.ReadLine();

  storage.SaveData(data ?? "");
}