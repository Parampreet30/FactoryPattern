using FactoryPattern.FactoryMethod;

StorageFactory factory = new StorageFactory();


Console.WriteLine("What type of storage do you want?");

Console.WriteLine("\t1. File");

Console.WriteLine("\t1. Datbase");
var storageString = Console.ReadLine();
var storageType = int.Parse(storageString ?? "0");





//if (storageType is not null)
//{
    //var storage = factory.GetStorage(storageType ?? "");
    var storage = factory.GetStorage((StorageType)storageType);


Console.WriteLine("What  is your data?");
  var data = Console.ReadLine();

  storage.SaveData(data ?? "");
//}