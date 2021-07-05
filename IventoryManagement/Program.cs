using System;
using System.IO;
using Newtonsoft.Json;

namespace IventoryManagement
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Welcome to Inventory Management Program");
            string filepath = @"C:\Users\afrat\source\repos\IventoryManagement\IventoryManagement\InventoryDetails.json";
            InventoryManager inventoryManager = new InventoryManager();
            InventoryContents inventoryContents = JsonConvert.DeserializeObject<InventoryContents>(File.ReadAllText(filepath));
            Console.WriteLine("Enter 1 to get details about Rice!");
            Console.WriteLine("Enter 2 to get details about Wheat!");
            Console.WriteLine("Enter 3 to get details about Pulses!");

            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    Console.WriteLine("Enter 1 to display contents of rice");
                    Console.WriteLine("Enter 2 to add contents of rice");
                    Console.WriteLine("Enter 3 to remove contents of rice");
                    Console.WriteLine("Enter 4 to modifiy contents of rice");
                    int roptions = Convert.ToInt32(Console.ReadLine());
                    switch (roptions)
                    {
                        case 1:
                            inventoryManager.DisplayTheContentInInventory(inventoryContents.ricelist);
                            break;
                        case 2:
                            inventoryManager.AddToInventory(inventoryContents.ricelist);
                            File.WriteAllText(filepath,JsonConvert.SerializeObject(inventoryContents));
                            Console.WriteLine("After Insertion:");
                            inventoryManager.DisplayTheContentInInventory(inventoryContents.ricelist);
                            break;
                        case 3:
                            inventoryManager.DeleteFromInventory(inventoryContents.ricelist);
                            File.WriteAllText(filepath, JsonConvert.SerializeObject(inventoryContents));
                            Console.WriteLine("After Deletion:");
                            inventoryManager.DisplayTheContentInInventory(inventoryContents.ricelist);
                            break;
                        case 4:
                            inventoryManager.UpdateInventory(inventoryContents.ricelist);
                            File.WriteAllText(filepath, JsonConvert.SerializeObject(inventoryContents));
                            Console.WriteLine("After Updation:");
                            inventoryManager.DisplayTheContentInInventory(inventoryContents.ricelist);
                            break;
                    }
                    break;
                case 2:
                    Console.WriteLine("Enter 1 to display contents of wheat");
                    Console.WriteLine("Enter 2 to add contents of wheat");
                    Console.WriteLine("Enter 3 to remove contents of wheat");
                    Console.WriteLine("Enter 4 to modifiy contents of wheat");
                    int woptions = Convert.ToInt32(Console.ReadLine());
                    switch (woptions)
                    {
                        case 1:
                            inventoryManager.DisplayTheContentInInventory(inventoryContents.wheatlist);
                            break;
                        case 2:
                            inventoryManager.AddToInventory(inventoryContents.wheatlist);
                            File.WriteAllText(filepath, JsonConvert.SerializeObject(inventoryContents));
                            Console.WriteLine("After Insertion:");
                            inventoryManager.DisplayTheContentInInventory(inventoryContents.wheatlist);
                            break;
                        case 3:
                            inventoryManager.DeleteFromInventory(inventoryContents.wheatlist);
                            File.WriteAllText(filepath, JsonConvert.SerializeObject(inventoryContents));
                            Console.WriteLine("After Deletion:");
                            inventoryManager.DisplayTheContentInInventory(inventoryContents.ricelist);
                            break;
                        case 4:
                            inventoryManager.UpdateInventory(inventoryContents.wheatlist);
                            File.WriteAllText(filepath, JsonConvert.SerializeObject(inventoryContents));
                            Console.WriteLine("After Updation:");
                            inventoryManager.DisplayTheContentInInventory(inventoryContents.ricelist);
                            break;
                    }
                    break;
                case 3:
                    Console.WriteLine("Enter 1 to display contents of pulses");
                    Console.WriteLine("Enter 2 to add contents of pulses");
                    Console.WriteLine("Enter 3 to remove contents of pulses");
                    Console.WriteLine("Enter 4 to modifiy contents of pulses");
                    int poptions = Convert.ToInt32(Console.ReadLine());
                    switch (poptions)
                    {
                        case 1:
                            inventoryManager.DisplayTheContentInInventory(inventoryContents.pulselist);
                            break;
                        case 2:
                            inventoryManager.AddToInventory(inventoryContents.pulselist);
                            File.WriteAllText(filepath, JsonConvert.SerializeObject(inventoryContents));
                            Console.WriteLine("After Insertion:");
                            inventoryManager.DisplayTheContentInInventory(inventoryContents.pulselist);
                            break;
                        case 3:
                            inventoryManager.DeleteFromInventory(inventoryContents.pulselist);
                            File.WriteAllText(filepath, JsonConvert.SerializeObject(inventoryContents));
                            Console.WriteLine("After Deletion:");
                            inventoryManager.DisplayTheContentInInventory(inventoryContents.pulselist);
                            break;
                        case 4:
                            inventoryManager.UpdateInventory(inventoryContents.pulselist);
                            File.WriteAllText(filepath, JsonConvert.SerializeObject(inventoryContents));
                            Console.WriteLine("After Updation:");
                            inventoryManager.DisplayTheContentInInventory(inventoryContents.pulselist);
                            break;
                    }
                    break;
            }
        

            
        }
    }
}
