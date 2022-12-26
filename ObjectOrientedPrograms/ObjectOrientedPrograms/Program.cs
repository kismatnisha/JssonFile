using ObjectOrientedPrograms.Inventorymanagement;
using ObjectOrientedPrograms.InventoryManagementSystem;
using ObjectOrientedPrograms.StockManagement;

namespace ObjectOrientedPrograms
{
    public class Program
    {
        const string INVENTORY_DATA_FILE_PATH = @"C:\Users\HP\Desktop\rfp\brigdelabz assignment\asignment\JsonFile\ObjectOrientedPrograms\ObjectOrientedPrograms\Inventorymanagement\Inventory.json";
        const string INVENTORYDETAILS_DATA_FILE_PATH = @"C:\Users\HP\Desktop\rfp\brigdelabz assignment\asignment\JsonFile\ObjectOrientedPrograms\ObjectOrientedPrograms\InventoryManagementSystem\InventoryDetails.json";
        const string STOCKDETAILS_DATA_FILE_PATH = @"C:\Users\HP\Desktop\rfp\brigdelabz assignment\asignment\JsonFile\ObjectOrientedPrograms\ObjectOrientedPrograms\StockManagement\StockDetails.json";

        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Select Programs\n 1.Inventory Management \n2.Inventory Manangement System \n3.Stock Management ");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        Inventory inventory = new Inventory();
                        inventory.ReadJsonFile(INVENTORY_DATA_FILE_PATH);
                        break;
                    case 2:
                        InventoryFactory inventoryFactory = new InventoryFactory();
                        inventoryFactory.ReadJsonFile(INVENTORYDETAILS_DATA_FILE_PATH);
                        InventoryDetails details = new InventoryDetails()

                        {
                            Name = "a",
                            Weight = 5,
                            Price = 25
                        };
                        inventoryFactory.AddInventory("WheatList", details);
                        //inventoryFactory.DeleteInventory("WheatList", "a");
                        inventoryFactory.WriteTojson(INVENTORYDETAILS_DATA_FILE_PATH);
                        break;
                    case 3:
                        Stock stock = new Stock();
                        stock.ReadJsonFile(STOCKDETAILS_DATA_FILE_PATH);
                        break;
                }
            }
        }
    }
}